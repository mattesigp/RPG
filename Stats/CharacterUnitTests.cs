using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character
{   
    [TestClass]
    public class CharacterUnitTests
    {
        /// <summary>
        /// Tests to see if initialized character is alive
        /// This should always be the case.
        /// </summary>
        [TestMethod]
        public void IsCharacterAliveTest()
        {
            Character c1 = new Character("Player 1", 1, 0, 2, 1, 1, 2, 4, 0, false);
            Assert.IsTrue(c1.IsCharacterAlive());    
        }

        /// <summary>
        /// Tests to see if initialized character is dead
        /// This should always be the case.
        /// </summary>
        [TestMethod]
        public void IsCharacterDeadTest()
        {
            Character c1 = new Character("Player 1", 1, 0, 2, 1, 1, 2, 0, 0, false);
            Assert.IsFalse(c1.IsCharacterAlive());
        }

        /// <summary>
        /// Tests LevelUp method to make sure character level and stats change.
        /// This test will have to be updated when the level stat randomizer is added
        /// </summary>
        [TestMethod]
        public void LevelUpNoLevelingHealthGainTest()
        {
            Random r = new Random();
            Character c1 = new Character("Player 1", 1, 0, 1, 1, 1, 1, 1, 0, false);
            c1.LevelUp(r);
            Assert.IsTrue(c1.level == 2);
            Assert.IsTrue(c1.experience == 0);
            Assert.IsTrue(c1.strength == 2);
            Assert.IsTrue(c1.dexterity == 2);
            Assert.IsTrue(c1.vitality == 2);
            Assert.IsTrue(c1.speed == 2);
            Assert.IsTrue(c1.maxMana == 0);
            Assert.IsTrue(c1.maxHealth == 11);
        }
    }
}
