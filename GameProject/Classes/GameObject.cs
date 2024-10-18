using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes
{
    public class GameObject
    {
        public int Id { get; }
        public string Name { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public GameObject(int id, string name, int x, int y)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
        }

        public void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


}
