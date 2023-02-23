using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            string[] yorum2 = new string[50];
            for (int i = 0; i < 50; i++)
            {
                toplam = toplam + PuanVer();
                yorum2[i] = YorumYap();
            }
            Console.WriteLine();
            PuanGoster(toplam);
            YorumGoster(yorum2);
        }
        static int PuanVer()
        {

            Console.Write("Ürüne puanınız:");
            int urunpuanı = Convert.ToInt32(Console.ReadLine());
            return urunpuanı;
        }
        static string YorumYap()
        {
            Console.Write("Yorum:");
            string yorum = Console.ReadLine();
            return yorum;
        }

        static void PuanGoster(int toplam)
        {
            double ortalama = (double)toplam / 50;
            Console.Write("Puan:{0}", ortalama);
            Console.WriteLine();
        }

        static void YorumGoster(string[] yorum2)
        {
            for (int i = 0; i < yorum2.Length; i++)
            {
                Console.WriteLine("{0}", yorum2[i]);
            }
        }
    }
}