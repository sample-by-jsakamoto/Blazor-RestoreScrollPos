using System;
using System.Linq;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using RestoreScrollPos.Models;

namespace RestoreScrollPos
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ApplicationState>();

            var items = Enumerable.Range(0, 100)
                .Select(_ => new Item { Id = Guid.NewGuid() })
                .ToArray();
            services.AddSingleton(items);
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
