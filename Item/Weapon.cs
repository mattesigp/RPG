using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    /// <summary>
    /// Weapon class used to store data about an weapon
    /// </summary>
    public class Weapon : Item
    {
        public int minDamage;
        public int maxDamage;            
        //possibly add more stat increases like item enchancements and such.

        /// <summary>
        /// Weapon class constructor storing all information for weapons
        /// </summary>
        /// <param name="nam">Weapon's Name</param>
        /// <param name="desc">Description of Weapon</param>
        /// <param name="item">Type of Weapon ('1' for one-handed, '2' for two-handed)</param>
        /// <param name="priceOfItem">Price of Weapon</param>
        /// <param name="min">Minimum attack value of weapon</param>
        /// <param name="max">Maximum attack value of weapon</param>
        public Weapon(string nam, string desc, char item, int priceOfItem, int min, int max )
        {
            name = nam;
            description = desc;
            itemType = item;
            price = priceOfItem;
            minDamage = min;
            maxDamage = max;
        }

        override public string GetName() { return name; }
        override public string GetDescription() { return description; }
        override public int GetPrice() { return price; }
        override public char GetItemType() { return itemType; }

    }
}
