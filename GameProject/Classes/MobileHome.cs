using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes
{
    public class MobileHome : Building, IMoveable
    {
        public MobileHome(int id, string name, int x, int y, bool isBuilt) : base(id, name, x, y, isBuilt) { }

        public void Move(int x, int y)
        {
            if (IsBuilt)
            {
                SetPosition(x, y);
                Console.WriteLine($"{Name} переместился на позицию ({x}, {y}).");
            }
        }
    }

}
