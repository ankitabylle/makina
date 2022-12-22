using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makina.core.Models
{
    public class RequestRegister : BaseRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
