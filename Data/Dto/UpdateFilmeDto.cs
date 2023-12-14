using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dto
{
    public class UpdateFilmeDto
    {

        [Required(ErrorMessage = "Título do filme é obrigatório.")]
        [StringLength(50, ErrorMessage = "Tamanho do título não deve ser maior que 50 caracteres.")]
        public string Nome { get; set; }

        [Required]
        public string Capa { get; set; }

        [Required(ErrorMessage = "Gênero do filme é obrigatório.")]
        [StringLength(20, ErrorMessage = "Tamanho do título não deve ser maior que 50 caracteres.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Duração do filme é obrigatório.")]
        [Range(70, 600, ErrorMessage = "Duração deve ter entre 70 e 600 minutos.")]
        public int Duracao { get; set; }
    }
}
