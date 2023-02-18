using Config.Demo.WebApi.Config;

namespace Config.Demo.WebApi.Services.Interfaces
{
    public interface ITransientService
    {
        ApiConfig GetApiConfig();
    }
}
