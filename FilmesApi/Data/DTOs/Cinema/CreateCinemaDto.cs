using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Cinema;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obrigatório")]
    public string Nome { get; set; } = string.Empty;
    //public int EnderecoFK { get; set; }
    //public int GerenteFK { get; set; }
    public int EnderecoId { get; set; } = 0;
    public int GerenteId { get; set; } = 0;
}
