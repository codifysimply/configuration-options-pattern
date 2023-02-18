using Config.Demo.WebApi.Config;

namespace Config.Demo.WebApi.Services.Interfaces
{
    public interface ISingletonService
    {
        ApiConfig GetApiConfig();
    }
}
