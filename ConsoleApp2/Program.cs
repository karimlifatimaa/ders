using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[] { 85, 45, 68, 100 };
            //int max = numbers[0];
            //int max2 = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (max > numbers[i])
            //    {
            //        max2 = numbers[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(max2);




            //int hasil = 1;
            //int[] numbers = new int[] { 1, 4, 2, 1 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        hasil *= numbers[i];
            //    }
            //}
            //Console.WriteLine(hasil);





            //int cem=0;
            //int[] numbers = new int[] { 1, 4, 2, 1 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        cem += numbers[i];
            //    }
            //}
            //Console.WriteLine(cem);



            //int[] numbers = new int[] { 1, 4, 2, 1 };
            //int eded = 12;
            //bool deyer = false;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (eded > numbers[i])
            //    {
            //        deyer = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(deyer);









            //string[] metn = { "baki", "dovlet", "uni" };
            //string soz = "baki";
            //bool test = false;
            //for (int i = 0; i < metn.Length; i++)
            //{
            //    if (metn[i] == soz)
            //    {
            //        test = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(test);




            //string soz = "baki";
            //char herf = 'b';
            //bool test = false;
            //for (int i = 0; i < soz.Length; i++)
            //{
            //    if (soz[i] == herf)
            //    {
            //        test = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(test);




            string[] metn = { "baki", "dovlet", "uni" };
            for (int i = metn.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(metn[i]);
            }




            //string[] metn = { "baki", "dovlet", "uni" };
            //string soz = "";
            //for (int i = 0; i < metn.Length; i++)
            //{
            //    soz = metn[i];

            //    for (int j = soz.Length - 1; j >= 0; j--)

            //    {
            //        Console.Write(soz[j]);


            //    }
            //    Console.WriteLine();
            //}



        }
    }
}
