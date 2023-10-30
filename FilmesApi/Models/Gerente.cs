using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FilmesApi.Models;

public class Gerente
{
    [Key]
    [Required]
    public int Id { get; set; } = 0;
    [Required(ErrorMessage = "O campo de nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O Nome não pode passar de 100 caracteres")]
    public string Nome { get; set; } = string.Empty;
    [JsonIgnore]
    public virtual List<Cinema>? Cinemas { get; set; }
}
