using System.ComponentModel.DataAnnotations;

public class Livro
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O título é obrigatório.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O título deve conter de 3 a 100 caracteres.")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O autor é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O autor deve conter de 3 a 50 caracteres.")]
    public string Autor { get; set; }
    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O gênero deve conter de 3 a 50 caracteres.")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "O ano de publicação é obrigatório.")]
    [Range(1500, 2100, ErrorMessage = "O ano de publicação é inválido.")]
    public int AnoPublicacao { get; set; }
}
