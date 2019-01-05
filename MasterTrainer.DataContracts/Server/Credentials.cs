using System.Runtime.Serialization;

namespace MasterTrainer.DataContracts.Server
{
    [DataContract]
    public class Credentials
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
