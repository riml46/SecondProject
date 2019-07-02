using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class Scope
    {
        public string Name { get; set; }
        public string OrgCode { get; set; }
        public bool IsCore { get; set; }
    }
}
