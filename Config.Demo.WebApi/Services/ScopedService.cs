using Config.Demo.WebApi.Config;
using Config.Demo.WebApi.Services.Interfaces;
using Microsoft.Extensions.Options;

namespace Config.Demo.WebApi.Services
{
    public class ScopedService : IScopedService
    {
        private readonly IOptionsSnapshot<ApiConfig> optionsSnapshot;
        public ScopedService(IOptionsSnapshot<ApiConfig> optionsSnapshot)
        {
            this.optionsSnapshot = optionsSnapshot;
        }
        public ApiConfig GetApiConfig() => optionsSnapshot.Value;
    }
}
