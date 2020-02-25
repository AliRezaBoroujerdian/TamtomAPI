using System;
using System.Collections.Generic;
using System.Text;

namespace Tamtom.API
{
    public class APIResultModel
    {
        public object Entries { get; set; }
        public object Result { get; set; }
        public StatusInfo Status { get; set; }
    }

    public class StatusInfo
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public StatusInfo(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }

}

