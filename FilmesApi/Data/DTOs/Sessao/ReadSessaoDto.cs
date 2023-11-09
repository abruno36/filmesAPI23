using FilmesApi.Data.DTOs.Cinema;
using FilmesApi.Data.DTOs.Filme;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Sessao;

public class ReadSessaoDto
{
    public ReadCinemaDto Cinema { get; set; }
    public ReadFilmeDto Filme { get; set; }
    public DateTime HorarioDeEncerramento { get; set; }
    public DateTime HorarioDeInicio { get; set; }
}
