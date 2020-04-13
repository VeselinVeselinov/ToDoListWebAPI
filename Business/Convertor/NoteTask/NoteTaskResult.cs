using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteTask
{
	public class NoteTaskResult:BaseResultNamed
    {
		public bool IsChecked { get; set; }

		public string Text { get; set; }

		public long NoteId { get; set; }

		public string NoteName { get; set; }
	}
}
