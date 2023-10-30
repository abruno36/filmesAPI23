namespace FilmesApi.Data.DTOs.Sessao;

public class CreateSessaoDto
{
    public int CinemaId { get; set; } = 0;
    public int FilmeId { get; set; } = 0; 
    public DateTime HorarioDeEncerramento { get; set; }
}
