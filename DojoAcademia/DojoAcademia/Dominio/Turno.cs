using System;
using System.ComponentModel.DataAnnotations;

namespace DojoAcademia.Dominio
{
    public class Turno
    {
        [Key]
        public string Nome{ get; set; }
    }
}
