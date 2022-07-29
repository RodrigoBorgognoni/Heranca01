using System;
using Heranca01.Entities;

namespace Heranca01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            // parâmetro Balance está como protected, ou seja, só pode ser modificado diretamente pela Classe e pela subclasse
            //account.Balance = 1000;
        }
    }
}
