using Microsoft.AspNetCore.Mvc;
using PROYECTOF.Models;
using PROYECTOF.Services;

namespace PROYECTOF.Controllers
{
    public class AdministradorController : Controller
    {

        private readonly AdministradorServices administradorServices;

        public AdministradorController(AdministradorServices administradorServices)
        {
            this.administradorServices = administradorServices;
        }
        // METODO PARA VISUALIZAR
        [HttpGet]
        public async Task<IActionResult> Index()
        {
           var admin = await administradorServices.GetAllAdministrador();
            return View(admin);
        }
        //METODO PARA CREAR
        [HttpPost]
        public async Task<IActionResult> Crear(int identificacion, string nombre, string tipo)
        {
            var administrador = Administrador.Build(Guid.NewGuid(), identificacion, nombre, tipo);

            await this.administradorServices.Crear(administrador);

            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        //METODO PARA ACTUALIZAR

        [HttpGet]
        public IActionResult Update(int identificacion, string nombre, string tipo)
        {
            var admin = Administrador.Build(Guid.NewGuid(), identificacion,nombre,tipo); 

            return View(admin);
        }
        
        [HttpPost]
        public IActionResult Udpate(int identificacion, string nombre, string tipo)
        {
            var admin = Administrador.Build(Guid.NewGuid(), identificacion, nombre, tipo);
            this.administradorServices.Update(admin);
            return RedirectToAction(nameof(Index)); 
        }

        //METODO PARA ELIMINAR
        [HttpGet]
        public IActionResult Delete(int identificacion, string nombre, string tipo)
        {
            var admin = Administrador.Build(Guid.NewGuid(),identificacion,nombre,tipo);

            return View();
        }

        [HttpPost]
        public IActionResult Eliminar(int identificacion, string nombre, string tipo)
        {
            var admin = Administrador.Build(Guid.NewGuid(), identificacion, nombre, tipo);
            this.administradorServices.Delete(admin);
            return RedirectToAction(nameof(Index)); 
        }

    }
}
