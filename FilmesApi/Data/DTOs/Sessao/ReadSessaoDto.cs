using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Sessao;

public class ReadSessaoDto
{
    [Key]
    [Required]
    public int Id { get; set; }
    public Models.Cinema? Cinema { get; set; }
    public Models.Filme? Filme { get; set; }
    public DateTime HorarioDeEncerramento { get; set; }
    public DateTime HorarioDeInicio { get; set; }
}
