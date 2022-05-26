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
            //Uygulamada kullan�lacak olan service'lerin eklendi�i, bildirildi�i,
            //ayarland��� yerdir. Service mod�l, k�t�phane gibi d���n�lebilir.
            //Ayr�ca ele alaca��z.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Bu metot uygulamada kullan�lacak olan ara katman(ara yaz�l�m)lar�n
            //bildirildi�i ve ayarlar�n�n yap�ld��� yerdir. S�k�a MiddleWare olarak
            //an�l�r, an�lacakt�r.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Bu middleware routing �zelliklerini kullanaca��m�z� belirtir.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints uygulamaya gelen isteklerin var�� noktas�n�
                //ifade eden �ablon yap�s�d�r.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
