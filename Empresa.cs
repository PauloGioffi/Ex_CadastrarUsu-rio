using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_corrigido
{
    public class Empresa
    {
        public List<Funcionario> Colaborador { get; set; }

        public string Nome { get; }
        public string CNPJ { get; }

        public int Filial { get; }


        public Empresa(string nome, string cnpj, int filial)
        {
            this.Nome = nome;
            this.CNPJ = cnpj;
            this.Filial = filial;
            this.Colaborador = new();
            
        }

        public void ListarColaboradores()
        {
            foreach (var colaborador in Colaborador)
            {
                Console.WriteLine(colaborador.Nome + " " + colaborador.Sobrenome);
                Console.WriteLine(colaborador.Matricula);
                Console.WriteLine(colaborador.DataContratacao);
                Console.WriteLine(colaborador.SalarioMensal);
                Console.WriteLine("");
            }
        }
        public void PromoverColaborador()
        {
            Console.WriteLine("Digite o nome do colaborador: ");
            string nomeColaborador = Console.ReadLine();
            var nomeBuscado = Colaborador.FirstOrDefault(x => x.Nome==nomeColaborador);

            if(nomeBuscado != null)
                Console.WriteLine($" O colaborador {nomeBuscado.Nome} foi promovido com sucesso!");
        }
        public void DemitirColaborador()
        {
            Console.WriteLine("Digite o nome do colaborador: ");
            string nomeColaborador = Console.ReadLine();
            var nomeBuscado = Colaborador.FirstOrDefault(x => x.Nome == nomeColaborador);

            if (nomeBuscado != null)
                Console.WriteLine($" O colaborador {nomeBuscado.Nome} foi desligado da empresa");
        }
        public void ListarSalarioAnual()
        {
            Console.WriteLine("Digite o nome do colaborador: ");
            string nomeColaborador = Console.ReadLine();
            var nomeBuscado = Colaborador.FirstOrDefault(x => x.Nome == nomeColaborador);
            if (nomeBuscado != null)
            {
                double salarioAnual = nomeBuscado.SalarioMensal*12;
                Console.WriteLine(salarioAnual);
            }
        }
        public void ReajusteSalarial()
        {
            foreach (var colaborador in Colaborador)
            {
                
                colaborador.SalarioMensal += (colaborador.SalarioMensal * 0.1);
                
            }
        }

    }
    }
