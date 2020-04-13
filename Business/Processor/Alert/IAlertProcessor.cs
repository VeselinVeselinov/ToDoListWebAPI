using ToDoListWebAPI.Business.Convertor.Alert;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.Alert
{
	public interface IAlertProcessor:IBaseProcessor<long,AlertParam,AlertResult>
    {
    }
}
