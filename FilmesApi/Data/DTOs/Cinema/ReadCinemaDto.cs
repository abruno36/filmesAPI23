using FilmesApi.Data.DTOs.Endereco;
using FilmesApi.Data.DTOs.Gerente;
using FilmesApi.Data.DTOs.Sessao;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Cinema;

public class ReadCinemaDto
{
    [Key]
    [Required]
    public int Id { get; set; } = 0;
    [Required(ErrorMessage = "O campo de nome é obrigatório")]
    public string Nome { get; set; } = string.Empty;
    public ReadEnderecoDto Endereco { get; set; }
    public ReadGerenteDto Gerente { get; set; }
    public ICollection<ReadSessaoDto> Sessoes { get; set; }
}
