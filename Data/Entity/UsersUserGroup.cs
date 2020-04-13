using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    [Table("UsersUserGroups")]
    public class UsersUserGroup : Persistent
    {
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public long UserId { get; set; }

        [ForeignKey("GroupId")]
        public virtual UserGroup Group { get; set; }
        public long GroupId { get; set; }
    }
}
