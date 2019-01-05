namespace MasterTrainer.DataContracts.AuthenticationManagement
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Credentials
    {
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
