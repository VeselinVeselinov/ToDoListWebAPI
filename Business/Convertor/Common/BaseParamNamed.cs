using ToDoListWebAPI.Business.Convertor.Common.CustomAttributes;

namespace ToDoListWebAPI.Business.Convertor.Common
{
    public class BaseParamNamed:BaseParam
    {
		[Track(true)]
        public string Code { get; set; }

		public string Name { get; set; }

        public string Description { get; set; }
    }
}
