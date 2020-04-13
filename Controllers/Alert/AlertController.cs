using ToDoListWebAPI.Business.Convertor.Alert;
using ToDoListWebAPI.Business.Processor.Alert;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.Alert
{
    public class AlertController : BaseController<long, AlertParam, AlertResult, IAlertProcessor>
    {
        public AlertController(IAlertProcessor processor) : base(processor)
        {
        }
    }
}