namespace FilmesApi.Data.DTOs;

public class ReadFilmeDto
{
    public string Titulo { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public int Duracao { get; set; } = 0;
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}
