using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    /// <summary>
    /// Abstract class that contains elements for every item found in the game.
    /// All items will have a name, description, item type (Weapon, Armor, consumable, etc.) and price.
    /// </summary>
    public abstract class Item
    {
        public static string name;
        public static string description;
        public static char itemType;
        public static int price;

        /*
        public static int currentDurability;
        public static int durability;
        public static int plusStr;
        public static int plusDex;
        public static int plusVitality;
        public static int plusSpeed;
        int plusHealth;
        int plusMana;
        */

        /// <summary>
        /// Abstract method for getting name
        /// </summary>
        /// <returns></returns>
        public abstract string GetName();
        public abstract string GetDescription();
        public abstract char GetItemType();
        public abstract int GetPrice();     
    }
}
