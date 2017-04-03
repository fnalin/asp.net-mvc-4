using System.Runtime.Serialization;

namespace DemoAzureWCF.Models
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}