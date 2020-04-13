using System;
using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Alert
{
	public class AlertParam:BaseParamNamed
    {
		public long NoteId { get; set; }

		public DateTime TimeReminder { get; set; }

		public long StatusId { get; set; }
	}
}
