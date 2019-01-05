using System.Runtime.Serialization;

namespace MasterTrainer.DataContracts.Client
{
    [DataContract]
    public class Pawn
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}
