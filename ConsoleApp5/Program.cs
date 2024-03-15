namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(yoxlama("baki",'a'));

        }
        public static bool yoxlama(string a ,char b)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}