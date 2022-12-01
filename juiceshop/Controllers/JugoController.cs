using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaJugos.Core.Entidades;

namespace juiceshop.Controllers
{
    public class JugoController : Controller
    {
        public ActionResult Index()
        {
            List<Jugo> jugos = Jugo.GetAll();
            return View(jugos);
        }
    }
}