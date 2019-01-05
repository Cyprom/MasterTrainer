using System;
using System.Security.Cryptography;

namespace MasterTrainer.Business.Services
{
    public class PasswordService : IPasswordService
    {
        public string CreateHash(string password)
        {
            var salt = new byte[Constants.Hashing.SALT_BYTES];
            try
            {
                using (var cryptoServiceProvider = new RNGCryptoServiceProvider())
                {
                    cryptoServiceProvider.GetBytes(salt);
                }
            }
            catch (CryptographicException ex)
            {
                throw new ApplicationException("Random number generator not available.", ex);
            }
            catch (ArgumentNullException ex)
            {
                throw new ApplicationException("Invalid argument for the random number generator.", ex);
            }
            var hash = PBKDF2(password, salt, Constants.Hashing.PBKDF2_ITERATIONS, Constants.Hashing.HASH_BYTES);
            return $"sha1:{Constants.Hashing.PBKDF2_ITERATIONS}:{hash.Length}:{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }

        public bool VerifyPassword(string password, string storedHash)
        {
            var split = storedHash.Split(':');
            if (split.Length != Constants.Hashing.HASH_SECTIONS)
            {
                throw new ArgumentException("Fields are missing in the password hash.");
            }
            // We only support SHA1 with C#.
            if (split[Constants.Hashing.HASH_ALGORITHM_INDEX] != "sha1")
            {
                throw new ArgumentException("Invalid hash type.");
            }
            var iterations = int.Parse(split[Constants.Hashing.ITERATION_INDEX]);
            if (iterations < 1)
            {
                throw new ArgumentException("Invalid amount of iterations, must be greater than 1.");
            }

            var salt = Convert.FromBase64String(split[Constants.Hashing.SALT_INDEX]);
            var hash = Convert.FromBase64String(split[Constants.Hashing.PBKDF2_INDEX]);
            var storedHashSize = int.Parse(split[Constants.Hashing.HASH_SIZE_INDEX]);
            if (storedHashSize != hash.Length)
            {
                throw new ArgumentException("Hash length differs from the persisted hash length.");
            }

            var testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            var diff = (uint)a.Length ^ (uint)b.Length;
            for (var i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt))
            {
                pbkdf2.IterationCount = iterations;
                return pbkdf2.GetBytes(outputBytes);
            }
        }
    }
}
