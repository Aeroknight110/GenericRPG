using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Item
    {
        public string name;
        public int ID;
        public string Img;
        public Dictionary<int, string> nameList = new Dictionary<int, string>()
        {
            {1, "Small Shooter"},
            {2, "Small Potion"},
            {3, "Beam Knife"},
            {4, "Beam Axe"},
            {5, "Fancy Hat"},
            {6, "gold"}
        };

        public Dictionary<int, string> descList = new Dictionary<int, string>()
        {
            {1, "Better than a fist. Makes a 'pew pew' noise.\nDamage Multiplier: 1.0" },
            {2, "Tastes..interesting.\nHeals 25 Hit Points." },
            {3, "A knife made of plasma. Ouch.\nDamage Multiplier: 0.6\nThis weapon can critically hit." },
            {4, "An axe that is heavy. But why?\nDamage Multiplier: 1.4" },
            {5, "Only true gentle-people can adorn this hat." }
        };

        
        public Item(int id)
        {
            name = nameList[id];
            ID = id;
        }
    }
}
