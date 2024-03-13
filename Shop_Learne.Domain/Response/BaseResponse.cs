using Shop_Learne.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Learne.Domain.Response
{
    public class BaseResponse<T>
    {
        public string Descroption { get; set; }
        public StatusCode StatusCode{ get; set; }
        public T Data{ get; set; }
    }
}
