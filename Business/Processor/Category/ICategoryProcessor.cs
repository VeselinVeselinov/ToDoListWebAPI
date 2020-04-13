using ToDoListWebAPI.Business.Convertor.Category;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.Category
{
	public interface ICategoryProcessor:IBaseProcessor<long, CategoryParam, CategoryResult>
    {
	}
}
