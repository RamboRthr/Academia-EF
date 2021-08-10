using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Dominio
{
    public class Professor:Pessoa
    {
        public virtual List<Turno> Turnos { get; set; }
        public double SalarioHora { get; set; }
    }
}
