using System;
using identityScaffoldMvc.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(identityScaffoldMvc.Areas.Identity.IdentityHostingStartup))]
namespace identityScaffoldMvc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<identityScaffoldMvcIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("identityScaffoldMvcIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<identityScaffoldMvcIdentityDbContext>();
            });
        }
    }
}