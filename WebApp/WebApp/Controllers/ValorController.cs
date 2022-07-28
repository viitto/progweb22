using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Context;

namespace WebApp.Controllers
{
    public class ValorController : Controller
    {
        // GET: Valor
        public ActionResult Index()
        {
            return View((context.Valor.OrderBy(c => c.Nome));
        }
    }
}