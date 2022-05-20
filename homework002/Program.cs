using System;

namespace homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string zodiacSigh;
            string job;
            Console.Write("Как вас зовут?");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет?");
            age = Console.ReadLine();
            Console.Write("Кто вы по гороскопу?");
            zodiacSigh = Console.ReadLine();
            Console.Write("Где вы работаете?");
            job = Console.ReadLine();
            Console.WriteLine("Вас зовут - " + name + "вам" + age + "лет" + "по гороскопу вы " + zodiacSigh + "вы работаете" + job);
        }
    }
}
