
using System;
using GameProject.Classes;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов Archer и Fort
            Archer archer = new Archer(1, "Лучник", 0, 0, 100.0f);
            Fort fort = new Fort(2, "Крепость", 5, 5);

            // Демонстрация атаки
            archer.Attack(fort);

            // Перемещение лучника
            archer.Move(2, 2);

            // Проверка состояния крепости
            Console.WriteLine($"{fort.Name} находится на ({fort.X}, {fort.Y}).");

            Console.ReadLine();
        }
    }


}

