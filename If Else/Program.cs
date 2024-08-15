using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı al
        Console.Write("Lütfen bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        // İlk kontrol: Sayı 10'a eşit mi, küçük mü, büyük mü?
        if (sayi == 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
        }
        else if (sayi < 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
        }

        // İkinci kontrol: Sayı çift mi tek mi?
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı tektir.");
        }
    }
}