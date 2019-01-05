namespace MasterTrainer.DataContracts.UserManagement
{
    using System.Runtime.Serialization;

    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
