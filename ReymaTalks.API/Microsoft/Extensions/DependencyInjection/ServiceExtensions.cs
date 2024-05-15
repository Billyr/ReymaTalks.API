using ReymaTalks.Common;

namespace ReymaTalks.API.Microsoft.Extensions.DependencyInjection
{
    public static class ServiceExtensions
    {
        public static void ConfigureSystemDateTime(this IServiceCollection services) =>
            services.AddSingleton<IDateTime, MachineDateTime>();
    }
}
