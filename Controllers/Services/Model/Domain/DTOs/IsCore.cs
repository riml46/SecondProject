using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain.DTOs
{
    public class IsCore
    {
        public bool required { get; set; }
        public string value { get; set; }
        public IsCore()
        {
            required = false;
            value = "";
        }
    }
}
