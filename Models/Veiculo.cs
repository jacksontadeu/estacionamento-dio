using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorHora { get; set; }
        public int QuantidadeHoras { get; set; }


        public Veiculo(string placa, decimal valorEntrada, decimal valorHora)
        {
            Placa = placa;
            ValorEntrada = valorEntrada;
            ValorHora = valorHora;
        }


        public void CalcularValor(int totalHoras)
        {
            Console.WriteLine($"Placa: {Placa}");
            decimal total = ValorEntrada + (ValorHora * totalHoras);
            Console.WriteLine($"Valor Total: {total.ToString("F2")}");
            Console.ReadKey();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Placa: {Placa} ");
            return sb.ToString();
        }
    }
}
