namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //int a = 12;
            //int b = 13;
            //ChangeElments(ref a, ref b);

            //2.

            int[] numbers = { 12, -2, 69, -4 };
            ChangeSign(ref numbers);

        }
        public static void ChangeElments(ref int a,ref int b)
        {
            int temp=a;
            a=b;
            b=temp;
            Console.Write(a + " ");

            Console.WriteLine(b);
        }

        public static void ChangeSign(ref int[] arr)
        {
            
            arr = new int[] { 12, -2, -6, 4 };

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < 0)
                {
                    arr[i]=-arr[i];
                }
                Console.WriteLine(arr[i]);
            }
        }

    }
}