using ApiBackend.Handlers;
using ApiBackend.Requests;
using ApiBackend.Responses;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApiBackend
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
            services.AddControllers();
            services.AddSwaggerDocument(config =>
            {
                config.Version = "v1";
                config.Description = ".NET Core 3.0 Sample API for Console App Demo";
                config.Title = ".NET Core 3.0 Sample API";
            });

            var responsesAssembly = System.Reflection.Assembly.GetAssembly(typeof(BaseResponse));
            var requestsAssembly = System.Reflection.Assembly.GetAssembly(typeof(BaseRequest));
            var handlersAssembly = System.Reflection.Assembly.GetAssembly(typeof(HandlerBase));
            services.AddMediatR(responsesAssembly, requestsAssembly, handlersAssembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUi3(options =>
            {
                options.DocumentPath = "/" + "swagger" + "/" + "v1" + "/" + "swagger.json";
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
