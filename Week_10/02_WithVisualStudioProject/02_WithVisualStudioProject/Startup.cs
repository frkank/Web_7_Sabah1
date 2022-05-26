using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Uygulamada kullanýlacak olan service'lerin eklendiði, bildirildiði,
            //ayarlandýðý yerdir. Service modül, kütüphane gibi düþünülebilir.
            //Ayrýca ele alacaðýz.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Bu metot uygulamada kullanýlacak olan ara katman(ara yazýlým)larýn
            //bildirildiði ve ayarlarýnýn yapýldýðý yerdir. Sýkça MiddleWare olarak
            //anýlýr, anýlacaktýr.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Bu middleware routing özelliklerini kullanacaðýmýzý belirtir.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints uygulamaya gelen isteklerin varýþ noktasýný
                //ifade eden þablon yapýsýdýr.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
