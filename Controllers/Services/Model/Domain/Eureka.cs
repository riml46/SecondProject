using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class Eureka
    {
        public Client client { get; set; }
        public Instance instance { get; set; }
    }
}
