using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FilmesApi.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; } = 0;
    [Required(ErrorMessage = "O campo de nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O Nome não pode passar de 100 caracteres")]
    public string Nome { get; set; } = string.Empty;
    public virtual Endereco? Endereco { get; set; }
    public int EnderecoId { get; set; } = 0;
    public virtual Gerente? Gerente { get; set; }
    public int GerenteId { get; set; } = 0;
    [JsonIgnore]
    public virtual List<Sessao>? Sessoes { get; set; }
}