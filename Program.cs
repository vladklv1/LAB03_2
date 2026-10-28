namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите вторую сторону: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите третью сторону: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Периметр: {P}");
            Console.WriteLine($"Площадь: {S:F2}");
        }
    }
}