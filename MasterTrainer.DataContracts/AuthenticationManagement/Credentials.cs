namespace MasterTrainer.DataContracts.AuthenticationManagement
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Credentials
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
