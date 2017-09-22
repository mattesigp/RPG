using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    /// <summary>
    /// Not implemented yet, must add stats to items before making changes.
    /// </summary>
    public class Consumables : Item
    {
        public Consumables(string nam, string desc, char type, int priceOfItem)
        {

        }

        public override char GetItemType()
        {
            throw new NotImplementedException();
        }
        public override string GetName()
        {
            throw new NotImplementedException();
        }
        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public override int GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
