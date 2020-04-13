using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Note
{
	public class NoteResult:BaseResultNamed
    {
		public long AccountId { get; set; }

		public string AccountName { get; set; }

		public long CategoryId { get; set; }

		public string CategoryName { get; set; }

		public long StatusId { get; set; }

		public string StatusName { get; set; }

		public int TextSize { get; set; }

		public string Url { get; set; }

		public string Text { get; set; }

		public long TypeId { get; set; }

		public string TypeName { get; set; }
	}
}
