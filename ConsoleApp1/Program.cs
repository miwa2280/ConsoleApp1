namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма отрицательных элементов");

            int sizeTask1 = 10;
            int[] array1 = new int[sizeTask1];

            Console.WriteLine("Массив:");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Random.Shared.Next(-20, 21);
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();

            int sumNegative = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < 0)
                {
                    sumNegative += array1[i];
                }
            }

            Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");
            Console.WriteLine();

            Console.WriteLine("Наименьший четный элемент");

            int sizeTask2 = 10;
            int[] array2 = new int[sizeTask2];

            Console.WriteLine("Массив:");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Random.Shared.Next(-20, 21);
                Console.Write($"{array2[i]} ");
            }
            Console.WriteLine();

            int minEven = 0;
            bool hasEven = false;

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] % 2 == 0)
                {
                    if (!hasEven || array2[i] < minEven)
                    {
                        minEven = array2[i];
                        hasEven = true;
                    }
                }
            }

            if (hasEven)
            {
                Console.WriteLine($"Наименьший четный элемент = {minEven}");
            }
            else
            {
                Console.WriteLine("Четных элементов нет.");
                Console.WriteLine($"Первый элемент массива = {array2[0]}");
            }
            Console.WriteLine();

            Console.WriteLine("Мин, макс и сумма их номеров");
            int sizeTask3 = 10;
            int[] array3 = new int[sizeTask3];
            Console.WriteLine("Массив:");
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = Random.Shared.Next(-20, 21);
                Console.Write($"{array3[i]} ");
            }
            Console.WriteLine();

            int minElement = array3[0];
            int minIndex = 0;

            int maxElement = array3[0];
            int maxIndex = 0;

            for (int i = 1; i < array3.Length; i++)
            {
                if (array3[i] < minElement)
                {
                    minElement = array3[i];
                    minIndex = i;
                }

                if (array3[i] > maxElement)
                {
                    maxElement = array3[i];
                    maxIndex = i;
                }
            }

            int indexSum = minIndex + maxIndex;

            Console.WriteLine($"Минимальный элемент = {minElement}, номер = {minIndex}");
            Console.WriteLine($"Максимальный элемент = {maxElement}, номер = {maxIndex}");
            Console.WriteLine($"Сумма номеров = {indexSum}");

            Console.ReadKey();
        }
    }
}