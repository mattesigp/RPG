using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    /// <summary>
    /// Armor class contains all information pertaining to pieces of armor
    /// </summary>
    public class Armor : Item
    {
        int defense;

        public Armor(string nam, string desc, char type, int priceOfItem)
        {
            name = nam;
            description = desc;
            itemType = type;
            price = priceOfItem;
        }

        public override string GetName() { return name; }
        public override string GetDescription() { return description; }
        public override int GetPrice() { return price; }
        public override char GetItemType() { return itemType;  }

        public override string ToString()
        {
            //not implemented yet
            return null;
        }
    }
}
