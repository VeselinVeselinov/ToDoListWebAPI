using System;
using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Alert
{
	public class AlertResult:BaseResultNamed
    {
		public long NoteId { get; set; }

		public string NoteName { get; set; }

		public DateTime TimeReminder { get; set; }

		public long StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
