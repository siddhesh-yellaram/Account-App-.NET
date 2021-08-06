using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountApp.Model;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Sid", 106, 1500);
            a1.deposit(200);
            Console.WriteLine("New Balance for a1 is: " + a1.Balance);
            try
            {
                a1.withdraw(1000);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
