using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class Client
    {
        public string serviceUrl { get; set; }
        public bool shouldRegisterWithEureka { get; set; }
        public bool shouldFetchRegistry { get; set; }
        public Healthcheck healthcheck { get; set; }
    }
}
