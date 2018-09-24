using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LootManager.ViewModels
{
    class MeleeWeapon : Weapon
    {
        public double ParryChance { get; set; }                 // Chance to Parry
        public double BlockChance { get; set; }                 // Chance to Block
        public double Durability { get; set; }                  // Durability

        private static string[] ModelTypes = new string[] { "Plasma Sword", "Sword", "Baseball Bat", "Lead Pipe" };
        private static string[] DamageTypes = new string[] { "Slashing", "Blunt", "Piercing", "Fire", "Electricity", "Acid", "Poison", "Plasma", "Explosive" };
        private static double ParryChanceMultiplier = 0;
        private static double BlockChanceMultiplier = 0;

        private static Random random = new Random();

        public static MeleeWeapon GenerateMeleeWeapon(int level, Weapon w)
        {
            MeleeWeapon m = new MeleeWeapon();
            
            m.DamageOffset = w.DamageOffset;
            m.Accuracy = w.Accuracy;
            m.Modules = w.Modules;

            m.ModelType = GenerateModelType();
            m.DamageType = GenerateDamageType(m.ModelType);
            m.Size = GenerateSize(m.ModelType);
            m.AttacksPerTurn = GenerateAttacksPerTurn(m.ModelType);
            m.Picture = GeneratePicture(m.ModelType);
            m.Modules = GenerateModules(level, m.ModelType);
            m.DamageRange = GenerateDamageRange(level, m.DamageType);
            m.ParryChance = GenerateParryChance(level, m.ModelType);
            m.BlockChance = GenerateBlockChance(level, m.ModelType);
            m.Durability = GenerateDurability(level, m.ModelType);
            m.UsableRange = GenerateUsableRange(level, m.ModelType, m.DamageType);
            m.Stats = GenerateStats();
            m.Manufacturer = GenerateManufacturer();
            m.Value = GenerateValue();
            m.Name = GenerateName(m);

            return m;
        }

        private static double GenerateParryChance(int level, string modeltype)
        {
            double parrychance = 0;

            switch (modeltype)
            {
                // model type modifier + ((level * ParryChanceMultiplier) * Random)
            }

            return parrychance;
        }

        private static double GenerateBlockChance(int level, string modeltype)
        {
            double blockchance = 0;

            switch (modeltype)
            {
                // model type modifier + ((level * BlockChanceMultiplier) * Random)
            }

            return blockchance;
        }

        private static double GenerateDurability(int level, string modeltype)
        {
            double durability = 0;

            switch (modeltype)
            {
                // model type modifier + ((level * DurabilityMultiplier) * Random)
            }

            return durability;
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

        private static int GenerateDamageRange(int level, string damagetype)
        {
            int damagerange = 0;

            switch (damagetype)
            {
                // damage type modifier + (level * random)
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

        private static string GenerateName(MeleeWeapon m)
        {
            return ModelTypes[random.Next(0, ModelTypes.Length)];
        }

    }
}
