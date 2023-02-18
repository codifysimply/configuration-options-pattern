namespace Config.Demo.WebApi.Config
{
    public class ApiConfig
    {
        public string BaseAddress { get; set; } = string.Empty;

        public string UserAgent { get; set; } = string.Empty;

        public int TimeoutInSeconds { get; set; }
    }
}
