using System.ComponentModel.DataAnnotations;

namespace Digipix.Model
{
    public class EnderecoModel
    {
        [Required(ErrorMessage = "O Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        
        [StringLength(10, ErrorMessage = "O Número deve ter tamanho máximo de 10 caracteres.")]
        [Required(ErrorMessage = "O Numero é obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O Cidade é obrigatório")]
        public string Cidade { get; set; }

        [StringLength(9, ErrorMessage = "O Cep deve ter tamanho máximo de 9 caracteres.")]
        [Required(ErrorMessage = "O Cep é obrigatório")]
        public string Cep { get; set; }

        [StringLength(40, ErrorMessage = "O Complemento deve ter tamanho máximo de 40 caracteres.")]
        public string Complemento { get; set; }
    }
}
