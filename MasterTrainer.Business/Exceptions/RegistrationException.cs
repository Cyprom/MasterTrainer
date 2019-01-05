using System;

namespace MasterTrainer.Business.Exceptions
{
    public class RegistrationException : Exception
    {
        public RegistrationException(string message) : base(message) { }
    }
}
