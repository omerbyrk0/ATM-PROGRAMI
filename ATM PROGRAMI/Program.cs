using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_KARAR_YAPILARI_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ATM işlemler
            //1 e basarsa bakiye sorma
            //2 ye basarsa para çekme
            //3 e basarsa para yatırma
            // q ya basarsa çıkış yapma

            int bakiye = 1000;

            Console.WriteLine("HOŞGELDİNİZ");
            Console.WriteLine("AŞAĞIDAKİ İŞLEMLERİ ÜCRETSİZ ŞEKİLDE YAPABİLİRSİNİZ");
            Console.WriteLine("1 - BAKİYE ÖĞRENME");
            Console.WriteLine("2 - PARA ÇEKME");
            Console.WriteLine("3 - PARA YATIRMA");
            Console.WriteLine("q - ÇIKIŞ");
            Console.WriteLine("******************************");
            Console.WriteLine("YAPMAK İSTEDİĞNİZ İŞLEM NEDİR?");

            while (true)
            {
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("BAKİYENİZ : " + bakiye);
                }

                else if (secim == "2")
                {
                    Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ TUTARI GİRİNİZ");
                    string tutar = Console.ReadLine();
                    int cekilecektutar = int.Parse(tutar);
                    if (cekilecektutar <= bakiye)
                    {
                        Console.WriteLine("KALAN TUTAR : " + (bakiye - cekilecektutar));
                       
                    }
                    else
                    {
                        Console.WriteLine("BAKİYE YETERSİZ");
                        


                    }

                }

                else if (secim == "3")
                {
                    Console.WriteLine("YATIRMAK İSTEDİĞİNİZ TUTARI GİRİNİZ");
                    string tutar1 = Console.ReadLine();
                    int yatırılacaktutar = int.Parse(tutar1);
                    Console.WriteLine("YENİ BAKİYENİZ : " + (bakiye + yatırılacaktutar));
                    
                }

                else if (secim == "q")
                {
                    Console.WriteLine("ATM DEN ÇIKIŞ YAPILIYOR...");
                    Console.WriteLine("ÇIKIŞ YAPILDI İYİ GÜNLER DİLERİZ.");

                    
                    break;
                }
                else
                {
                    Console.WriteLine("LUTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ");
                    
                }

                Console.WriteLine("************************************");
                Console.WriteLine("BAŞKA BİR İŞLEM YAPMAK İSTER MİSİNİZ");

            }
            
            Console.ReadLine();


        }

    }
}
