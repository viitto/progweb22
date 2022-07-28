using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Context;

namespace WebApp.Controllers
{
    public class ModeloController : Controller
    {
        // GET: Modelo
        public ActionResult Index()
        {
            return View((context.Modelo.OrderBy(c => c.Nome));
        }
    }
}
