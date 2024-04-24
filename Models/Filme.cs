using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo is required")] 
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Genero is required")]
        [MaxLength(50)]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Duracao is required")]
        [Range(70, 600)]
        public int Duracao { get; set; }
    }
}
