using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class Instance
    {
        public bool preferIpAddress { get; set; }
        public int leaseRenewalIntervalInSeconds { get; set; }
        public int leaseExpirationDurationInSeconds { get; set; }
    }
}
