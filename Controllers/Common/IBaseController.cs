using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Controllers.Common
{
    public interface IBaseController<PK, TParam>
        where TParam : BaseParam
    {
		IActionResult FindByPK(PK id);
		IActionResult FindByField(string fieldName, string value);
		IActionResult ListAll();

		IActionResult Create(TParam param);
		IActionResult CreateList(List<TParam> param);

		IActionResult Update(PK id, TParam param);
		IActionResult Update(List<TParam> param);

		IActionResult EraseByID(PK id);
		IActionResult Erase(List<PK> idList);

		IActionResult DeleteById(PK id);
		IActionResult Delete(List<PK> idList);
	}
}
