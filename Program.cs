using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class Hastane
        {
            public void Başlangıç()
            {
              
            a:
                Console.WriteLine("-----------Hastane Kayıt-----------");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-       (1)Personel Girişi        -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-       (2)Hasta Girişi           -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-----------------------------------");
           
            }
            
            
        }
        class Personel : Hastane
        {
            public int maaş = 0;
            public int izinler = 0;
            public string[] Perskayıtlar = { "janset", "ahmet", "esma", "sefa", "tolga"};
            public void persnl()
            {
                Console.Clear();
                a:
                Console.Clear();
                Console.WriteLine("-----------Hastane Kayıt-----------");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("-         Adınızı Girin;          -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-----------------------------------");
                string ad = Convert.ToString(Console.ReadLine());
                if (Perskayıtlar[0] == ad||Perskayıtlar[1] == ad||Perskayıtlar[2] == ad || Perskayıtlar[3] == ad || Perskayıtlar[4] == ad)
                {
                    Console.Clear();
                    b:
                    Console.WriteLine("-------Hoşgeldiniz "+ad+"-----------");
                    Console.WriteLine("-                                  -");
                    Console.WriteLine("-      (1)Hastalar                 -");
                    Console.WriteLine("------------------------------------");
                    int seçim = Convert.ToInt32(Console.ReadLine());
                    if (seçim == 1)
                    {
                        Console.Clear();
                        Random rnd = new Random();
                        int sayi = rnd.Next(3, 10);
                       
               
                       for (int i = 0; i <= sayi; i++)
                        {
                        c:
                            Console.Clear();
                            int sayı = sayi--;
                            Console.WriteLine(sayı + " Hasta Bakımınız Kaldı (Devam)");
                        

                            string seçim1 = Convert.ToString(Console.ReadLine());

                            if (seçim1 != "Devam")
                            {
                                Console.WriteLine("Yanlış tuşlama");
                                goto c;
                            }
                        }
                        Console.Clear();
                        int maaş = sayi * 120;
                        Console.WriteLine("Günlük Maaşınız="+maaş);
                        System.Threading.Thread.Sleep(3000);
                        d:
                        Console.Clear();
                       
                        Console.WriteLine("Geri Dönmek için (Evet) Program Kapanması için (Kapat)");
                        string seçim2 = Convert.ToString(Console.ReadLine());
                        if (seçim2=="Evet")
                        {
                            Console.Clear();
                            Hastane has = new Hasta();
                            has.Başlangıç();
                        }
                        else if(seçim2=="Kapat")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Yanlış Giriş...");
                            System.Threading.Thread.Sleep(1300);
                            goto d;
                        }
                       
                              

                       
                    }
                 
                    else
                    {
                        Console.WriteLine("Yanlış Giriş...");
                        System.Threading.Thread.Sleep(1300);
                        goto b;
                    }

                }
              

                else
                {
                    Console.WriteLine("Yanlış Giriş...");
                    System.Threading.Thread.Sleep(1300);
                    goto a;
                }

            }
        }
        class Hasta : Hastane
        {
            int ödenentutar = 0;
            int hastasıra = 0;
            public string[] HastaKayıtlar = { "Enes", "Sude", "Beyza", "İbrahim" };
            
            public void hastabaşlangıç()
            {
                
                Console.Clear();
            a:
                Console.Clear();
                Console.WriteLine("-----------Hastane Kayıt-----------");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("-         Adınızı Girin;          -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-                                 -");
                Console.WriteLine("-----------------------------------");
                string ad = Convert.ToString(Console.ReadLine());
                if (HastaKayıtlar[0] == ad || HastaKayıtlar[1] == ad || HastaKayıtlar[2] == ad || HastaKayıtlar[3] == ad)
                {
                    Console.Clear();
                    Console.WriteLine("Sıra Bekleniyor..");
                  
                    Random rnd = new Random();
                    int sayi = rnd.Next(1, 5);
                    Random ss = new Random();
                    int ücret = ss.Next(50, 110);
                    if (sayi == 1)
                    {
                        Console.WriteLine("Doktorunuz Janset muayeneyi tamamladı.Ücertiniz:" + ücret+" ...");
                        System.Threading.Thread.Sleep(1300);
                        Console.Clear();
                        Console.WriteLine("Ücret ödendi teşekkür ederiz!");
                        System.Threading.Thread.Sleep(1300);
                        Environment.Exit(0);
                    }
                    else if (sayi == 2)
                    {
                        Console.WriteLine("Doktorunuz Ahmet muayeneyi tamamladı.Ücertiniz:" + ücret + " ...");
                        System.Threading.Thread.Sleep(1300);
                        Console.Clear();
                        Console.WriteLine("Ücret ödendi teşekkür ederiz!");
                        System.Threading.Thread.Sleep(1300);
                        Environment.Exit(0);
                    }
                    else if (sayi == 3)
                    {
                        Console.WriteLine("Doktorunuz Esma muayeneyi tamamladı.Ücertiniz:" + ücret +" ...");
                        System.Threading.Thread.Sleep(1300);
                        Console.Clear();
                        Console.WriteLine("Ücret ödendi teşekkür ederiz!");
                        System.Threading.Thread.Sleep(1300);
                        Environment.Exit(0);
                    }
                    else if (sayi == 4)
                    {
                        Console.WriteLine("Doktorunuz Sefa muayeneyi tamamladı.Ücertiniz:" + ücret  + " ...");
                        System.Threading.Thread.Sleep(1300);
                        Console.Clear();
                        Console.WriteLine("Ücret ödendi teşekkür ederiz!");
                        System.Threading.Thread.Sleep(1300);
                        Environment.Exit(0);
                    }
                    else if (sayi == 5)
                    {
                        Console.WriteLine("Doktorunuz Tolga muayeneyi tamamladı.Ücertiniz:" + ücret + " ...");
                        System.Threading.Thread.Sleep(1300);
                        Console.Clear();
                        Console.WriteLine("Ücret ödendi teşekkür ederiz!");
                        System.Threading.Thread.Sleep(1300);
                        Environment.Exit(0);
                    }


                }
                else 
                {
                    c:
                    Console.Clear();
                    Console.WriteLine("-------------Hoşgeldiniz ---------------");
                    Console.WriteLine("-     Kaydedilmiş Girişiniz Yok        -");
                    Console.WriteLine("-     Kaydolmak için(1)                -");
                    Console.WriteLine("-     Çıkış(2)                         -");
                    Console.WriteLine("----------------------------------------");
                    int tercih = Convert.ToInt32(Console.ReadLine());
                    if (tercih == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Bekleyin..");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        Random rnd = new Random();
                        int sayi = rnd.Next(1, 9);
                                                
                        Console.WriteLine(sayi +" Gün sonra randevu alındı..");
                     
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("İyi günler.");
                        System.Threading.Thread.Sleep(1300);
                        Environment.Exit(0);


                    }
                    else if (tercih == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Giriş...");
                        System.Threading.Thread.Sleep(1300);
                        goto c;
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            Hastane has = new Hasta();
            Personel pers = new Personel();
            Hasta hasta1 = new Hasta();
        
            Console.ForegroundColor = ConsoleColor.Red;
            has.Başlangıç();
            int seçenek = Convert.ToInt32(Console.ReadLine());
            if (seçenek == 1)
            {
                pers.persnl();
               
            }
            else if (seçenek == 2)
            {
                hasta1.hastabaşlangıç();
            }
            else
            {
                Console.WriteLine("Doğru Tuşlama Yapınız");
                System.Threading.Thread.Sleep(1300);
                has.Başlangıç();

            }
            Hasta hasta = new Hasta();

            Console.ReadKey();
            
          
        }
    }
}
