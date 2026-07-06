namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите значение d: ");
            int d = int.Parse(Console.ReadLine());

            double result = (((double)a * b / 2) + c * d) / 3;

            Console.WriteLine($"Результат = {result}");

            Console.ReadLine();
        }
    }
}
