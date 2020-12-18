using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ClientManager.Model.Error
{
    public class ErrorModel
    {
        public int? Status { get; set; } = 400;
        public string Messege { get; set; }
    }

    public class ResponeModel
    {
        public HttpResponseMessage Respone { get; set; }
        public bool Success { get; set; }
    }
}
