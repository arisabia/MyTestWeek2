using System;

namespace TestWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = App.Menu();
            Console.WriteLine(account);
            if (account != null)
            {
                bool esito = App.Menu();
            }
        }
    }
}
