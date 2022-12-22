using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makina.core.Models
{
    public class ResponseLogin : BaseResponse
    {
        public string Token { get; set; }
        public int ExpireDate { get; set; }
    }
}
