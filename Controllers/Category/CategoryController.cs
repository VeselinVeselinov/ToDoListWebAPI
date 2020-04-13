using ToDoListWebAPI.Business.Convertor.Category;
using ToDoListWebAPI.Business.Processor.Category;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.Category
{
    public class CategoryController : BaseController<long, CategoryParam, CategoryResult, ICategoryProcessor>
    {
        public CategoryController(ICategoryProcessor processor) : base(processor)
        {
        }
    }
}