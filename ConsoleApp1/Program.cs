namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 45;
            Console.WriteLine(x);
            Console.Clear();

            string t = "";
            t = x.ToString();   
            Console.WriteLine(t);

            int y = int.Parse(t);
            Console.WriteLine(y);
            double a = double.Parse(t);
            Console.WriteLine(a);

            Console.WriteLine(a.GetType());
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(float));

            Console.WriteLine("Minimalna wartość: " + float.MinValue, ", maksymalna wartość: " + float.MaxValue);

            Console.WriteLine(short.MinValue); //-32768
            Console.WriteLine(short.MaxValue); //32767

            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int64.MinValue);

            Console.WriteLine("Zapis w");
            Console.WriteLine(" jednej linii");
            Console.WriteLine("\nNowa linia" + "\n\tWcięcie w nowej linii");

            int b = 10;
            Console.WriteLine(b.ToString("C")); // 10,00 zł
            Console.WriteLine(b.ToString("C3")); // 10,000 zł
            Console.WriteLine(b.ToString("C3").Replace(',', ',')); // 10,000 zł
            Console.WriteLine(b.ToString("0000")); // 0010

            Console.WriteLine(b.ToString("p")); // 1 000,00%
            Console.WriteLine(b.ToString("X")); // A
            Console.WriteLine(b.ToString("N")); // 10,00
            Console.Clear();

            double i = 10;
            double j = 20;
            Console.WriteLine((i+j).ToString("00.00")); // 30,00
            Console.WriteLine((i+j).ToString("00.000")); // 30,000
            Console.WriteLine((i+j).ToString("0000.000")); // 0030,000

            Console.WriteLine((i+j).ToString("###.##")); // 30

            Console.WriteLine("Podaj imię:");
            string? _firtsName = Console.ReadLine();
            Console.WriteLine("Twoje imię: " + _firtsName);

            Console.WriteLine("Podaj nazwisko:");
            string? _lastName = Console.ReadLine();

            //interpolacja
            Console.WriteLine("Imie: {1}, nazwisko: {0}", _lastName, _firtsName);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.CursorTop = 2;
            Console.CursorLeft = 30;
            Console.WriteLine("C#");

            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Liczba {number} jest parzysta");
            } else
            {
                Console.WriteLine($"Liczba {number} jest nie parzysta");
            }
        }
    }
}