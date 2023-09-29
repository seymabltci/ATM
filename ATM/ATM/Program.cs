using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATM
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            customer customers = new customer();

            




            while (true)
            {
                Console.WriteLine("1. Yeni Müşteri Kaydı");
                Console.WriteLine("2. Bakiye Sorgula");
                Console.WriteLine("3. Para Çek");
                Console.WriteLine("4. Para Yatır");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminizi yapın: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        customers.login();

                        break;
                    case "2":
                        customers.balances();
                        break;
                    case "3":
                        customers.get_in();
                        break;
                    case "4":
                        customers.pay_money();
                        break;
                    case "5":
                        // Programdan çıkış 
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;

                }
               

            }

        }

        
    }
}
