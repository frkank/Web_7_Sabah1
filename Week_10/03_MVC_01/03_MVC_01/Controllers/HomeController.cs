using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01.Controllers
{
    //Tüm controllerlar Controller sınıfından miras alırlar.
    //Öyleyse bir requesti karşılayacak bir özellik kazanmasını istiyorsak,
    //ilgili classı Controller sınıfından türetmeliyiz.
    public class HomeController : Controller
    {
        //Action Method: Eğer bir metot bir Controller içinde ise ona 
        //Action Method diyeceğiz, hatta çoğu kez Action deriz.

        //Bu action uygulamanın ana dizinine istek gönderildiğinde
        //tetiklenecektir.
        public IActionResult Index()
        {
            //Eğer View metodu bu şekilde kullanılırsa
            //(yani parantez içi boş bırakılırsa,parametresiz kullanılırsa)
            //içinde bulunduğu Action'ın adındaki View'ı arar. Ve onu döndürür.
            return View();
        }

        public void X()
        {

        }


    }
}
