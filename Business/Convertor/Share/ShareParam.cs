using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Share
{
	public class ShareParam:BaseParam
    {
		public long OwnerId { get; set; }

		public long ContributorId { get; set; }

		public long NoteId { get; set; }

		public long StatusId { get; set; }
	}
}
