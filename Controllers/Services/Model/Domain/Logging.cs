using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class Logging
    {
        public bool IncludeScopes { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}
