using System;
using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    public class Alert:PersistentNamed
    {
        [ForeignKey("NoteId")]
        public virtual Note Note { get; set; }
        public long NoteId { get; set; }
        
        public DateTime TimeReminder { get; set; }

        [ForeignKey("StatusId")]
        public virtual AlertStatus Status { get; set; }
        public long StatusId { get; set; }
    }
}
