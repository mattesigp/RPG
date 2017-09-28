using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace Shop
{
    /// <summary>
    /// Shop used to store information about items stored in a shop
    /// </summary>
    public class Shop 
    {
        List<object> listOfItems;
        char type;

        public Shop(List<object> list, char typeShop)
        {
            listOfItems = list;
            type = typeShop;
        }    
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

        /// <summary>
        /// Gets all items located in the shop
        /// </summary>
        /// <returns>All items in shop in a readable format</returns>
        public string DisplayItems()
        {
            string display = "";
           
            return display;
        }
//TODO: add
        public void PurchaseItem()
        {
            //add item to list
            
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void SellItem()
        {
            //remove item from list
        }


        /// <summary>
        /// This method is not complete. Requires outputting all data with different types for each shop list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            if (listOfItems.GetType() == typeof(Armor))
            {
                return listOfItems.ToString();
            }
            else if (listOfItems.GetType() == typeof(Weapon))
            {
                return listOfItems.ToString();
            }
            else if(listOfItems.GetType() == typeof(Consumables))
            {
                return listOfItems.ToString();
            }
            else
            {
                return null;
            }
            //return outputString;
        }
    }
}
