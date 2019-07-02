using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class EmailSender
    {
        public string Server { get; set; }
        public string EmailFrom { get; set; }
        public string EmailPassword { get; set; }
        public int Port { get; set; }
        public List<Account> Account { get; set; }
    }
}
