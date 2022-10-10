using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_GestionArticulos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage ="Introduzca un email valido!")]
        public string Email { get; set; }
        [Display(Name ="Direccion de usuario")]
        public string Direccion { get; set; }
        [NotMapped]
        public int Edad { get; set; }
        [ForeignKey("DetalleUsuario")]
        public int DetalleUsuario_Id { get; set; }
        public DetalleUsuario DetalleUsuario { get; set; }
    }
}
