using System.Runtime.Serialization;

namespace MasterTrainer.DataContracts.Server
{
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
