namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.WriteLine("Birinci Sayıyı Giriniz  ");
            int sayi1 = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("İşlem Seçiniz   (+) (-) (*) (/) (%)");
            string islem = (Console.ReadLine()); 
            
            Console.WriteLine("İkinci Sayıyı Giriniz  ");
            int sayi = int.Parse(Console.ReadLine());


            switch (islem)
            {
                case "+":
                    Console.WriteLine(sayi1 + sayi);
                    break;

                case "-":
                    Console.WriteLine(sayi1 - sayi);
                    break;
                case "*":
                    Console.WriteLine(sayi1 * sayi);
                    break;
            }

        }
    }
}