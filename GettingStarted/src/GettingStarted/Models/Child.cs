using GettingStarted.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GettingStarted.Models
{
    public class Child : EntityBase
    {
        [DataMember]
        [Required]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [ForeignKey("Parent_Id")]
        public virtual Parent Parent { get;  set;}
    }
}
