using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_GestionArticulos.Models
{
    public class Etiqueta
    {
        [Key]
        public int Etiqueta_Id { get; set; }
        public string Titulo { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public ICollection<ArticuloEtiqueta> ArticuloEtiqueta { get; set; }
    }
}
