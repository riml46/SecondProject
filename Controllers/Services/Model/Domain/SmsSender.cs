using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class SmsSender
    {
        public string Endpoint { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string BrandName { get; set; }
        public bool IsSendSms { get; set; }
    }
}
