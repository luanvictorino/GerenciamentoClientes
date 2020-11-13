using System.ComponentModel.DataAnnotations;

namespace GerenciamentoClientes.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
    }
}