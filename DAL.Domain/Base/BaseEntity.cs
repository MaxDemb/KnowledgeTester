using System.ComponentModel.DataAnnotations;

namespace DAL.Domain.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
