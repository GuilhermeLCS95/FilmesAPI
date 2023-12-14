using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dto
{
    public class ReadFilmeDto
    {
        public string Nome { get; set; }

        public string Capa { get; set; }

        public string Genero { get; set; }

        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set;} = DateTime.Now;
    }
}
