using System;
using System.Drawing;
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
        public Bitmap Img { get; private set; }

        public Dictionary<int, string> itemList = new Dictionary<int, string>()
        {
            {1, "Small Shooter"},
            {2, "Small Potion"},
            {3, "Beam Knife"},
            {4, "Beam Axe"},
            {5, "Fancy Hat"},
            {6, "gold"}
        };

        public string name
        {
            get { return _name; }
        }

        public int ID
        {
            get { return _ID; }
        }
        
        public Item(int id, Bitmap img)
        {
            _name = itemList[id];
            _ID = id;
            Img = img;
        }
    }
}
