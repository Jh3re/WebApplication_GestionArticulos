using WebApplication_GestionArticulos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication_GestionArticulos.ViewModels
{
    public class ArticuloCategoriaVM
    {
        public Articulo Articulo { get; set; }
        public IEnumerable<SelectListItem> ListaCategorias { get; set; }
    }
}
