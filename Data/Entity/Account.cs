using System.ComponentModel.DataAnnotations.Schema;
using ToDoListWebAPI.Data.Common;

namespace ToDoListWebAPI.Data.Entity
{
    public class Account:PersistentNamed
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public long UserId { get; set; }
        
        [ForeignKey("StatusId")]
        public virtual AccountStatus Status { get; set; }
        public long StatusId { get; set; }
    }
}
