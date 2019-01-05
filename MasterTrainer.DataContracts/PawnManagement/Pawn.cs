namespace MasterTrainer.DataContracts.PawnManagement
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Pawn
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}
