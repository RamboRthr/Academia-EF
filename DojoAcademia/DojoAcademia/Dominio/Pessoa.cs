using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Dominio
{
    public class Pessoa
    {
        [Key]
        public string CPF { get; set; }

        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
