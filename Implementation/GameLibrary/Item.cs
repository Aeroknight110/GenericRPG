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
        public Dictionary<int, string> nameList = new Dictionary<int, string>()
        {
            {1, "Small Shooter"},
            {2, "Small Potion"},
            {3, "Beam Knife"},
            {4, "Beam Axe"},
            {5, "Fancy Hat"}
        };
        
        public Item(int id)
        {
            name = nameList[id];
            ID = id;
        }
    }
}
