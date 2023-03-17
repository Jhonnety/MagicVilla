using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Api.Modelos.Dto
{
    public class VillaDto
    {
        //Los Dto son para exponer solo los datos que quiero del modelo
        //Entity framework core ese usa para trabajar con base de datos,
        //es un orm que maneja las operaciones de la base de datos, en lugar de usar queries
        //Microsoft.EntityFrameworkCore.SqlServe
        //Microsoft.EntityFrameworkCore.Tools
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        [Required]
        public double Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public string ImageUrl { get; set; }
        public string Amenida { get; set; }
    }
}
