using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Context;

namespace WebApp.Controllers
{
    public class FabricantesController : Controller
    {
        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c => c.Nome));
        }
    }
}