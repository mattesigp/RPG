using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace Character
{
    /// <summary>
    /// Character class used to store data about all characters (player and non player character)
    /// </summary>
    public class Character
    {
        public int level { get; private set; }
        public int experience { get; private set; }
        public int strength { get; private set; }
        public int dexterity { get; private set; }
        public int vitality { get; private set; }
        public int speed { get; private set; }
        public int maxHealth { get; private set; }
        public int currentHealth { get; private set; }
        public int maxMana { get; private set; }
        public int currentMana { get; private set; }

        bool isMagicUser;
        List<Armor> armor = null;
        Weapon mainhand = null;
        Type offhand = null;

        /// <summary>
        /// Constructor for character data. Requires any number of parameters from 0 to 9
        /// </summary>
        /// <param name="lvl">Level of character</param>
        /// <param name="exp">Experience value of character</param>
        /// <param name="str">Strength value of character</param>
        /// <param name="dex">Dexterity value of character</param>
        /// <param name="vit">Vitality value of character</param>
        /// <param name="spd">Speed value of character</param>
        /// <param name="h">Health of character</param>
        /// <param name="m">Mana of Character</param>
        /// <param name="mag">Does character use magic or not</param>
        public Character(int lvl = 1, int exp = 0, int str = 1, int dex = 1, int vit = 1, int spd = 1, int h = 1, int m = 0, bool mag = false)
        {
            level = lvl;
            experience = exp;
            strength = str;
            dexterity = dex;
            vitality = vit;
            speed = spd;
            maxHealth = h;
            currentHealth = h;
            maxMana = m;
            currentMana = m;
            isMagicUser = mag;           
        }


        /// <summary>
        /// Checks to see if character is currently alive
        /// </summary>
        /// <returns>True, if health greater 0. False if health equal to or less than 0</returns>
        public bool IsCharacterAlive()
        {
            if(currentHealth > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Randomizer not implemented
        /// Does the calculation for level up (Randomized leveling)
        /// </summary>
        /// <param name="r">Accepts random for testing</param>
        /// <param name="isHealthGained"> True, to set current health and mana to max at level gain; false, to have no health or mana added</param>
        /// <returns>0, if successful. 1, if fails.</returns>
        public int LevelUp(Random r, bool isHealthGained = false)
        {
            try
            {
                /*
                 * Randomized leveling here 
                 */
                level+=1;
                strength++;
                dexterity++;
                vitality++;
                speed++;
                maxHealth += 10;              
                if (isMagicUser)
                {
                    maxMana += 10;                    
                }
                if (isHealthGained)
                {
                    currentHealth = maxHealth;
                    currentMana = maxMana;
                }
            }
            catch (Exception)
            {
                return 1;
            }
            return 0;
        }
    }   
}
