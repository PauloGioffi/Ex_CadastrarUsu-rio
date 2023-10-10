using Exercicio_corrigido;
using System.Threading.Channels;

internal class program
{
    static void Main(string[] args)
    {
        
        Empresa Empresa1 = new("Atacadão", "79.111.852/0001-53", 292);
        int continuar = 1;
        while (continuar == 1)
        {
            Console.WriteLine("Selecione a opção da tarefa que deseja executar!");
            Console.WriteLine("");
            Console.WriteLine("Digite 1 para: Cadastrar funcionário.");
            Console.WriteLine("Digite 2 para: Listar todos os empregados cadastrados.");
            Console.WriteLine("Digite 3 para: Promover empregado.");
            Console.WriteLine("Digite 4 para: Demitir empregado.");
            Console.WriteLine("Digite 5 para: listar salário anual do empregado.");
            Console.WriteLine("Digite 6 para: Reajustar salário mensal.");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao) 
            { 
                case 1:
                    Funcionario funcionario = new()
                    {
                        Nome = Console.ReadLine(),
                        Sobrenome = Console.ReadLine(),
                        Idade = int.Parse(Console.ReadLine()),
                        DataNascimento = DateOnly.Parse(Console.ReadLine()),
                        Matricula = int.Parse(Console.ReadLine()),
                        DataContratacao = DateOnly.Parse(Console.ReadLine()),
                        SalarioMensal = double.Parse(Console.ReadLine()),
                    };
                    Empresa1.Colaborador.Add(funcionario);
                    break;
                case 2:
                    Empresa1.ListarColaboradores();
                    break;
                case 3:
                    Empresa1.PromoverColaborador();
                    break;
                case 4:
                    Empresa1.DemitirColaborador();
                    break;
                case 5:
                    Empresa1.ListarSalarioAnual();
                    break;
                case 6:
                    Empresa1.ReajusteSalarial();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            Console.WriteLine("Para continuar no menu digite 1. Para finalizar digite 0.");
            continuar = int.Parse(Console.ReadLine());

        }
    }
}

