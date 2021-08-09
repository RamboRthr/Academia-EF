using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Dominio
{
    public class Professor:Pessoa
    {
        public Turno Turno { get; set; }
        public double SalarioHora { get; set; }
    }
}
