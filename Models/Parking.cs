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
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            veiculos.Add(new Veiculo(placa));

        }
        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            if (veiculos.Any(v => v.Placa.Equals(placa)))
            {
                Console.Write("Total de Horas: ");
                int totalHoras = int.Parse(Console.ReadLine());
                Console.WriteLine($"Veículo {placa} removido com sucesso!!!");
                Console.WriteLine($"Total a pagar: {CalcularValor(totalHoras).ToString("F2")}");
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
            
        }
    }
}
