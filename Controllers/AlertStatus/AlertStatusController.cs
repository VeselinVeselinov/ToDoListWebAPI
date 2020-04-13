using ToDoListWebAPI.Business.Convertor.AlertStatus;
using ToDoListWebAPI.Business.Processor.AlertStatus;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.AlertStatus
{
    public class AlertStatusController : BaseController<long, AlertStatusParam, AlertStatusResult, IAlertStatusProcessor>
    {
        public AlertStatusController(IAlertStatusProcessor processor) : base(processor)
        {
        }
    }
}