using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class RabbitMQ
    {
        public bool AzureServiceBusEnabled { get; set; }
        public int EventBusRetryCount { get; set; }
        public ConnectionStrings2 ConnectionStrings { get; set; }
    }
}
