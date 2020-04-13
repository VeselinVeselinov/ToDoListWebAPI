using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Share
{
	public class ShareResult:BaseResult
    {
		public long OwnerId { get; set; }

		public string OwnerName { get; set; }

		public long ContributorId { get; set; }

		public string ContributorName { get; set; }

		public long NoteId { get; set; }

		public string NoteName { get; set; }

		public long StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
