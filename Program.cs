using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//b16) Uživatel zadá dvě čísla. Poté se objeví nabídka, zda chce sčítat, odčítat, násobit,
//dělit nebo končit. Poté se objeví výsledek vybrané operace se zadanými čísly nebo program skončí.
namespace SimpleCsharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int operace = 0;

            Console.WriteLine("Zadej dve cisla:");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej cislo(1-5) jakou operaci chces udelat, " + "\n" +
                "1 - scitat, 2 - odcitat, 3 - nasobit, 4 - delit, 5 - skoncit");
            operace = int.Parse(Console.ReadLine());

            switch (operace)
            {

                case 1: Console.WriteLine(a + b); break;
                case 2: Console.WriteLine(a - b); break;
                case 3: Console.WriteLine(a * b); break;
                case 4: Console.WriteLine(a / (double)b); break;
                case 5: break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
