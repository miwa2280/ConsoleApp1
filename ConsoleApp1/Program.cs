namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет четных цифр");
            int numberTask1;
            while (true)
            {
                Console.Write("Введите четырехзначное число: ");
                if (int.TryParse(Console.ReadLine(), out numberTask1) && numberTask1 >= 1000 && numberTask1 <= 9999)
                {
                    break;
                }
                Console.WriteLine("Invalid input.");
            }
            int evenCount = 0;
            int tempNumber1 = numberTask1;

            while (tempNumber1 > 0)
            {
                int digit = tempNumber1 % 10;

                if (digit % 2 == 0)
                {
                    evenCount++;
                }
                tempNumber1 /= 10;
            }
            Console.WriteLine($"Количество четных цифр = {evenCount}");
            Console.WriteLine();
            Console.WriteLine("Серия одинаковых цифр подряд");
            int numberTask2;
            while (true)
            {
                Console.Write("Введите целое положительное число: ");
                if (int.TryParse(Console.ReadLine(), out numberTask2) && numberTask2 >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input.");
            }
            int maxSeries = 1;
            int currentSeries = 1;
            int tempNumber2 = numberTask2;
            if (tempNumber2 > 9)
            {
                int lastDigit = tempNumber2 % 10;
                tempNumber2 /= 10;

                while (tempNumber2 > 0)
                {
                    int currentDigit = tempNumber2 % 10;

                    if (currentDigit == lastDigit)
                    {
                        currentSeries++;
                    }
                    else
                    {
                        if (currentSeries > maxSeries)
                        {
                            maxSeries = currentSeries;
                        }
                        currentSeries = 1;
                    }

                    lastDigit = currentDigit;
                    tempNumber2 /= 10;
                }

                if (currentSeries > maxSeries)
                {
                    maxSeries = currentSeries;
                }
            }
            Console.WriteLine($"Максимальная серия одинаковых цифр = {maxSeries}");
            Console.WriteLine();
            Console.WriteLine("Проверка пароля");
            int correctPassword = 1234;
            int maxAttempts = 5;
            bool isAccessGranted = false;
            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"Введите пароль (Попытка {attempt} из {maxAttempts}): ");

                if (int.TryParse(Console.ReadLine(), out int inputPassword))
                {
                    if (inputPassword == correctPassword)
                    {
                        isAccessGranted = true;
                        break;
                    }
                }

                if (attempt < maxAttempts)
                {
                    Console.WriteLine("Пароль неверный попробуйте еще раз.");
                }
            }
            string resultMessage = isAccessGranted ? "Добро пожаловать!" : "Доступ запрещен.";
            Console.WriteLine(resultMessage);
        }
    }
}
