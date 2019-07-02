using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain.DTOs
{
    public class ApplicationResult
    {
        public ScopeName ScopeName { get; set; }
        public IsCore IsCore { get; set; }

        public ApplicationResult()
        {
            ScopeName = new ScopeName();
            IsCore = new IsCore();
        }
    }
}
