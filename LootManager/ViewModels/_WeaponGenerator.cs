using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LootManager.ViewModels
{
    class _WeaponGenerator
    {
        /*
         * Generates one random weapon of a specified type
         * type = Ranged => ProjectileWeapon
         * type = Melee  => MeleeWeapon
         * type = Random => Random
         */

        // Accuracy Variables
        private const int MinimumAccuracy = 50;         // Actual Min is +5 more
        private const int MaximumAccuracy = 95;         // Max accuracy

        // DamageOffset Variables
        private const double DamageOffsetMultiplier = 5;// Multiplied by level to determine damage, largest factor in determining damage
        private const int DamageOffsetMin = 3;          // Min random value added to damage minimum (DamageOffset)
        private const int DamageOffsetMax = 18;         // Max random value added to damage minimum (DamageOffset)

        // Rarity Variables
        private const int RarityMin = 0;
        private const int RarityMax = 100;
        private const int RarityCommonThreshhold = 50;
        private const int RarityUncommonThreshhold = 75;
        private const int RarityRareThreshhold = 87;
        private const int RarityLegendaryThreshhold = 93;

        private static Random random = new Random();

        public static Weapon GenerateWeapon(int level, string type)
        {
            Random random = new Random();
            Weapon w;
            bool isProjectile;

            switch (type)
            {
                case "Projectile":
                    w = new ProjectileWeapon();
                    isProjectile = true;
                    break;
                case "Melee":
                    w = new MeleeWeapon();
                    isProjectile = false;
                    break;
                default:
                    if (random.Next(0, 10) % 2 == 0)
                    {
                        w = new ProjectileWeapon();
                        isProjectile = true;
                    }
                    else
                    {
                        w = new MeleeWeapon();
                        isProjectile = false;
                    }
                    break;
            }

            w.DamageOffset = GenerateDamageOffset(level);
            w.Accuracy = GenerateAccuracy();
            w.Rarity = GenerateRarity();
            w.Modules = new List<Module>();

            if (isProjectile)
            {
                return ProjectileWeapon.GenerateProjectileWeapon(level, w);
            }
            else
            {
                return MeleeWeapon.GenerateMeleeWeapon(level, w);
            }
        }

        private static string GenerateName()
        {
            string name = "";

            return name;
        }

        private static int GenerateDamageOffset(int level)
        {
            int damageoffset = 0;

            damageoffset = (int)((DamageOffsetMultiplier * level) + random.Next(DamageOffsetMin, DamageOffsetMax));

            return damageoffset;
        }

        private static int GenerateValue()
        {
            int value = 0;

            return value;
        }

        private static double GenerateAccuracy()
        {
            int accuracy = random.Next(MinimumAccuracy, MaximumAccuracy + 1);
            int noise = 5 - (accuracy % 5);
            
            accuracy += noise;

            return accuracy;
        }

        private static string GenerateRarity()
        {
            string rarity = "";
            int raritylevel = random.Next(RarityMin, RarityMax);

            if(raritylevel < RarityCommonThreshhold)
            {
                rarity = "Common";
            }
            else if(raritylevel < RarityUncommonThreshhold)
            {
                rarity = "Uncommon";
            }
            else if(raritylevel < RarityRareThreshhold)
            {
                rarity = "Rare";
            }
            else if(raritylevel < RarityLegendaryThreshhold)
            {
                rarity = "Legendary";
            }
            else
            {
                rarity = "Mythical";
            }

            return rarity;
        }

        private static string GenerateManufacturer()
        {
            string manufacturer = "";

            return manufacturer;
        }
    }
}
