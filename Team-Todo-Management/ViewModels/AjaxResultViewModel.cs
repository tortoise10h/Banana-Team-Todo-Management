using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.ViewModels
{
    public class AjaxResultViewModel
    {
        public AjaxResultViewModel(bool isSuccess, string data)
        {
            IsSuccess = isSuccess;
            Data = new ExpandoObject();
            Data = data;
        }

        public bool IsSuccess { get; set; }
        public dynamic Data { get; set; }
    }
}
