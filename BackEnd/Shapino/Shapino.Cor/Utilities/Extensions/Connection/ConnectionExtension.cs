using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shapino.DataLayer.Context;

namespace Shapino.Cor.Utilities.Extensions.Connection
{
    public static class ConnectionExtension
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ShopinoDbContext>(optionsAction: options =>
            {
                var ConnectionStrings = "ConnectionStrings:ShopinoConnection:Development";
                options.UseSqlServer(configuration[ConnectionStrings]);
            });
            return service; 
            
        }
    }
}
