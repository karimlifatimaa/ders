using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;
       
        public void Drive(int a)
        {
            double lazimliBenzin = FuelFor1Km * a;
            if (CurrentFuel >= lazimliBenzin)
            {
                Millage += a;
                CurrentFuel -= lazimliBenzin;
            }
            else { 
            Console.WriteLine("xeta");
            }
        }
    }
}
