using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public StatusCodeResult Index() => NotFound();

        //public StatusCodeResult Index()=> StatusCode(StatusCodes.Status404NotFound);

        //public VirtualFileResult Index() => File("/lib/bootstrap/dist/css/bootstrap.css", "text/css");


        //public ContentResult Index() => Content("[\"Alice\",\"Bob\",\"Vasya\"]", "application/json");


        //public JsonResult Index() => Json(new[] { "Alice", "Bob", "Joe" });


        //public ViewResult Index() => View(DateTime.Now);

        //public ViewResult Index()
        //{
        //    ViewBag.Message = "Hello";
        //    ViewBag.Date = DateTime.Now;

        //    return View();
        //}

        //public ViewResult Result() => View((object)"Hello World");

        //public RedirectToRouteResult Redirect() => RedirectToRoute(new
        //{
        //    controller = "Example",
        //    action = "Index",
        //    ID = "MyID"
        //});
    }
}
