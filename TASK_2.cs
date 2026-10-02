using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Fiqur secin:");
            //Console.WriteLine("1. Daire");
            //Console.WriteLine("2. Duzbucaqli");
            //Console.WriteLine("3. Ucbucaq");

            //Console.Write("Seciminizi daxil edin: ");
            //string secim = Console.ReadLine();

            //switch (secim)
            //{
            //    case "1":
            //        Console.Write("Dairenin radiusunu daxil edin: ");
            //        double radius = Convert.ToDouble(Console.ReadLine());

            //        double dairenin_sahesi = Math.PI * Math.Pow(radius, 2);

            //        Console.WriteLine("Dairenin sahesi: " + Math.Round(dairenin_sahesi));
            //        break;

            //    case "2":
            //        Console.Write("Duzbucaqlinin uzunlugunu daxil edin: ");
            //        double uzunluq = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Duzbucaqlinin enini daxil edin: ");
            //        double en = Convert.ToDouble(Console.ReadLine());

            //        double duzbucaqlinin_sahesi = uzunluq * en;

            //        Console.WriteLine("Duzbucaqlinin sahesi: " + Math.Round(duzbucaqlinin_sahesi));
            //        break;

            //    case "3":
            //        Console.Write("Ucbucagin birinci terefini daxil edin: ");
            //        double a = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Ucbucagin ikinci terefini daxil edin: ");
            //        double b = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Ucbucagin ucuncu terefini daxil edin: ");
            //        double c = Convert.ToDouble(Console.ReadLine());

            //        double p = (a + b + c) / 2;

            //        double ucbucaqin_sahesi = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            //        Console.WriteLine("Ucbucagin sahesi: " + Math.Round(ucbucaqin_sahesi));
            //        break;

            //    default:
            //        Console.WriteLine("Yanlis secim etdiniz!");
            //        break;
            //}


            //2
            //Dictionary<int, string> telebeler = new Dictionary<int, string>();

            //telebeler.Add(101, "Firuze");
            //telebeler.Add(102, "Sevcan");
            //telebeler.Add(103, "Aydan");
            //telebeler.Add(104, "Murad");
            //telebeler.Add(105, "Orxan");

            //while (true)
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("1 - Telebe elave et");
            //    Console.WriteLine("2 - Telebe axtar");
            //    Console.WriteLine("3 - Butun telebeleri goster");
            //    Console.WriteLine("4 - Cixis");

            //    Console.Write("Secim edin: ");
            //    string secim = Console.ReadLine();

            //    switch (secim)
            //    {
            //        case "1":
            //            Console.Write("ID daxil edin: ");
            //            int id = Convert.ToInt32(Console.ReadLine());

            //            Console.Write("Ad daxil edin: ");
            //            string ad = Console.ReadLine();

            //            if (telebeler.ContainsKey(id))
            //            {
            //                Console.WriteLine("Bu ID artiq var.");
            //            }
            //            else
            //            {
            //                telebeler.Add(id, ad);
            //                Console.WriteLine("Telebe elave olundu.");
            //            }
            //            break;

            //        case "2":
            //            Console.Write("Telebenin ID-sini daxil edin: ");
            //            int id2 = Convert.ToInt32(Console.ReadLine());

            //            if (telebeler.ContainsKey(id2))
            //            {
            //                Console.WriteLine("Telebe: " + telebeler[id2]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Telebe tapilmadi.");
            //            }
            //            break;

            //        case "3":
            //            foreach (var telebe in telebeler)
            //            {
            //                Console.WriteLine(telebe.Key + " - " + telebe.Value);
            //            }
            //            break;

            //        case "4":
            //            Console.WriteLine("Cixis edildi.");
            //            return;

            //        default:
            //            Console.WriteLine("Bele secim yoxdur.");
            //            break;
            //    }
            //}

            //3
            //List<int> ededler = new List<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Eded daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    ededler.Add(eded);
            //}

            //int enBoyuk = ededler[0];
            //int enKicik = ededler[0];

            //int cutSayi = 0;
            //int tekSayi = 0;

            //foreach (int eded in ededler)
            //{
            //    if (eded > enBoyuk)
            //    {
            //        enBoyuk = eded;
            //    }

            //    if (eded < enKicik)
            //    {
            //        enKicik = eded;
            //    }

            //    if (eded % 2 == 0)
            //    {
            //        cutSayi++;
            //    }
            //    else
            //    {
            //        tekSayi++;
            //    }
            //}

            //Console.WriteLine("En boyuk: " + enBoyuk);
            //Console.WriteLine("En kicik: " + enKicik);
            //Console.WriteLine("Cut ededlerin sayi: " + cutSayi);
            //Console.WriteLine("Tek ededlerin sayi: " + tekSayi);

            //4
            //Random random = new Random();
            //int secilenEded = random.Next(0, 101);

            //int texmin;

            //do
            //{
            //    Console.Write("Eded daxil edin: ");
            //    texmin = Convert.ToInt32(Console.ReadLine());

            //    if (texmin > secilenEded)
            //    {
            //        Console.WriteLine("Daha kicik eded cehd edin.");
            //    }
            //    else if (texmin < secilenEded)
            //    {
            //        Console.WriteLine("Daha boyuk eded cehd edin.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tebrikler!");
            //        break;
            //    }

            //    if (secilenEded % 2 == 0)
            //    {
            //        Console.WriteLine("Ipucu: Eded cutdur.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ipucu: Eded tekdir.");
            //    }

            //    if (secilenEded > 50)
            //    {
            //        Console.WriteLine("Ipucu: Eded 50-den boyukdur.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ipucu: Eded 50-den kicikdir.");
            //    }

            //    int ferq = Math.Abs(texmin - secilenEded);

            //    if (ferq < 10)
            //    {
            //        Console.WriteLine("Cox yaxinsiniz!");
            //    }
            //    else if (ferq < 20)
            //    {
            //        Console.WriteLine("Yaxinsiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Uzaqsiniz.");
            //    }

            //} while (texmin != secilenEded);
        }

    }
}
