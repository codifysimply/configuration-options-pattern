using Config.Demo.WebApi.Config;
using Config.Demo.WebApi.Services.Interfaces;
using Microsoft.Extensions.Options;

namespace Config.Demo.WebApi.Services
{
    public class TransientService : ITransientService
    {
        private readonly IOptions<ApiConfig> options;
        public TransientService(IOptions<ApiConfig> options)
        {
            this.options = options;
        }
        public ApiConfig GetApiConfig() => options.Value;
    }
}
