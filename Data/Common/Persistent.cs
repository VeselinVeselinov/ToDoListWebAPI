using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Common
{
    public abstract class Persistent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DefaultValue(1)]
        public sbyte Active { get; set; }
    }
}
