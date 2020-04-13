using ToDoListWebAPI.Business.Convertor.ShareStatus;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.ShareStatus
{
	public interface IShareStatusProcessor: IBaseProcessor<long, ShareStatusParam, ShareStatusResult>
    {
	}
}
