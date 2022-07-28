using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Context;


namespace WebApp.Controllers
{
    public class AnoController : Controller
    {
        // GET: Ano
        public ActionResult Index()
        {
            return View((context.Ano.OrderBy(c => c.Nome));
        }
    }
}