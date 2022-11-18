using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Jobs.Areas.Identity.IdentityHostingStartup))]
namespace Jobs.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}