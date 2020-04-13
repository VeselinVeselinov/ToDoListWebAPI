using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    public class Notification : PersistentNamed
    {
        [ForeignKey("AlertId")]
        public virtual Alert Alert { get; set; }
        public long AlertId { get; set; }

        public string NotificationMessage { get; set; }

        [ForeignKey("StatusId")]
        public virtual NotificationStatus Status { get; set; }
        public long StatusId { get; set; }
    }
}
