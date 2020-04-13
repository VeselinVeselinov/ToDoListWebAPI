using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    public class Share : Persistent
    {
        [ForeignKey("OwnerId")]
        public virtual Account Owner { get; set; }
        public long OwnerId { get; set; }

        [ForeignKey("ContributorId")]
        public virtual Account Contributor { get; set; }
        public long ContributorId { get; set; }

        [ForeignKey("NoteId")]
        public virtual Note Note { get; set; }
        public long NoteId { get; set; }

        [ForeignKey("StatusId")]
        public virtual ShareStatus Status { get; set; }
        public long StatusId { get; set; }
    }
}
