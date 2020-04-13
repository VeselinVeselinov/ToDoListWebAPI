using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Note
{
	public class NoteParam:BaseParamNamed
    {
		public long AccountId { get; set; }

		public long CategoryId { get; set; }

		public long StatusId { get; set; }

		public int TextSize { get; set; }

		public string Url { get; set; }

		public string Text { get; set; }

		public long TypeId { get; set; }
	}
}
