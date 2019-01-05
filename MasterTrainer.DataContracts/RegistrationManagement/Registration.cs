namespace MasterTrainer.DataContracts.RegistrationManagement
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Registration
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
        [DataMember(Name = "confirmation")]
        public string Confirmation { get; set; }
    }
}
