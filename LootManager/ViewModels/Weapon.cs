using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LootManager.ViewModels
{
    class Weapon
    {
        // Items to add to Weapon
        // Critical Hit Range
        
        public string Name { get; set; }                    // Name of Weapon
        public int DamageOffset { get; set; }               // Minimum Damage
        public int AttacksPerTurn { get; set; }             // Actions Per Turn
        public int Value { get; set; }                      // Value
        public int UsableRange { get; set; }                // Range
        public int Size { get; set; }                       // Hands Required to Wield
        public double Accuracy { get; set; }                // Dificulty
        public double CritMultiplier { get; set; }          // Critical Hit multiplier
        public string DamageRange { get; set; }             // DamageOffset + DamageRange = Maximum Damage
        public string WeaponType { get; set; }              // Melee / Projectile
        public string DamageType { get; set; }              // Damage "Element"
        public string Manufacturer { get; set; }            // Weapon Manufacturer
        public string ModelType { get; set; }               // Pistol / Rifle / Plasma Sword / Baseball Bat
        public string Rarity { get; set; }                  // How unique this weapon is
        public Statistics Stats { get; set; }               // Stats
        public Image Picture { get; set; }                  // Image
        public List<Module> Modules { get; set; }           // Maximum Ability Slots

        // Accuracy Variables
        private const int MinimumAccuracy = 50;             // Actual Min is +5 more
        private const int MaximumAccuracy = 95;             // Max accuracy

        // DamageOffset Variables
        private const double DamageOffsetMultiplier = 1;    // Multiplied by level to determine damage, largest factor in determining damage
        private const int DamageOffsetMin = 3;              // Min random value added to damage minimum (DamageOffset)
        private const int DamageOffsetMax = 6;              // Max random value added to damage minimum (DamageOffset)

        // Rarity Variables
        private const int RarityMin = 0;
        private const int RarityMax = 100;
        private const int RarityCommonThreshhold = 65;
        private const int RarityUncommonThreshhold = 85;
        private const int RarityRareThreshhold = 95;

        private static Random random = new Random();

        public static string GenerateName()
        {
            string name = "";

            return name;
        }

        public static int GenerateValue()
        {
            int value = 0;

            return value;
        }

        public static double GenerateAccuracy()
        {
            int accuracy = random.Next(MinimumAccuracy, MaximumAccuracy + 1);
            int noise = 5 - (accuracy % 5);

            accuracy += noise;

            return accuracy;
        }

        public static string GenerateRarity()
        {
            string rarity = "";
            int raritylevel = random.Next(RarityMin, RarityMax);

            if (raritylevel < RarityCommonThreshhold)
            {
                rarity = "Common";
            }
            else if (raritylevel < RarityUncommonThreshhold)
            {
                rarity = "Uncommon";
            }
            else if (raritylevel < RarityRareThreshhold)
            {
                rarity = "Rare";
            }
            else
            {
                rarity = "Mythical";
            }

            return rarity;
        }

        public static string GenerateManufacturer()
        {
            string manufacturer = "";

            return manufacturer;
        }
    }
}
