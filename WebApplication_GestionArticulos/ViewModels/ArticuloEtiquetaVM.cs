using WebApplication_GestionArticulos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication_GestionArticulos.ViewModels
{
    public class ArticuloEtiquetaVM
    {
        public ArticuloEtiqueta ArticuloEtiqueta { get; set; }
        public Articulo Articulo { get; set; }
        public IEnumerable<ArticuloEtiqueta> listaArticuloEtiquetas { get; set; }
        public IEnumerable<SelectListItem> listaEtiquetas { get; set; }
    }
}
