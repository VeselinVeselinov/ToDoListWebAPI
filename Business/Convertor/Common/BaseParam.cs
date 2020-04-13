using ToDoListWebAPI.Business.Convertor.Common.CustomAttributes;

namespace ToDoListWebAPI.Business.Convertor.Common
{
    public abstract class BaseParam
    {
		[Track(true)]
        public long Id { get; set; }

        public sbyte Active { get; set; }
    }
}
