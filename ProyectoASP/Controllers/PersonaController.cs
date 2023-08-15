using Microsoft.AspNetCore.Mvc;
using ProyectoASP.Models;
using proyectoASPNET.Datos;

namespace ProyectoASP.Controllers
{
    public class PersonaController : Controller
    {
        PersonaAdmin admin = new PersonaAdmin();
        public IActionResult Index()
        {
            ViewBag.mensaje = "";
            return View(admin.Consultar());
        }

        public IActionResult Guardar() 
        {
            return View();
        }
        //El httpsPost hace que  el programa sepa que cuando 
        //Se envian datos por 'Post' se refiere a este ActionResult
        //Y no al de arriba
        [HttpPost]
        public IActionResult Guardar(Persona modelo)
        {
            ViewBag.mensaje = "Persona Guardada";
            admin.Guardar(modelo);
            return View(modelo);
        }
    }
}
