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
        public ActionResult Registro(int id)
        {
            Jugo jugo = Jugo.GetById(id);
            return View(jugo);
        }
        public ActionResult Guardar(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            Jugo.Guardar(id, nombre, descripcion, precio, cantidad);
            return RedirectToAction("Index");
        }
    }
}