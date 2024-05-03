using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int bakiye = r.Next(50, 100);
            while (true)
            {
                Console.WriteLine("taş kağıt makas : 1");
                Console.WriteLine("sayı tahmini : 2");
                Console.WriteLine("blackjack : 3\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("seçim : ");
                Console.ResetColor();
                string oyun = Console.ReadLine();
                while (oyun != "1" && oyun != "2" && oyun != "3")
                {
                    Console.WriteLine("geçerli bir seçim yap!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("seçim : ");
                    Console.ResetColor();
                    oyun = Console.ReadLine();
                }
                Console.WriteLine();
                if (oyun == "1")
                {
                    int sayac = 0;
                    string secim = "";
                    string tas = "";
                    string kagit = "";
                    string makas = "";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("çıkış yapmak için : '1'\n");
                    Console.ResetColor();
                    Console.WriteLine("oyun : taş kağıt makas\n");
                    Console.WriteLine("iddia = -5 $");
                    Console.WriteLine("beraberlik durumu : +5 $");
                    Console.WriteLine("kazanç durumu = +10 $\n");
                    while (bakiye > 4)
                    {
                        if (secim == "1")
                        {
                            break;
                        }
                        while (secim != "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("bakiye : " + bakiye + " $\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("seçim : ");
                            Console.ResetColor();
                            secim = Console.ReadLine();
                            secim = secim.ToLower().Trim();
                            if (secim == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nçıkış yapıldı\n");
                                Console.ResetColor();
                                break;
                            }
                            while (secim != "taş" && secim != "makas" && secim != "kağıt")
                            {
                                Console.WriteLine("\n'taş','kağıt' ya da 'makas' girmelisin!\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("seçim : ");
                                Console.ResetColor();
                                secim = Console.ReadLine();
                                secim = secim.ToLower().Trim();
                                if (secim == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nçıkış yapıldı\n");
                                    Console.ResetColor();
                                    break;
                                }
                            }
                            bakiye -= 5;
                            Random r2 = new Random();
                            int pc = r2.Next(1, 4);
                            if (pc == 1)
                            {
                                tas = "taş";
                            }
                            if (pc == 2)
                            {
                                kagit = "kağıt";
                            }
                            if (pc == 3)
                            {
                                makas = "makas";
                            }
                            string tkm = tas + kagit + makas;
                            if (sayac % 3 == 0)
                            {
                                if (secim == "taş")
                                {
                                    tkm = "kağıt";
                                }
                                else if (secim == "kağıt")
                                {
                                    tkm = "makas";
                                }
                                else if (secim == "makas")
                                {
                                    tkm = "taş";
                                }
                            }
                            if (secim == "1")
                            {
                                break;
                            }
                            Console.WriteLine("pc : " + tkm);
                            if (secim == tkm)
                            {
                                bakiye += 5;
                            }
                            else if (secim == "taş" && tkm == "makas")
                            {
                                bakiye += 10;
                            }
                            else if (secim == "kağıt" && tkm == "taş")
                            {
                                bakiye += 10;
                            }
                            else if (secim == "makas" && tkm == "kağıt")
                            {
                                bakiye += 10;
                            }
                            tkm = "";
                            tas = "";
                            kagit = "";
                            makas = "";
                            sayac++;
                            Console.WriteLine();
                            if (bakiye < 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("bütçe yeterli değil!");
                                Console.ResetColor();
                                break;
                            }
                        }
                        if (bakiye < 5)
                        {
                            break;
                        }

                    }
                }
                if (oyun == "2")
                {
                    int sayac = 0;
                    int sayi;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("çıkış yapmak için : '0'\n");
                    Console.ResetColor();
                    Console.WriteLine("oyun : sayı tahmini");
                    Console.WriteLine("1 ile 5 arası\n");
                    Console.WriteLine("iddia = -5 $");
                    Console.WriteLine("beraberlik durumu : +5 $");
                    Console.WriteLine("kazanç durumu = +10 $\n");
                    while (bakiye > 4)
                    {
                        sayac++;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nbakiye : " + bakiye + " $\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("sayı : ");
                        Console.ResetColor();
                        sayi = Convert.ToInt32(Console.ReadLine());
                        if (sayi == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nçıkış yapıldı\n");
                            Console.ResetColor();
                            break;
                        }
                        while (sayi > 5 || sayi < 1)
                        {
                            Console.WriteLine("1 ile 5 arasında bir sayı gir!\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("sayı : ");
                            Console.ResetColor();
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                        while (sayi != 0)
                        {
                            Random rndsayi = new Random();
                            int randomsayi = rndsayi.Next(1, 6);
                            if (sayac % 3 == 0)
                            {
                                if (randomsayi == sayi)
                                {
                                    randomsayi = sayi + 1;
                                    if (randomsayi > 5)
                                    {
                                        randomsayi -= 2;
                                        if (randomsayi < 1)
                                        {
                                            randomsayi += 3;
                                        }
                                    }
                                }
                            }
                            Console.WriteLine("pc : " + randomsayi);
                            if (sayi == randomsayi)
                            {
                                bakiye += 10;
                            }
                            else
                            {
                                bakiye -= 5;
                            }
                            Console.WriteLine();
                            break;
                        }
                    }
                    if (bakiye < 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("bütçe yeterli değil!");
                        Console.ResetColor();
                    }
                }
                if (oyun == "3")
                {
                    int kir = 0;
                    string blackjack;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("çıkış yapmak için : '0'\n");
                    Console.ResetColor();
                    Console.WriteLine("oyun : blackjack");
                    Console.WriteLine("21 olan kazanır\n");
                    Console.WriteLine("iddia = -10 $");
                    Console.WriteLine("beraberlik durumu : +10 $");
                    Console.WriteLine("kazanç durumu = +30 $\n");
                    int sayac = 0;
                    Random r3 = new Random();
                    int kru = r3.Next(1, 11);
                    int oync = r.Next(1, 10);
                    Console.WriteLine("krupiye : " + kru);
                    Console.WriteLine("sen : " + oync);
                    while (bakiye>29)
                    {
                        while (oync <= 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nbakiye : " + bakiye + " $\n");
                            Console.ResetColor();
                            if (oync == 21)
                            {
                                break;
                            }
                            Console.WriteLine("1.al   2.kal\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("seçim : ");
                            Console.ResetColor();
                            blackjack = Console.ReadLine();
                            if (blackjack == "0")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nçıkış yapıldı!\n");
                                Console.ResetColor();
                                kir = 1;
                                break;
                            }
                            if (blackjack != "0")
                            {
                                while (blackjack.Trim() != "1" && blackjack.Trim() != "2")
                                {
                                    Console.WriteLine("geçerli bir seçim yap!\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("seçim : ");
                                    Console.ResetColor();
                                    blackjack = Console.ReadLine();
                                }
                                if (blackjack == "1")
                                {
                                    Random r4 = new Random();
                                    int oync2 = r4.Next(1, 11);
                                    oync = oync + oync2;
                                    Console.WriteLine("\nsen : " + oync);
                                }
                                if (blackjack == "2")
                                {
                                    break;
                                }
                            }
                        }
                        if (kir==1)
                        {
                            break;
                        }
                        if (kir != 1)
                        {
                            kru = kru + r.Next(1, 11);
                            while (kru <= 17)
                            {
                                kru = kru + r.Next(1, 11);
                            }
                            Console.WriteLine("\nsen : " + oync);
                            Console.WriteLine("krupiye : " + kru);
                            Console.WriteLine();
                            if (oync == kru)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("berabere!\n");
                                Console.ResetColor();
                            }
                            else if (oync > 21)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("kaybettin!\n");
                                Console.ResetColor();
                                bakiye -= 10;
                            }
                            else if (oync < kru && kru <= 21)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("kaybettin!\n");
                                Console.ResetColor();
                                bakiye -= 10;
                            }

                            else if (oync > kru && oync <= 21)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("kazandın!\n");
                                Console.ResetColor();
                                bakiye += 30;
                            }
                            else if (kru > oync && kru > 21)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("kazandın!\n");
                                Console.ResetColor();
                                bakiye += 30;
                            }
                        }
                    }
                    if (bakiye<30)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("bütçe yeterli değil!");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
