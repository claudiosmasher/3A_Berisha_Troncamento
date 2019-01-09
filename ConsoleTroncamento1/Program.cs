using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTroncamento1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inizializzazione variabili
         
            double erroretroncamento = 0.000000095;
            double velocità = 0;
            double erroretempo = 0;
            double errorespazio = 0;

            Console.WriteLine("Inserisci la velocità:");
            velocità = Convert.ToDouble(Console.ReadLine());

            erroretempo = erroretroncamento * 100 * 60 * 60 * 10;

            errorespazio = velocità * erroretempo;

            Console.WriteLine($"Il tempo calcolato in modo errato è {erroretempo}");
            Console.WriteLine(" ");
            Console.WriteLine($"Lo spazio calcolato in modo errato è {errorespazio}");

            Console.ReadLine();
        }
    }
}
