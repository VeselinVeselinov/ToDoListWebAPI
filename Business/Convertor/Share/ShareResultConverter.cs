using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Share
{
	class ShareResultConverter : BaseResultConverter<Data.Entity.Share, ShareResult>, IShareResultConverter
    {
		public override void ConvertSpecific(Data.Entity.Share entity, ShareResult result)
		{
			result.OwnerId = entity.Owner.Id;
			result.OwnerName = entity.Owner.Name;
			result.ContributorId = entity.Contributor.Id;
			result.ContributorName = entity.Contributor.Name;
			result.NoteId = entity.Note.Id;
			result.NoteName = entity.Note.Name;
			result.StatusId = entity.Note.Id;
			result.StatusName = entity.Note.Name;
		}

		public override ShareResult GetNewResult()
		{
			return new ShareResult();
		}
	}
}
