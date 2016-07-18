using GettingStarted.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GettingStarted.Models
{
    public class Parent : EntityBase
    {
        private ICollection<Child> _children;

        [DataMember]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Child> Children
        {
            get { return _children ?? (new Collection<Child>());  }
            set { _children = value; }
        }
    }
}
