using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class RabbitMQExternalLGSP
    {
        public bool AzureServiceBusEnabled { get; set; }
        public int EventBusRetryCount { get; set; }
        public ConnectionStrings3 ConnectionStrings { get; set; }
    }
}
