﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Cinema;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obrigatório")]
    public string Nome { get; set; } = string.Empty;
}
