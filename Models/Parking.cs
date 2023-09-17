using Estacionamento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Parking
    {
        private decimal ValorInicial { get; set; }
        private decimal ValorHora { get; set; }
        private  Veiculo Veiculo { get; set; }

        private List<Veiculo> veiculos = new List<Veiculo>();

        public Parking(decimal valorInicial, decimal valorHora)
        {
            ValorInicial = valorInicial;
            ValorHora = valorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.Clear();
            Utilidades.ExibirNomeEmpresa();
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            veiculos.Add(new Veiculo(placa));

        }
        int totalHoras = 0;
        public void RemoverVeiculo()
        {
            Console.Clear();
            Utilidades.ExibirNomeEmpresa();
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            if (veiculos.Any(v => v.Placa.Equals(placa)))
            {
                Console.Write("Total de Horas: ");
                totalHoras = int.Parse(Console.ReadLine());
                Console.Clear();
                Utilidades.ExibirNomeEmpresa();
                Console.WriteLine("       Recibo ");
                Console.WriteLine($"Veículo: {placa}");
                Console.WriteLine($"Total de Horas: {totalHoras}");
                Console.WriteLine($"Valor a Pagar: {CalcularValor(totalHoras):C}");
                Console.WriteLine("================================");
                Console.ReadKey();
                Console.WriteLine($"Veículo {placa} removido com sucesso!!!");
               
                int index = veiculos.FindIndex(v=> v.Placa.Equals(placa));
                veiculos.RemoveAt(index);
                Console.ReadKey();
               
            }
            else
            {
                Console.WriteLine("Veiculo não encontrado!!!");
                Console.ReadKey();
            }
        }
        public decimal CalcularValor(int totalHora)
        {
            decimal total = this.ValorInicial + (this.ValorHora * totalHora);
            return total;
        }
        public void ListarVeiculos()
        {
            Console.Clear();
            Utilidades.ExibirNomeEmpresa();
            Console.WriteLine("Lista de veículos estacionados!!!");
            if (veiculos.Any())
            {
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                    
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!!!");
            }
            Console.ReadKey();
        }
        
    }
}
