using ToDoListWebAPI.Business.Convertor.AlertStatus;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.AlertStatus
{
	public interface IAlertStatusProcessor:IBaseProcessor<long,AlertStatusParam,AlertStatusResult>
    {
	}
}
