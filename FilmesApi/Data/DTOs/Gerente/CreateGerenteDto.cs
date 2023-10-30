using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Gerente;

public class CreateGerenteDto
{
    [Required(ErrorMessage = "O campo de nome é obrigatório")]
    public string Nome { get; set; } = string.Empty;
}
