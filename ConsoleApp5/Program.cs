namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(yoxlama("baki",'a'));
            //Area(2);
            //stringtrim(" fatime kerimli");
            //String("Baki Dovlet Uni");
            Console.WriteLine(Max(12,54,22,222));
            Polindrom(1221);
            
           
        }
        //public static bool yoxlama(string a ,char b)
        //{
        //    for(int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] == b)
        //        {
        //            return true;
        //        }

        //    }
        //    return false;
        //}



        //public static void Area(double r)
        //{    
        //    int p = 3;
        //    double s = r * r * p;
        //    Console.WriteLine(s);
        //}
        //public static void Area(double a, double b)
        //{
        //    double s=a * b;
        //    Console.WriteLine(s);
        //}
        //public static void Area(double a, double b,double c)
        //{
        //    double s= 2 * ((a * b) + (a * c) + (b * c));
        //    Console.WriteLine(s);
        //}
        //public static void Area(double a,double r, double b, double c)
        //{
        //int p = 3;
        //    double sahe=p*r*r;
        //    double yari = (a+b+c)/2;
        //    double s = yari*sahe;
        //    Console.WriteLine(s);
        //}



        //public static void StringTrim(string a)
        //{
        //    string b = "";
        //    for (int i = 0; i < a.Length; i++)
        //    {

        //        if (a[i] == ' ')
        //        {
        //            continue;
        //        }
        //        b += a[i];
        //    }
        //    Console.WriteLine(b);
        //}



        //public static void String(string a)
        //{
        //    int temp = 0;
        //    for(int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] != ' ')
        //        {
        //            Console.WriteLine(a[i]);
        //            temp = i;
        //            break;
        //        }
        //    }
        //    for (int i = temp; i < a.Length-1; i++)
        //    {
        //        if (a[i]==' ' && a[i+1]!=' ')
        //        {
        //            Console.WriteLine(a[i+1]);
        //        }
        //    }
        //}

     public static int Max(params int[] eded)
        {
            int max = eded[0];
            for(int i = 0; i < eded.Length; i++)
            {
                if (eded[i] > eded[0])
                {
                    max = eded[i];
                }
            }
            return max;
        }
     


      public static void Polindrom(int eded)
        { //1221
            int tersi = 0;
            int sonEded = eded;
            int qaliq = 0;
            while (eded != 0)
            {
                qaliq = eded % 10;
                tersi=tersi*10+qaliq;
                eded = eded - qaliq;
                eded = eded / 10;
            }
            Console.WriteLine(tersi);
            if (sonEded == tersi)
            {
                Console.WriteLine("palindromdur");
            }
            else
            {
                Console.WriteLine("palindrom deyil");
            }

        }
    }
}