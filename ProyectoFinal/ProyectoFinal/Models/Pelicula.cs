using System.ComponentModel.DataAnnotations;
namespace ProyectoFinal.Models
{
    public class Pelicula{
        [Key]
        public int idPelicula {  get; set; }
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public string Sinopsis {  get; set; }
        public string Duración {  get; set; }
        public string Clasificación {  get; set; }
        public byte[] Foto {  get; set; }
    }
}
