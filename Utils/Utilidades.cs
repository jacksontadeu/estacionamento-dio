using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Utils
{
    public class Utilidades
    {
        public static void Menu()
        {
            Console.Clear();
            ExibirNomeEmpresa();
            Console.WriteLine("1 - Entrada de Veículo");
            Console.WriteLine("2 - Saida de Veículo");
            Console.WriteLine("3 - Listagem de Veículo");
            Console.WriteLine("0 - Encerrar Sistema");
            Console.WriteLine("================================");
        }
        public static void ExibirNomeEmpresa()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       Tabajara´s Parking");
            Console.WriteLine("================================");
        }
    }
}
