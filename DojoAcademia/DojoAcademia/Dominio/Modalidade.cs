using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Dominio
{
    public class Modalidade
    {
        [Key]
        public string Nome { get; set; }
        public double PrecoHora { get; set; }
        public int VezesSemana { get; set; }
        public string Professor { get; set; }
    }
}
