namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Миша";
            int age = 15;
            string height = "1.78 м"; 
            char favoriteLetter = 'М';
            bool likesProgramming = true;
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Рост: " + height);
            Console.WriteLine("Любимая буква: " + favoriteLetter);
            Console.WriteLine("Любит ли программирование: " + (likesProgramming ? "Да" : "Нет"));
            Console.ReadLine();
        }
    }
}
