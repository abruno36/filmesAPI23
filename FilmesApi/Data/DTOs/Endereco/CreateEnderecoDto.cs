namespace FilmesApi.Data.DTOs.Endereco;

public class CreateEnderecoDto
{
    public string Logradouro { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public int Numero { get; set; }

}
