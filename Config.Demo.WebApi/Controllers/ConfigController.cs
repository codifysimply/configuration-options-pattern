using Config.Demo.WebApi.Config;
using Config.Demo.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Config.Demo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly ITransientService transientService;
        private readonly IScopedService scopedService;
        private readonly ISingletonService singletonService;
        public ConfigController(ITransientService transientService,
            IScopedService scopedService,
            ISingletonService singletonService)
        {
            this.transientService = transientService;
            this.scopedService = scopedService;
            this.singletonService = singletonService;
        }

        [HttpGet]
        [Route("apiconfig")]
        public Dictionary<string, ApiConfig> GetConfig()
        {
            return new Dictionary<string, ApiConfig>
            {
                ["IOptions"] = transientService.GetApiConfig(),
                ["IOptionsSnapshot"] = scopedService.GetApiConfig(),
                ["IOptionsMonitor"] = singletonService.GetApiConfig()
            };
        }
    }
}
