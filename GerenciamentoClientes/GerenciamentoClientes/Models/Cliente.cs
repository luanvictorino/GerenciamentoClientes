using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoClientes.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Display(Name ="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        [Display(Name = "Cógido do Endereço")]
        public int EnderecoId { get; set; }
    }
}
