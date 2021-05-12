using System;
using System.Collections.Generic;
using System.Text;

namespace Lista02Exercicio05.Entities
{
   public class Funcionario
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Departamento Departamento { get; set; }
    }
}


