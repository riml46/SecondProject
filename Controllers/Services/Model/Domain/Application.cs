using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Controllers.Services.Model.Domain
{
    public class Application
    {
        [Required]
        public Scope Scope { get; set; }
        [Required]

        public bool UseCache { get; set; }
        [Required]

        public bool UseAuthentication { get; set; }
        [Required]

        public bool UseAuthorization { get; set; }
        [Required]

        public bool FileEncrypt { get; set; }
        [Required]

        public bool UseElasticSearch { get; set; }
        [Required]

        public bool UseRabbitMQ { get; set; }
        [Required]

        public bool UseSwagger { get; set; }
        [Required]

        public bool UseEmailSender { get; set; }
        [Required]

        public bool UseUTCTimeZone { get; set; }
        [Required]

        public bool UseEureka { get; set; }
        [Required]

        public bool UseExternalLGSP { get; set; }
        [Required]

        public bool EnableCheckConfiguration { get; set; }
        [Required]

        public bool ShowPII { get; set; }
        [Required]

        public ConnectionStrings ConnectionStrings { get; set; }
        [Required]

        public Logging Logging { get; set; }
        

        public object EndpointReloadConfigration { get; set; }
        [Required]

        public Search Search { get; set; }
        [Required]

        public Eureka eureka { get; set; }
        [Required]

        public string FileEncryptPassword { get; set; }
        [Required]

        public Cache Cache { get; set; }
        [Required]

        public RabbitMQ RabbitMQ { get; set; }
        [Required]

        public RabbitMQExternalLGSP RabbitMQExternalLGSP { get; set; }
        [Required]

        public string KeyCheckConfiguration { get; set; }
        [Required]

        public Swagger Swagger { get; set; }
        [Required]

        public Services Services { get; set; }
        [Required]

        public Clients Clients { get; set; }
        [Required]

        public string ClientId { get; set; }
        [Required]

        public string ClientSecret { get; set; }
        [Required]

        public SmsSender SmsSender { get; set; }
        [Required]

        public EmailSender EmailSender { get; set; }


        public bool checkFileAppliation(Scope scope,bool useCache,bool useAuthentication, bool useAuthorization, bool fileEncrypt, bool useElasticSearch,bool UseRabbitMQ
            ,bool UseSwagger, bool UseEmailSender, bool UseUTCTimeZone, bool EnableCheckConfiguration, bool ShowPII)
        {
            if(scope.Name==null||useCache==false|| useAuthentication==false|| useAuthorization==false||fileEncrypt==false|| useElasticSearch==false|| UseRabbitMQ==false|| UseSwagger==false|| UseEmailSender==false
                || UseUTCTimeZone==false|| EnableCheckConfiguration==false|| ShowPII==false|| ConnectionStrings.Password==null|| ConnectionStrings.Server==null|| eureka.client.serviceUrl==null)
            {
                return false;
            }

            return true;
        }
    }
}
