using System.ComponentModel.DataAnnotations;

namespace BlazorFormularios.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage="O nome é obrigatório.")]
        [StringLength(50,ErrorMessage="O nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage="O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage="Informe um e-mail válido.")]
        public string Email { get; set; } = string.Empty;
        [Range(1, 120, ErrorMessage = "A idade deve estar entre 1 e 120 anos.")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "O sexo é obrigatório.")]
        [RegularExpression("M|F",ErrorMessage="Sexo deve ser 'M' ou 'F'.")]
        public string Sexo { get; set; } = string.Empty;
        [Required(ErrorMessage = "A data da matrícula é obrigatório.")]
        public DateTime Matricula { get; set; } = DateTime.Today;
        [Range(0, 5000, ErrorMessage = "A mensalidade deve estar entre 0 e 5000.")]
        public decimal Mensalidade { get; set; }
        public bool Ativo { get; set; }
    }
}
