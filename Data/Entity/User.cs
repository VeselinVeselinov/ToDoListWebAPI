using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    public class User : Persistent
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        
        [ForeignKey("StatusId")]
        public virtual UserStatus Status { get; set; }
        public long StatusId { get; set; }
    }
}
