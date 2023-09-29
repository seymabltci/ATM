using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class customer
    {
        private string tc_no;
        private string name;
        private string surname;
        private int password;
        public int balance;
        public int get_money;
        public int pay_in;

        public string TC
        {
            get { return tc_no; }
            set
            {

                if (value.ToString().Length == 11)
                {
                    tc_no = value;
                }
                else
                {
                    Console.WriteLine("TC kimlik numaranız 11 haneden oluşmalıdır.");
                    Console.ReadLine();
                    tc_no = value;
                }


            }
        }
        public string NAME
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); ; }
        }

        public int PASSWORD
        {
            get { return password; }
            set { password = value; }
        }


        /////KULLANICI GİRİŞİ//// 



        public void login()
        {
            Console.WriteLine("TC kimlik numaranızı giriniz");
            TC = Convert.ToString(Console.ReadLine());
            Console.WriteLine("İsminizi giriniz");
            NAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyisminizi giriniz");
            SURNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("şifrenizi giriniz");
            PASSWORD = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("TC NO: " + TC);
            Console.WriteLine("İSİM: " + NAME);
            Console.WriteLine("SOYİSİM: " + SURNAME);
            Console.WriteLine("ŞİFRE: " + PASSWORD);
            Console.WriteLine("KAYDINIZ ALINDI");


            Console.WriteLine();


        }
        /////BAKİYE SORGULAMA/////////
        public void balances()
        {
            Console.WriteLine("TC kimlik numaranızı giriniz");
            TC = Convert.ToString(Console.ReadLine());
            Console.WriteLine("İsminizi giriniz");
            NAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyisminizi giriniz");
            SURNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("şifrenizi giriniz");
            PASSWORD = Convert.ToInt16(Console.ReadLine());


            if (NAME == "SEYMA" && SURNAME == "BALTACI" && PASSWORD == 1236)
            {
                balance = 150000;

            }

            else
            {
                Console.WriteLine("BİLGİLER HATALI");

            }

            Console.WriteLine("TC NO: " + TC);
            Console.WriteLine("İSİM: " + NAME);
            Console.WriteLine("SOYİSİM: " + SURNAME);
            Console.WriteLine("ŞİFRE: " + PASSWORD);
            Console.WriteLine("Toplam Bakiyeniz: " + balance);


            Console.WriteLine();


        }

        /////PARA ÇEKME //////////

        public void get_in()
        {

            Console.WriteLine("İsminizi giriniz");
            NAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyisminizi giriniz");
            SURNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("şifrenizi giriniz");
            PASSWORD = Convert.ToInt16(Console.ReadLine());


            if (NAME == "SEYMA" && SURNAME == "BALTACI" && PASSWORD == 1236)
            {
                balance = 150000;
                Console.WriteLine("Bakiyeniz:" + balance + "  Çekmek istediğiniz miktarı giriniz.");
                int amount = Convert.ToInt32((Console.ReadLine()));

                balance = balance - amount;
                Console.WriteLine("kalan bakiyeniz:  " + balance);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Bilgiler Hatalı");
            }
        }

        public void pay_money()
        {

            Console.WriteLine("İsminizi giriniz");
            NAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyisminizi giriniz");
            SURNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("şifrenizi giriniz");
            PASSWORD = Convert.ToInt16(Console.ReadLine());


            if (NAME == "SEYMA" && SURNAME == "BALTACI" && PASSWORD == 1236)
            {
                balance = 150000;
                Console.WriteLine("Bakiyeniz:" + balance + "  Yatırmak istediğiniz miktarı giriniz");
                int amount = Convert.ToInt32((Console.ReadLine()));

                balance = balance + amount;
                Console.WriteLine("Toplam bakiyeniz:  " + balance);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Bilgiler Hatalı");
            }
        }
    }
}
