using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GustavLindblom.Domain.Interfaces;
using GustavLindblom.Infrastructure.DependencyInjection.Extensions;
using GustavLindblom.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GustavLindblom.Presentation.WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddRazorPagesOptions(options =>
                {
                    options.Conventions.AddPageRoute("/Post", "post/{postId}");
                });
            services.AddDbContext<ApplicationDbContext>();
            services.AddTransient(typeof(IApplicationDbContext), p => p.GetService<ApplicationDbContext>());
            services.InvokeAllServiceConfigurators();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
