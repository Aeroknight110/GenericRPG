using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Item
    {
        private string _name;
        private int _ID;

        public Dictionary<int, string> itemList = new Dictionary<int, string>()
        {
            {0, "Small Shooter"},
            {1, "Small Potion"},
            {2, "Beam Knife"},
            {3, "Beam Axe"},
            {4, "Fancy Hat"}
        };

        public string name
        {
            get { return _name; }
        }

        public int ID
        {
            get { return _ID; }
        }
        
        public Item(int id)
        {
            _name = itemList[id];
            _ID = id;
        }
    }
}
