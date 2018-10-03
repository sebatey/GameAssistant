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
        private static string[] DamageTypes = new string[] { "Piercing" };

        private const string WEAPON_TYPE = "Projectile";

        // DamageRange Variables
        private const int DamageRangeMinMultiplier = 1;     //
        private const int DamageRangeMaxMultiplier = 3;     //

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
            p.DamageRange = GenerateDamageRange(level, p.DamageOffset, p.DamageType);
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
                // weighted chance based on model type
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

        private static int GenerateDamageRange(int level, int damageoffset, string damagetype)
        {
            int damagerange = 0;
            int damagetypemodifier = 0;

            switch (damagetype)
            {
                default:
                    damagerange = damagetypemodifier + damageoffset +
                        (level * random.Next(DamageRangeMinMultiplier, DamageRangeMaxMultiplier + 1));
                    break;
            }

            return damagerange;
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
