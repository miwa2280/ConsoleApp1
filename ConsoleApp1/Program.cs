namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер ставки ($5 - $100, шаг $5): ");
            int bet = Convert.ToInt32(Console.ReadLine());

            if (bet < 5 || bet > 100 || bet % 5 != 0)
            {
                Console.WriteLine("Ошибка: некорректная ставка!");
            }
            else
            {
                Random random = new Random();
                int num1 = random.Next(1, 10);
                int num2 = random.Next(1, 10);
                int num3 = random.Next(1, 10);
                Console.WriteLine("\nБарабан:");
                Console.WriteLine($"{num1} {num2} {num3}\n");
                double coefficient = 0;
                if (num1 == num2 && num2 == num3)
                {
                    switch (num1)
                    {
                        case 1: coefficient = 10 * 1.5; break;
                        case 2: coefficient = 20 * 1.5; break;
                        case 3: coefficient = 30 * 1.5; break;
                        case 4: coefficient = 40 * 1.5; break;
                        case 5: coefficient = 50 * 1.5; break;
                        case 6: coefficient = 60 * 1.5; break;
                        case 7: coefficient = 150 * 1.5; break; 
                        case 8: coefficient = 80 * 1.5; break;
                        case 9: coefficient = 90 * 1.5; break;
                    }
                }
                else if (num1 == num2)
                {
                    switch (num1)
                    {
                        case 1: coefficient = 1 * 1.25; break;
                        case 2: coefficient = 2 * 1.25; break;
                        case 3: coefficient = 3 * 1.25; break;
                        case 4: coefficient = 4 * 1.25; break;
                        case 5: coefficient = 5 * 1.25; break;
                        case 6: coefficient = 6 * 1.25; break;
                        case 7: coefficient = 15 * 1.25; break; 
                        case 8: coefficient = 8 * 1.25; break;
                        case 9: coefficient = 9 * 1.25; break;
                    }
                }

                else if (num1 == 7 || num2 == 7 || num3 == 7)
                {
                    coefficient = 1.6;
                }

                else if (num1 == 9 || num2 == 9 || num3 == 9)
                {
                    coefficient = 1.35;
                }
                if (coefficient > 0)
                {
                    double winAmount = bet * coefficient;
                    Console.WriteLine($"Поздравляем! Вы выиграли: {winAmount}$");
                }
                else
                {
                    Console.WriteLine("К сожалению, вы проиграли.");
                }
            }
        }
    }
}
