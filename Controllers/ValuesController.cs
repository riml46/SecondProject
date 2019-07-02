using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SecondProject.Controllers.Services.Model;
using SecondProject.Controllers.Services.Model.Domain;
using SecondProject.Controllers.Services.Model.Domain.DTOs;
using SecondProject.Controllers.Services.Model.File;


namespace SecondProject.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController 
    {
        private readonly IHttpServices _IHttpServices;
        private readonly IMapper _mapper;
        public ValuesController(IHttpServices httpServices, IMapper mapper)
        {
            _IHttpServices = httpServices;
            _mapper = mapper;
        }

        [HttpGet("getEnvironmentName")]
        public async Task<IEnumerable<EnvironmentName>> GetEnvironmentName()
        {
            List<EnvironmentName> name = new List<EnvironmentName>();
            name = await _IHttpServices.GetEnvironmentName();
            return name;
        }

        [HttpGet("checkApplication")]
        public async Task<ApplicationResult> checkFileApplication()
        {
            ApplicationResult application = await _IHttpServices.checkFileApplication();
            return application;
        }


    }
}
