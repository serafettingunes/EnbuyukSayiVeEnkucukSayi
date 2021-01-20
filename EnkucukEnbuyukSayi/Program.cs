using System;

namespace EnkucukEnbuyukSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, enbuyuk = 0, enkucuk = 999999999;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Bir sayı girin: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (enbuyuk < x)
                {
                    enbuyuk = x;
                }
                if (enkucuk > x)
                {
                    enkucuk = x;
                }
            }
            Console.WriteLine("en büyük sayı:{0} en küçük sayı:{1}", enbuyuk, enkucuk);
        }
    }
}
