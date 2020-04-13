using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteTask
{
	public class NoteTaskParam:BaseParamNamed
    {
		public bool IsChecked { get; set; }

		public string Text { get; set; }

		public long NoteId { get; set; }
	}
}
