using BLL.classes;
using BLL.interfaces;
using Dal.functions;
using Dal.interfaces;
using Dal.models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddControllers();
            //הגדרה למנהל התלויות איזה מופע ליצור עבור כל ממשק
            services.AddScoped(typeof(Icities), typeof(CitiesFunc));
            services.AddScoped(typeof(IcitiesBll), typeof(CitiesBll));
            services.AddScoped(typeof(Ipayments), typeof(PaymentsFunc));
            services.AddScoped(typeof(IpaymentsBll), typeof(PaymentsBll));
            services.AddScoped(typeof(Ilinks), typeof(LinksFunc));
            services.AddTransient(typeof(IlinksBll), typeof(LinksBll));
            services.AddScoped(typeof(IfilePatterns), typeof(FilePatternsFunc));
            services.AddTransient(typeof(IfilePatternsBll), typeof(FilePatternsBll));

            //הוספת הגדרה למנהל התלויות על מסד הנתונים
            services.AddDbContext<Layers_OfficeContext>(opt => opt.UseSqlServer("Server=DESKTOP-A8BTK9B\\SQL2019;Database=Layers_Office;Trusted_Connection=true"));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "webApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "webApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
