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

        private const int MinimumAccuracy = 60;
        private const int MaximumAccuracy = 90;
        private const double DamageOffsetMultiplier = 0;
        private const int DamageOffsetMin = 0;
        private const int DamageOffsetMax = 0;

        private static Random random = new Random();

        public static Weapon GenerateWeapon(int level, string type)
        {
            Random random = new Random();
            Weapon w;
            bool isProjectile;

            switch (type)
            {
                case "Ranged":
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
            return random.NextDouble() * (MinimumAccuracy - MaximumAccuracy) + MinimumAccuracy;
        }

        private static string GenerateManufacturer()
        {
            string manufacturer = "";

            return manufacturer;
        }
    }
}
