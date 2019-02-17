using System.ComponentModel.DataAnnotations;

namespace Digipix.Model
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "O Nome deve ter tamanho máximo de 35 caracteres.")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }

        [StringLength(50, ErrorMessage = "O Email deve ter tamanho máximo de 50 caracteres.")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        public string Email { get; set; }

        [StringLength(10, ErrorMessage = "A senha deve ter tamanho entre 6 e 10.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "O Senha é obrigatório")]
        public string Senha { get; set; }

        public EnderecoModel Endereco { get; set; }
    }
}
