using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes
{
    public class Archer : Unit, IAttacker, IMoveable
    {
        public Archer(int id, string name, int x, int y, float hp)
            : base(id, name, x, y, hp)
        {
        }

        public void Attack(GameObject target)
        {
            if (target is Unit unit)
            {
                unit.ReceiveDamage(10); // Урон, наносимый лучником
                Console.WriteLine($"{Name} атаковал {unit.Name} с помощью лука.");
            }
            else
            {
                Console.WriteLine($"{Name} не может атаковать этот объект.");
            }
        }

        public void Move(int newX, int newY)
        {
            SetPosition(newX, newY);
            Console.WriteLine($"{Name} перемещен на ({newX}, {newY})");
        }

    }




}
