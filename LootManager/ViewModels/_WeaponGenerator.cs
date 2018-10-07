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
                    w = new ProjectileWeapon();
                    isProjectile = true;
                    break;
            }
            
            w.Accuracy = Weapon.GenerateAccuracy();
            w.Rarity = Weapon.GenerateRarity();
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
    }
}
