using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NoteStatus
{
    interface INoteStatusParamConverter:IBaseParamConverter<NoteStatusParam, Data.Entity.NoteStatus>
    {
    }
}
