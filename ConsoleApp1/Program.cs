using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sum = 0;
            //for(int i= 1; i < 100; i++)
            //{
            //    if (i % 2 == 0) 
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);




            //int hasil = 1;
            // int b = 10;
            // for ( int a = 1; a < b; a++)
            // {
            //     hasil *= a;
            // }
            // Console.WriteLine(hasil);



            //int cem = 0;
            //int say = 0;
            //int m = 100;
            //for (int i=1; i <m; i++)
            //{
            //    if(i%5==0 && i%3==0)
            //    {
            //        cem += i;
            //        say += 1;
            //    }      
            //}
            //int edediOrta = cem / say;
            //Console.WriteLine(edediOrta);




            //int n = 20;
            //bool x = false;
            //for( int i = n; n < 100; n++)
            //{
            //    if (n % 21 == 0)
            //    {
            //        x = true;
            //    }
            //}
            //Console.WriteLine(x);


            //int n = 456;
            //int a = n % 100 %10;
            //int b = (n / 10)%10;
            //int c = n / 100;
            //int cem = a + b + c;
            //Console.WriteLine(cem);


            int cem = 0;
            int n = 123;
            while (n != 0) { 
             cem += n % 10;
             n = n / 10;
            }

          Console.WriteLine(cem);
        }
        

    }
}