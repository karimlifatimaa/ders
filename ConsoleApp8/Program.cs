namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("ali", "aliyev", 11);
            Console.WriteLine("userName daxil et :(min 6 max 25) ");

            user.UserName = Console.ReadLine();
            Console.WriteLine(user.UserName);
            Console.WriteLine("password daxil et :(min 8 max 25)");
            user.Password = Console.ReadLine();
            Console.WriteLine(user.Password);





        }
    }
}