using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    //[HttpsOnly]
    //[Profile]
    //[ViewResultDetails]
    //[RangeException]
    //[TypeFilter(typeof(DiagnosticsFilter))]
    //[TypeFilter(typeof(TimeFilter))]
    //[ServiceFilter(typeof(TimeFilter))]

    [Message("This is the Controller-Scoped Filter")]
    public class HomeController : Controller
    {
        [Message("This is the First Action-Scoped Filter")]
        [Message("This is the Second Action-Scoped Filter")]
        public ViewResult Index() =>
            View("Message", "This is the Index action on the Home controller");

        //public ViewResult Index() =>
        //    View("Message", "This is the Index action on the Home controller");
        //public ViewResult SecondAction() =>
        //    View("Message", "This is the SecondAction action on the Home controller");
        //public ViewResult GenerateException(int? id)
        //{
        //    if (id == null)
        //        throw new ArgumentNullException(nameof(id));
        //    else if (id > 10)
        //        throw new ArgumentOutOfRangeException(nameof(id));
        //    else
        //        return View("Message", $"The value is {id}");
        //}
    }
}
