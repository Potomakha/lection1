using System;

namespace lection1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Oleh";
            string SName = "Potomakha";
            int Age = 22;
            int ageTo = 40;
            Console.WriteLine($"Меня зовут {Name} {SName}, мой возраст {Age}. До {ageTo} мне осталось {ageTo - Age} ", Name, SName, Age, ageTo);
            Console.ReadKey();
        }
    }
}
