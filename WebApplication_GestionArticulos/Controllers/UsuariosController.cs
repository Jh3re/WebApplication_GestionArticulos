using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_GestionArticulos.Data;
using WebApplication_GestionArticulos.Models;

namespace WebApplication_GestionArticulos.Controllers
{
    public class UsuariosController : Controller
    {
        public readonly ApplicationDbContext _contexto;

        public UsuariosController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        [HttpGet]
        // GET: CategoriasController
        public IActionResult Index()
        {
            List<Usuario> listaUsuarios = _contexto.Usuario.ToList();
          
            return View(listaUsuarios);
        }
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Add(usuario);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return View();
            }
            var usuario = _contexto.Usuario.FirstOrDefault(c => c.Id == id);
            return View(usuario);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Update(usuario);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
        [HttpGet]
        public IActionResult Detalle(int? id)
        {
            if(id == null)
            {
                return View();
            }
            var usuario = _contexto.Usuario.Include(d => d.DetalleUsuario).FirstOrDefault(u => u.Id == id);
            if(usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
        [HttpPost]
        public IActionResult AgregarDetalle(Usuario usuario)
        {
            if(usuario.DetalleUsuario.DetalleUsuario_Id == 0)
            {
                _contexto.DetalleUsuario.Add(usuario.DetalleUsuario);
                _contexto.SaveChanges();
                var usuarioBd = _contexto.Usuario.FirstOrDefault(u => u.Id == usuario.Id);
                usuarioBd.DetalleUsuario_Id = usuario.DetalleUsuario.DetalleUsuario_Id;
                _contexto.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            var usuario = _contexto.Usuario.FirstOrDefault(c => c.Id == id);
            _contexto.Usuario.Remove(usuario);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
