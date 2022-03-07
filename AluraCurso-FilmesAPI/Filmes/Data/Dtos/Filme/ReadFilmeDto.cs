using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {

        [Key]
        [Required]
        public int ID { get; internal set; }
        [Required(ErrorMessage = "O campo título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório!")]
        public string Diretor { get; set; }

        [StringLength(45)]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração deve estar entre 1 a 600 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
