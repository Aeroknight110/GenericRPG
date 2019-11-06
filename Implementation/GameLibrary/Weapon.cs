using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Weapon : Item
    {
        public double damMod;
        public int wID;
        public Dictionary<int, double> modList = new Dictionary<int, double>()
        {
            {1, 1.0},
            {3, .6},
            {4, 1.4}
        };

        public Weapon(int id) : base(id)
        {
            wID = id;
            damMod = modList[id];
            name = nameList[id];
        }
    }
}
