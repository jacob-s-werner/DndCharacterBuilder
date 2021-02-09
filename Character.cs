using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterBuilder
{
    public class Character
    {
        public string name;
        public CharacterClass characterClass;
        public Race race;
        public int level, xp, downtime;

        public int strength, intelligence, dexterity, wisdom, constitution, charisma;
        public int strengthModifier, intelligenceModifier, dexterityModifier, wisdomModifier, constitutionModifier, charismaModifier;
        public int savingThrows, athletics, carryingCapacity, jumpDistanceForward, jumpDistanceUpward;
        public int arcana, history, investigation, nature, religion;
        public int acrobatics, sleightOfHand, stealth;
        public int animalHandling, insight, medicine, perception, survival;
        public int timeHoldingBreath, daysWithoutFood;
        public int deception, intimidation, performance, persuasion;

        public int baseArmorClass, currentArmorClass, initiative, speed, proficiencyBonus;
        public int currentHP, maximumHP, temporaryHP;
        public string hitDiceUsed, totalHitDice;
        public int deathSaves = 3, deathSavesFailed, deathSavesSucceeded;

        
        public string weaponProficiencies, armorProficiencies; //make these their own class and lists
        public string favoriteWeaponAttacks, favoriteSpellAttacks; //make these lists and own class
        

        public int spellsKnown, spellsPrepared, cantripsKnown;
        public int attackModifier, spellSaveDC;

        public int lvl1SpellSlots, lvl1SpellSlotsused; //make all these into the spellBook, up to lvl 9

        public string additionalProficiencies, knownLanguages; //make these lists, and own class

        public string traits, abilities, feats; // make these part of list and class
        public Character()
        {

        }
    }
}
