﻿namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.WriteLine("Birinci Sayıyı Giriniz  ");
            double sayi1 = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("İşlem Seçiniz   (+) (-) (*) (/) (%)");
            string islem = (Console.ReadLine()); 
            
            Console.WriteLine("İkinci Sayıyı Giriniz  ");
            double sayi = int.Parse(Console.ReadLine());

            double sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc= sayi1 + sayi;
                    break;

                case "-":
                    sonuc = sayi1 - sayi;
                    break;
                case "*":
                    sonuc = sayi1 * sayi;
                    break;
                case "/":
                    sonuc = sayi1 / sayi;
                    break;
                case "%":
                    sonuc = sayi1 % sayi;
                    break;
            }
            Console.WriteLine(sayi1 + " " + islem + " " + sayi + " " + " = " + sonuc);

        }
    }
}