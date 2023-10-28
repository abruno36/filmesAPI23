﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; } = string.Empty;

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; } = string.Empty;

    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public string Diretor { get; set; } = string.Empty;

    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; } = 0;
}
