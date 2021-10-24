using System;

namespace Cv_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертор валют");
            Console.WriteLine("Введите сумму:");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            int val = 0;
            while (val != 1 & val != 2 & val != 3)
            {
                Console.WriteLine("Введите валюту обмена:\n1 - RUB\n2 - USD\n3 - EUR");
                val = Convert.ToInt32(Console.ReadLine());
                if (val != 1 & val != 2 & val != 3)
                {
                    Console.WriteLine("Введите корректный номер.");
                }

            }


            if (val == 1)
            {
                decimal rub_d = sum / 72M;
                decimal rub_e = sum / 85M;
                Console.WriteLine($"Ваша сумма в долларах: {Decimal.Round(rub_d, 2)}\nВаша сумма в евро: {Decimal.Round(rub_e, 2)}");
            }
            if (val == 2)
            {
                decimal usd_r = sum * 72M;
                decimal usd_e = sum / 0.86M;
                Console.WriteLine($"Ваша сумма в рублях: {Decimal.Round(usd_r, 2)}\nВаша сумма в евро: {Decimal.Round(usd_e, 2)}");
            }
            if (val == 3)
            {
                decimal eur_r = sum * 84M;
                decimal eur_d = sum / 1.16M;
                Console.WriteLine($"Ваша сумма в рублях: {Decimal.Round(eur_r, 2)}\nВаша сумма в долларах: {Decimal.Round(eur_d, 2)}");
            }
        }
    }
}
    
    

