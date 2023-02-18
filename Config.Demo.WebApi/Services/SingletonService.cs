using Config.Demo.WebApi.Config;
using Config.Demo.WebApi.Services.Interfaces;
using Microsoft.Extensions.Options;

namespace Config.Demo.WebApi.Services
{
    public class SingletonService:ISingletonService
    {
        private readonly IOptionsMonitor<ApiConfig> optionsMonitor;
        public SingletonService(IOptionsMonitor<ApiConfig> optionsMonitor)
        {
            this.optionsMonitor = optionsMonitor;
        }
        public ApiConfig GetApiConfig() => optionsMonitor.CurrentValue;
    }
}
