using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoAcademia.Dominio
{
    public class Aluno:Pessoa
    {
        public string TurnoAluno { get; set; }
        public virtual Modalidade Modalidade { get; set; }
    }
}
