﻿namespace ToDoListWebAPI.Business.Convertor.Common
{
    public class BaseResultNamed:BaseResult
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
