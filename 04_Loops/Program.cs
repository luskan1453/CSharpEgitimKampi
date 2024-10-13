﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // For Döngüsünün "3" parametresi vardır. //  x: Başlangıç / y: Bitiş /  z: Artış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Sinan");
            //}

            //for (int i = 1; i <= 20; i++)
            //{ 
            //Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{

            //    Console.WriteLine(i);
            //}

            //Console.Write("Yazılması gereken adedi girin:");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.Write("Sinan");
            //}


            #endregion
            #region For Döngüleri ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //   if (i% 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++) 
            //{
            //    totalValue += i;

            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i <= 20; i++) 
            //{
            //    if (i % 2 == 0)                 
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i<=50; i++) 
            //{
            //    if (i % 7 == 0) 
            //    {
            //        count ++;

            //    }

            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(count);

            //// 1 - 2 - 4 - 8 - 16 Bakteri Bölünmesi

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2; 
            //    Console.WriteLine(i + " .Saat Sonunda: " + bacterium);            
            //}
            //Console.Read();
            #endregion
            #region While Döngüsü

            // While (Şart) Gerektirir, işlem Sağlandığı Sürece

            //int i = 1;

            //while (i <= 10) 
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;            

            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //Console.Read();
            #endregion
            #region Örnek Sınav Sorusu

            //// Klavyeden Girilen 3 Basamaklı sayının basamaklarını toplayan kodu yazınız

            //Console.Write("Üç Basamaklı Bir Sayı Girin: " );
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //hundreds = number / 100;
            //Console.WriteLine("Yüzler Basamağı: " + hundreds);
            //tens = (number % 100) / 10;
            //Console.WriteLine("Onlar Basamağı: " + tens);
            //ones = number % 10;
            //Console.WriteLine("Birler Basamağı: " + ones);

            //sum = hundreds + tens + ones;
            //Console.WriteLine("Basamaklar Toplamı=  " + sum);

            //Console.Read();
            #endregion



        }
    }
}
