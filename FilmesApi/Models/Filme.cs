using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; } = 0;

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; } = string.Empty;

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; } = string.Empty;

    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public string Diretor { get; set; } = string.Empty;

    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; } = 0;

    public int ClassificacaoEtaria { get; set; }
    [JsonIgnore]
    public virtual List<Sessao>? Sessoes { get; set; }
}
