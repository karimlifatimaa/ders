namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car = new car();
            Console.WriteLine("Brend daxil et :");
            car.Brand = Console.ReadLine();
            Console.WriteLine("Model daxil et :");

            car.Model= Console.ReadLine();
            string Str1 = "";
            double CurrentFuel;
            do
            {
                Console.WriteLine("Masinin hazirki benzin miqdari");
                Str1 = Console.ReadLine();

            } while (!double.TryParse(Str1, out CurrentFuel));

            string Str = "";
            double Milliage;
            do
            {
                Console.WriteLine("Masinin bu vaxta qeder nece km surub? ");
                Str = Console.ReadLine();

            } while (!double.TryParse(Str, out Milliage));

            //Console.WriteLine("nece km surmek isteyirsiz? ");
            //int Km=Convert.ToInt32(Console.ReadLine());
            car.Drive(22);
            Console.WriteLine(car.Millage);
        }
    }
}