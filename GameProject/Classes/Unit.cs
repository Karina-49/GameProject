using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes
{
    public abstract class Unit : GameObject
    {
        public float Hp { get; private set; }

        public Unit(int id, string name, int x, int y, float hp) : base(id, name, x, y)
        {
            Hp = hp;
        }

        public bool IsAlive()
        {
            return Hp > 0;
        }

        public void ReceiveDamage(float damage)
        {
            Hp -= damage;
            if (Hp < 0) Hp = 0;
        }
    }

}
