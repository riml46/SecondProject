using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SecondProject.Controllers.Services.Model;
using SecondProject.Controllers.Services.Model.Domain;
using SecondProject.Controllers.Services.Model.Domain.DTOs;
using SecondProject.Controllers.Services.Model.File;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace SecondProject.Controllers.Services
{
    public class HttpService : IHttpServices
    {

        private readonly IHttpClientFactory _clientFactory;
        public HttpService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<EnvironmentName>> GetEnvironmentName()
        {
            string hash = await getHash();

            var requestRepository = new HttpRequestMessage(HttpMethod.Get,
           "https://api.bitbucket.org/2.0/repositories/microservicesharinghub/quan3_dev/src/"+hash+ "/Config");

            requestRepository.Headers.Add("Accept", "application/json");


            var clientRepository = _clientFactory.CreateClient("bitbucket");

            var reponses = await clientRepository.SendAsync(requestRepository);
            List<EnvironmentName> environmentNames = new List<EnvironmentName>();
            List<Value> values = new List<Value>();
            if (reponses.IsSuccessStatusCode)
            {
                FileObject file = await reponses.Content.ReadAsAsync<FileObject>();
                values = file.values;
            }
            foreach (Value v  in values)
            {
                if (v.type.Equals("commit_directory")){
                    int longName = v.path.Length - 7;
                    string name = v.path.ToString().Substring(7, longName);
                    EnvironmentName environmentName = new EnvironmentName();
                    environmentName.name = name;
                    environmentNames.Add(environmentName);
                }
            }
            return environmentNames;
        }

        public async Task<ApplicationResult> checkFileApplication()
        {
            string hash = await getHash();

            //Thieu check xem file application.yml co ton tai hay khong

            var requestRepository = new HttpRequestMessage(HttpMethod.Get,
           "https://api.bitbucket.org/2.0/repositories/microservicesharinghub/quan3_dev/src/" + hash + "/Config/application.yml");

            requestRepository.Headers.Add("Accept", "application/json");

            
            var clientRepository = _clientFactory.CreateClient("bitbucket");

            var reponses = await clientRepository.SendAsync(requestRepository);
            string yamlFile = "";
            if (reponses.IsSuccessStatusCode)
            {
                yamlFile = await reponses.Content.ReadAsStringAsync();
            }

            //Convert YAML to Json Format
            var r = new StringReader(yamlFile);
            var deserializer = new Deserializer();
            var yamlObject = deserializer.Deserialize(r);
            string json=JsonConvert.SerializeObject(yamlObject);


            Application application = JsonConvert.DeserializeObject<Application>(json);

            bool checkResult = application.checkFileAppliation(application.Scope, application.UseCache, application.UseAuthentication, application.UseAuthentication, application.FileEncrypt,
                application.UseElasticSearch, application.UseRabbitMQ, application.UseSwagger, application.UseEmailSender, application.UseUTCTimeZone, application.EnableCheckConfiguration
                , application.ShowPII);
            ApplicationResult applicationResult = new ApplicationResult();
            if (checkResult==true)
            {
                applicationResult.ScopeName.required = true;
                applicationResult.ScopeName.value = application.Scope.Name;
                applicationResult.IsCore.required = true;
                applicationResult.IsCore.value = "";
            }

            

            return applicationResult;
        }

        public async Task<string> getHash()
        {
            var requestHash = new HttpRequestMessage(HttpMethod.Get,
           "https://api.bitbucket.org/2.0/repositories/microservicesharinghub/quan3_dev/refs/branches/master");
            requestHash.Headers.Add("Accept", "application/json");

            var clientHash = _clientFactory.CreateClient("bitbucket");

            var response = await clientHash.SendAsync(requestHash);

            string hash = "";
            if (response.IsSuccessStatusCode)
            {
                RootObject root = await response.Content.ReadAsAsync<RootObject>();
                hash = root.target.hash;
            }
            return hash;
        }
    }
}
