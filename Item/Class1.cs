using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Items
{
    #region Armor
    [TestClass]
    public class ArmorUnitTests 
    {
        Armor armor = new Armor("Test Armor", "Used for testing", 'h', 10);
    }
    #endregion

    #region Weapon
    [TestClass]
    public class WeaponUnitTests
    {

    }
    #endregion
}
