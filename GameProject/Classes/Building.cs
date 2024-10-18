using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes
{
    public class Building : GameObject
    {
        public bool IsBuilt { get; }

        public Building(int id, string name, int x, int y, bool isBuilt) : base(id, name, x, y)
        {
            IsBuilt = isBuilt;
        }
    }


}
