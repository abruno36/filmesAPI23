using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Gerente;

public class ReadGerenteDto
{
    [Key]
    [Required]
    public int Id { get; set; } = 0;
    [Required(ErrorMessage = "O campo de nome é obrigatório")]
    public string Nome { get; set; } = string.Empty;
    public object? Cinemas { get; set; }  
}
