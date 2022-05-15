using System;
using System.Collections.Generic;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            //soru3();
            //soru4();

        }

        /*1 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
        public static void soru1()
        {
            int sayi;
            Console.WriteLine("Bir n sayısı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                int[] sayilar = new int[sayi];
                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.WriteLine("Herhangi bir sayı giriniz: ");
                    int temp;
                    temp = Convert.ToInt32(Console.ReadLine());
                    sayilar[i] = temp;
                }
                Console.WriteLine("Girdiğiniz sayılardan çift olanlar ekrana yazdırılıyor...");
                foreach (int num in sayilar)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı giridiniz!");
            }
        }
        /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
        public static void soru2()
        {
            int sayi1, sayi2;
            Console.WriteLine("N sayısını giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M sayısını giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[sayi1];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Herhangi bir sayı giriniz: ");
                int temp;
                temp = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = temp;
            }
            Console.WriteLine("Girdiğiniz sayılardan M e tam bölünenler ekrana yazdırılıyor");
            foreach (int num in sayilar)
            {
                if (num == sayi2)
                {
                    Console.WriteLine(num);
                }
                else if (num % sayi2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
        /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

        public static void soru3()
        {
            int sayi;
            Console.WriteLine("Bir n sayısı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            List<string> kelimeler = new List<string>();
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Kelime giriniz: ");
                string kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }
            kelimeler.Reverse();
            foreach (string item in kelimeler)
            {
                Console.WriteLine(item);
            }

        }
        /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
        public static void soru4()
        {

            string sentence = String.Empty;
            string[] words;

            while (true)
            {
                try
                {

                    Console.WriteLine("Lütfen bir cümle girin");
                    sentence = Console.ReadLine().Trim();
                    words = sentence.Split(' ');
                    break;
                }

                catch
                {
                    Console.WriteLine("Yanlış değer girdiniz!");
                }
            }

            int wordCount = words.Length;
            int letterCount = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if ((char.ToLower(sentence[i]) >= 'a' && char.ToLower(sentence[i]) <= 'z') || char.ToLower(sentence[i]) == 'ç' || char.ToLower(sentence[i]) == 'ğ' || sentence[i] == 'ı' || sentence[i] == 'İ' || char.ToLower(sentence[i]) == 'ö' || char.ToLower(sentence[i]) == 'ü' || char.ToLower(sentence[i]) == 'ş')
                {
                    letterCount++;
                }
            }
            Console.WriteLine("Toplam kelime: " + wordCount);
            Console.WriteLine("Toplam harf: " + letterCount);
        }

    }
}
