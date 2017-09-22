using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace Shop
{
    public class Shop
    {
        List<Type> listOfItems;
            
        public string Greeting(char type)
        {
            string shopDisplay;
            if (type == 'c')
                shopDisplay = "Welcome to my consumable shop. What can I do for you?";
            else if (type == 'a')
                shopDisplay = "Welcome to my Armor shop. What do you need?";
            else if (type == 'w')
                shopDisplay = "Hello, traveler. My weapon shop is the finest in the land. What will it be?";
            else
                shopDisplay = "ERROR";
            return shopDisplay;
        }

        public string DisplayItems()
        {
            string display = "";
            foreach (Type t in listOfItems)
            {

            }
            return display;
        }

        public void PurchaseItem()
        {

        }

        public void SellItem()
        {

        }
    }
}
