namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.WriteLine("Birinci Sayıyı Giriniz  ");
            int sayi1 = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("İşlem Seçiniz   (+) (-) (*) (/) ");
            int islem = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("İkinci Sayıyı Giriniz  ");
            int sayi = int.Parse(Console.ReadLine());


        }
    }
}