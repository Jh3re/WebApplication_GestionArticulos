using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication_GestionArticulos.Models
{
    public class DetalleUsuario
    {
        public int DetalleUsuario_Id { get; set; }
        [Required]
        public string Cedula { get; set; }
        public string Deporte { get; set; }
        public string Mascota { get; set; }
        public Usuario Usuario { get; set; }

    }
}
