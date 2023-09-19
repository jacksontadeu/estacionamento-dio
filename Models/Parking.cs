using Estacionamento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Console.Write("Modelo do veículo: ");
            string modelo = Console.ReadLine().ToUpper();
            Console.Write("Placa do veículo.: ");
            string placa = Console.ReadLine().ToUpper(); ;
            veiculos.Add(new Veiculo(modelo,placa));
<<<<<<< HEAD
            Console.WriteLine("==================================");
            Console.WriteLine("Veículo adicionado com sucesso!!!");
            Console.WriteLine("==================================");
            Console.ReadKey();
=======

>>>>>>> 54e1d4b5ac85b812e33d50a8a692aaaed92f9cfa
        }
        int totalHoras = 0;
        public void RemoverVeiculo()
        {
            Console.Clear();
            Utilidades.ExibirNomeEmpresa();
            Console.Write("Placa do veículo: ");
            string placa = Console.ReadLine().ToUpper();
            if (veiculos.Any(v => v.Placa.Equals(placa)))
            {
                int index = veiculos.FindIndex(v => v.Placa.Equals(placa));
                Console.Write("Total de Horas: ");
                totalHoras = int.Parse(Console.ReadLine());
                Console.Clear();
                Utilidades.ExibirNomeEmpresa();
                EmitirRecibo(placa);
                Console.ReadKey();
                Console.WriteLine($"Saída do Veículo {veiculos[index].Modelo} placa {placa} realizada com sucesso!!!");
                
                
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
        public void EmitirRecibo(string placa)
        {
            if(veiculos.Any(v => v.Placa.Equals(placa)))
            {
                int index = veiculos.FindIndex(v => v.Placa.Equals(placa));
                Console.WriteLine("           Recibo ");
                Console.WriteLine("================================");
                Console.WriteLine($"Veículo: {veiculos[index].Modelo}");
                Console.WriteLine($"Placa..: {placa}");
                Console.WriteLine($"Total de Horas: {totalHoras}");
                Console.WriteLine($"Valor a Pagar: {CalcularValor(totalHoras):C}");
                Console.WriteLine("================================");
            }
            
        }
        
    }
}
