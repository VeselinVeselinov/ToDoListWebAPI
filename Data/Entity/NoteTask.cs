using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    public class NoteTask : PersistentNamed
    {
        public bool IsChecked { get; set; }

        public string Text { get; set; }

        [ForeignKey("NoteId")]
        public virtual Note Note { get; set; }
        public long NoteId { get; set; }
    }
}
