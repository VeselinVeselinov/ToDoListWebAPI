using ToDoListWebAPI.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListWebAPI.Data.Entity
{
    public class Note : PersistentNamed
    {
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
        public long AccountId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public long CategoryId { get; set; }

        [ForeignKey("StatusId")]
        public virtual NoteStatus Status { get; set; }
        public long StatusId { get; set; }
        
        public int TextSize { get; set; }

		public string Url { get; set; }

		public string Text { get; set; }

        [ForeignKey("TypeId")]
        public virtual NoteType Type { get; set; }
        public long TypeId { get; set; }
	}
}
