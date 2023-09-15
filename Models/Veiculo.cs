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



        public Veiculo(string placa)
        {
            Placa = placa;

        }
        public override string ToString()
        {
            return Placa;
        }
    }
}
