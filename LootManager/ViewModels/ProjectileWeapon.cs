using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LootManager.ViewModels
{
    class ProjectileWeapon : Weapon
    {
        public int MaximumClipSize { get; set; }            // Bullets before reload
        public double ReloadSpeed { get; set; }             // Turns to fire again
        public string AmmoType { get; set; }                // 9mm, plasma, incindiary, drones

        private static string[] ModelTypes = new string[] { "Pistol", "Marksman Rifle", "Sniper Rifle", "Assault Rifle" };
        private static string[] AmmoTypes = new string[] { "9mm", ".357", ".50", "Shells" };
        private static string[] DamageTypes = new string[] { "Explosive", "Piercing", "Fire", "Shock", "Acid", "Poison", "Plasma" };

        private static string[] DamageRanges = new string[] { "D4", "D6", "D8", "D10", "D12", "D20" };

        private const string WEAPON_TYPE = "Projectile";
        
        private static Random random = new Random();

        public static ProjectileWeapon GenerateProjectileWeapon(int level, Weapon w)
        {
            ProjectileWeapon p = new ProjectileWeapon();
            
            p.DamageOffset = w.DamageOffset;
            p.Accuracy = w.Accuracy;
            p.Modules = w.Modules;

            p.WeaponType = WEAPON_TYPE;
            p.AmmoType = GenerateAmmoType();
            p.ModelType = GenerateModelType();
            p.DamageType = GenerateDamageType(p.ModelType);
            p.Size = GenerateSize(p.ModelType);
            p.AttacksPerTurn = GenerateAttacksPerTurn(p.ModelType);
            p.Picture = GeneratePicture(p.ModelType);
            p.Modules = GenerateModules(level, p.ModelType);
            p.DamageRange = GenerateDamageRange(level, p);
            p.DamageOffset = GenerateDamageOffset(level, p);
            p.ReloadSpeed = GenerateReloadSpeed(p.ModelType, p.DamageType);
            p.UsableRange = GenerateUsableRange(level, p.ModelType, p.DamageType);
            p.MaximumClipSize = GenerateMaximumClipSize(level, p.ModelType, p.DamageType);
            p.Stats = GenerateStats();
            p.Manufacturer = GenerateManufacturer();
            p.Value = GenerateValue();
            p.Name = GenerateName(p);

            return p;
        }

        private static double GenerateReloadSpeed(string modeltype, string damagetype)
        {
            double reloadspeed = 0;

            switch (modeltype)
            {
                // model type multiplier * damage type modifier * Random
            }

            return reloadspeed;
        }

        private static string GenerateAmmoType()
        {
            return AmmoTypes[random.Next(0, AmmoTypes.Length)];
        }

        private static string GenerateModelType()
        {
            return ModelTypes[random.Next(0, ModelTypes.Length)];
        }

        private static int GenerateSize(string modeltype)
        {
            int size = 0;

            switch (modeltype)
            {
                // weighted chance based on model type
            }

            return size;
        }

        private static string GenerateDamageType(string modeltype)
        {
            string damagetype = "";

            switch (modeltype)
            {
                default:
                    damagetype = DamageTypes[random.Next(0, DamageTypes.Length)];
                    break;
            }

            return damagetype;
        }

        private static int GenerateAttacksPerTurn(string modeltype)
        {
            int attacksperturn = 0;

            switch (modeltype)
            {
                // model type modifier + Random
            }

            return attacksperturn;
        }

        private static Image GeneratePicture(string modeltype)
        {
            Image image = new Image();

            switch (modeltype)
            {
                // Random based on model type
            }

            return image;
        }

        private static List<Module> GenerateModules(int level, string modeltype)
        {
            List<Module> list = new List<Module>();

            for (int i = 0; i < 6; i++)
            {
                switch (modeltype)
                {
                    // weighted chance based on model type to add new Module of specific type
                }
            }

            return list;
        }

        private static string GenerateDamageRange(int level, Weapon w)
        {
            string damagerange = "";

            int basedice = 1;
            int dicemodifier = 15;

            switch (w.DamageType)
            {
                case "Explosive":
                    // D10 - D20
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(3, DamageRanges.Length)];
                    break;
                case "Piercing":
                    // D4 - D10
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(0, 4)];
                    break;
                case "Fire":
                    // D6 - D12
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(1, DamageRanges.Length - 1)];
                    break;
                case "Shock":
                    // D6 - D12
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(1, DamageRanges.Length - 1)];
                    break;
                case "Acid":
                    // D4 - D8
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(0, 3)];
                    break;
                case "Poison":
                    // D4 - D8
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(0, 3)];
                    break;
                case "Plasma":
                    // D6 - D12
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(1, DamageRanges.Length - 1)];
                    break;
                default:
                    // D4 - D20
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(0, DamageRanges.Length)];
                    break;
            }

            return damagerange;
        }

        /*
         * DamageOffset is calculated based on the level and DamageRange
         * DamageRange is calculated first randomly based on DamageType
         * DamageOffset 
         */
        public static int GenerateDamageOffset(int level, Weapon w)
        {
            // The final product to be manipulated by the other variables
            int damageoffset = 0;

            int levelmultiplier = 3;    // Multiplied by level and added to damageoffset
            int damagemultiplier = 1;   // Used to increment randomness by a a certain amount
            int damagemin = 0;          // Minimum multiplied by damagemultiplier and added to damageoffset
            int damagemax = 16;         // Maximum multiplied by damagemultiplier and added to damageoffset

            switch (w.DamageRange.Substring(1, w.DamageRange.Length - 1))
            {
                case "D4":
                    damagemin += 6;
                    damagemax += 4;
                    damageoffset += (level * levelmultiplier) + (damagemultiplier * random.Next(damagemin, damagemax));
                    break;
                case "D6":
                    damagemin += 4;
                    damagemax += 4;
                    damageoffset += (level * levelmultiplier) + (damagemultiplier * random.Next(damagemin, damagemax));
                    break;
                case "D8":
                    damagemin += 4;
                    damagemax += 2;
                    damageoffset += (level * levelmultiplier) + (damagemultiplier * random.Next(damagemin, damagemax));
                    break;
                case "D10":
                    damagemin += 2;
                    damagemax += 2;
                    damageoffset += (level * levelmultiplier) + (damagemultiplier * random.Next(damagemin, damagemax));
                    break;
                case "D12":
                    damagemin += 2;
                    damagemax += 0;
                    damageoffset += (level * levelmultiplier) + (damagemultiplier * random.Next(damagemin, damagemax));
                    break;
                case "D20":
                    damagemin += 0;
                    damagemax += -4;
                    damageoffset += (level * levelmultiplier) + (damagemultiplier * random.Next(damagemin, damagemax));
                    break;
                default:
                    damagemin += 0;
                    damagemax += 0;
                    damageoffset += (level * levelmultiplier) + (damagemultiplier * random.Next(damagemin, damagemax));
                    break;
            }

            return damageoffset;
        }

        private static int GenerateUsableRange(int level, string modeltype, string damagetype)
        {
            int usablerange = 0;

            switch (modeltype)
            {
                // model type modifier + (damage type multiplier * level * random)
            }

            return usablerange;
        }

        private static int GenerateMaximumClipSize(int level, string modeltype, string damagetype)
        {
            int usablerange = 0;

            switch (damagetype)
            {
                // damage type modifier + (model type multiplier * level * random)
            }

            return usablerange;
        }

        private static Statistics GenerateStats()
        {
            Statistics stats = new Statistics();

            return stats;
        }

        private static string GenerateManufacturer()
        {
            string manufacturer = "";

            return manufacturer;
        }

        private static int GenerateValue()
        {
            int value = 0;

            return value;
        }

        private static string GenerateName(ProjectileWeapon p)
        {
            // Temporary
            return ModelTypes[random.Next(0, ModelTypes.Length)];
        }

    }
}
