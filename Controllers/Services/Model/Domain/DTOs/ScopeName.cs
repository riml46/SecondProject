using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain.DTOs
{
    public class ScopeName
    {
        public bool required { get; set; }
        public string value { get; set; }
        public ScopeName()
        {
            required = false;
            value = "";
        }
    }
}
