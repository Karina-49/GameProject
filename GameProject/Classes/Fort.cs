using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes
{
    public class Fort : Building, IAttacker
    {
        public Fort(int id, string name, int x, int y) : base(id, name, x, y, true) // Добавлено значение isBuilt
        {
            // Здесь больше не нужно устанавливать IsBuilt, так как это сделано в базовом классе
        }

        public void Attack(GameObject target)
        {
            if (target is Unit unit)
            {
                unit.ReceiveDamage(20);
                Console.WriteLine($"{Name} атаковал {unit.Name} издалека.");
            }
            else
            {
                Console.WriteLine($"{Name} не может атаковать этот объект.");
            }
        }

        public bool IsBuilt { get; set; }
    }




}
