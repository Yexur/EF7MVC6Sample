using System.ComponentModel.DataAnnotations;

namespace GettingStarted.Core
{
    public class EntityBase : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
