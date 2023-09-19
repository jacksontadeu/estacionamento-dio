using Estacionamento.Models;
using Estacionamento.Utils;
using System.Numerics;
using System.Threading;

namespace Estacionamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utilidades.ExibirNomeEmpresa();
            Console.Write("Valor de Entrada: ");
            decimal entrada = decimal.Parse(Console.ReadLine());

            Console.Write("Valor da Hora: ");
            decimal hora = decimal.Parse(Console.ReadLine());
            Parking es = new Parking(entrada, hora);
            char opcao;
            do
            {
                Utilidades.Menu();
                Console.Write("Digite a opção ou 0 para sair: ");
                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        es.AdicionarVeiculo();
                        break;
                    case '2':
                        es.RemoverVeiculo();
                        break;
                    case '3':
                        es.ListarVeiculos();
                        break;
                    case '0':
                        Console.WriteLine("Fechando o programa!!!");
                        Thread.Sleep(3000);
                        break;
                    default: Console.WriteLine("Opção inválida, digite novamente!!!");
                        break;
                }
            } while (opcao != '0');
        }
        
        
    }
}