using System.ComponentModel.DataAnnotations;

namespace BlazorFormularios.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage="o nome é obrigatório.")]
        [StringLength(50,ErrorMessage="O nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage="O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage="Informe um e-mail válido.")]
        public string Email { get; set; } = string.Empty;
        [Range(1,120,ErrorMessage="A idade deve estar entre 1 e 120 anos.")]
        public int Idade { get; set; }
    }
}
