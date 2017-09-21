using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Armor : Item
    {
        int defense;     

        override public string GetName() { return name; }
        override public string GetDescription() { return description; }
        override public int GetPrice() { return price; }
        override public char GetItemType() { return itemType;  }
    }
}
