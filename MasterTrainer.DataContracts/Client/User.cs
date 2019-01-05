using System;
using System.Runtime.Serialization;

namespace MasterTrainer.DataContracts.Client
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "registeredOn")]
        public DateTime RegisteredOn { get; set; }
    }
}
