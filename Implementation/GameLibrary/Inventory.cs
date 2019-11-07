using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrary
{
    public class Inventory
    {
        public int[] inv = new int[25];

        public void addItem(int ID)
        {
            Item newItem = new Item(ID);
            int i = 0;
            while (this.inv[i] != 0)
            {
                i++;
            }
            inv[i] = ID;
        }
    }
}
