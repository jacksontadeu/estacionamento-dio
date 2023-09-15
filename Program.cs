using Estacionamento.Models;
using System.Numerics;
using System.Threading;

namespace Estacionamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            Console.Write("Valor de Entrada: ");
            decimal entrada = decimal.Parse(Console.ReadLine());

            Console.Write("Valor da Hora: ");
            decimal hora = decimal.Parse(Console.ReadLine());
            int opcao;
            do
            {
                Menu();
                Console.Write("Digite a opção ou 0 para sair:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite a placa do veículo: ");
                        string placa = Console.ReadLine();
                        veiculos.Add(new Veiculo(placa, entrada, hora));
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite a placa do veículo: ");
                        string placaVeiculo = Console.ReadLine();
                        for(int i = 0; i< veiculos.Count; i++)
                        {
                            if (veiculos[i].Placa.Equals(placaVeiculo))
                            {
                                Console.Write("Total de Horas: ");
                                int totalHoras = int.Parse(Console.ReadLine());
                                veiculos[i].CalcularValor(totalHoras);
                                veiculos.Remove(veiculos[i]);
                            }
                            else
                            {
                                Console.WriteLine("Veiculo não encontrado!!!");
                                Console.ReadKey();
                            }
                        }
                       
                        break;
                    case 3:
                        Console.Clear();
                        foreach (var veiculo in veiculos)
                        {
                            Console.WriteLine(veiculo.ToString());
                        }
                        Console.WriteLine("Pressione uma tecla para continuar!!!");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Fechando o programa!!!");
                        Thread.Sleep(3000);
                        break;
                    default: Console.WriteLine("Opção inválida, digite novamente!!!");
                        break;
                }
            } while (opcao !=0);
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Tabajara´s Parking");
            Console.WriteLine("1 - Entrada de Veículo");
            Console.WriteLine("2 - Saida de Veículo");
            Console.WriteLine("3 - Listagem de Veículo");
            Console.WriteLine("0 - Encerrar Sistema");
        }
        
    }
}