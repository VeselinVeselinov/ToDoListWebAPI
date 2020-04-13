using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    [Table("UserGroups")]
    public class UserGroup : PersistentNamed
    {
        [ForeignKey("StatusId")]
        public virtual UserGroupStatus Status { get; set; }
        public long StatusId { get; set; }
    }
}
