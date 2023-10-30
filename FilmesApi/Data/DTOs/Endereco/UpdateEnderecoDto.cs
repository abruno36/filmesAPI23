namespace FilmesApi.Data.DTOs.Endereco;

public class UpdateEnderecoDto
{
    public string Logradouro { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public int Numero { get; set; } = 0;
}
