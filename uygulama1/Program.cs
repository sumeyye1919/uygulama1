using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ÖDÜNÇ SÜRESİ KONTROLÜ
            * Kullanıcıdan gün sayısı al
            * Sayı olmayan ve 1-7 aralığı dışındaki girişleri reddet
            * Ödünçteki ekipman için talebi reddet
           * abc,0,1,7ve 8 girişleri dene
            */
            Console.Write("GÜN SAYISI GİRİN: ");
            string giris = Console.ReadLine();
            if (int.TryParse(giris, out int gun))
            {
                bool oduncte = true;
                bool uygun = !oduncte && gun >= 1 && gun <= 7;
                if (uygun)
                {
                    Console.WriteLine("uygun,ödünç verilebilir");

                }
                else
                {
                    Console.WriteLine("uygun değil,ödünç verilemez");

                }
            }
            else
            {
                Console.WriteLine("HATALI GİRİŞ 1-7 ARASINDA SAYI GİRİN");
            }



        }
    }
    }

