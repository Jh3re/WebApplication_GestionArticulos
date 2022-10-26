using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_GestionArticulos.Data;
using WebApplication_GestionArticulos.Models;

namespace WebApplication_GestionArticulos.Controllers
{
    public class CategoriasController : Controller
    {
        public readonly ApplicationDbContext _contexto;

        public CategoriasController (ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        [HttpGet]
        // GET: CategoriasController
        public IActionResult Index()
        {
            List<Categoria> listaCategorias = _contexto.Categoria.ToList();
            return View(listaCategorias);
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _contexto.Categoria.Add(categoria);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if(id == null)
            {
                return View();
            }
            var categoria = _contexto.Categoria.FirstOrDefault(c => c.Categoria_Id==id);
            return View(categoria);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _contexto.Categoria.Update(categoria);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            var categoria = _contexto.Categoria.FirstOrDefault(c => c.Categoria_Id == id);
            _contexto.Categoria.Remove(categoria);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
