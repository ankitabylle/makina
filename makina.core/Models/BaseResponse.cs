using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makina.core.Models
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public List<string> MessageList { get; set; }
        public BaseResponse()
        {
            MessageList = new List<string>();
        }
    }
}
