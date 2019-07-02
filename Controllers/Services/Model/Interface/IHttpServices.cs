using SecondProject.Controllers.Services.Model.Domain.DTOs;
using SecondProject.Controllers.Services.Model.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model
{
    public interface IHttpServices
    {
        Task<List<EnvironmentName>> GetEnvironmentName();
        Task<ApplicationResult> checkFileApplication();

        
    }
}
