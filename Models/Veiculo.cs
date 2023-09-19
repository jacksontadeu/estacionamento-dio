using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }



        public Veiculo(string modelo,string placa)
        {
            Modelo = modelo;
            Placa = placa;

        }
        public override string ToString()
        {
            return $"Modelo: {Modelo} Placa: { Placa}";
        }
    }
}
