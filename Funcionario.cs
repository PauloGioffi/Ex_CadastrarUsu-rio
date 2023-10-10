using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_corrigido
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int Matricula { get; set; }
        public DateOnly DataContratacao { get; set; }
        private double salariomensal;
        public double SalarioMensal
        {
            get
            {
                return salariomensal;
            }
            set
            {
                if (value < 1320.00)
                {
                    salariomensal = 1320.00;
                }
                else salariomensal = value;
            }
        }


        public Funcionario()
        {
        }

    }
}
