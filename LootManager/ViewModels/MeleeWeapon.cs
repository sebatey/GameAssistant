using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LootManager.ViewModels
{
    class MeleeWeapon : Weapon
    {
        // MeleeWeapon Specific Stats
        public int ParryChance { get; set; }                 // Chance to Parry
        public int BlockChance { get; set; }                 // Chance to Block
        public int Durability { get; set; }                  // Durability
        
        private static string[] ModelTypes = new string[] { "Plasma Sword", "Sword", "Baseball Bat", "Lead Pipe" };
        private static string[] DamageTypes = new string[] { "Slashing", "Blunt", "Piercing", "Fire", "Electricity", "Acid", "Poison", "Plasma" };

        private static string[] DamageRanges = new string[] { "D4", "D6", "D8", "D10", "D12", "D20" };

        private const int ImageWidth = 48;
        private const int ImageHeight = 48;
        private const int ImageRows = 7;
        private const int ImageCols = 7;
        private static Bitmap[] ImageLayers = new Bitmap[] 
        {
            new Bitmap("img/sharp_handle.png"),
            new Bitmap("img/sharp_blade.png"),
            new Bitmap("img/sharp_hilt.png")
        };

        private const string WEAPON_TYPE = "Melee";

        // ParryChance & BlockChance
        private const int ParryChanceMultiplier = 0;
        private const int BlockChanceMultiplier = 0;     

        private static Random random = new Random();

        public static MeleeWeapon GenerateMeleeWeapon(int level, Weapon w)
        {
            MeleeWeapon m = new MeleeWeapon();

            m.Accuracy = w.Accuracy;
            m.Modules = w.Modules;
            m.Rarity = w.Rarity;

            m.WeaponType = WEAPON_TYPE;
            m.ModelType = GenerateModelType();
            m.DamageType = GenerateDamageType(m.ModelType);
            m.Size = GenerateSize(m.ModelType);
            m.AttacksPerTurn = GenerateAttacksPerTurn(m.ModelType);
            m.Picture = GeneratePicture(m.ModelType);
            m.Modules = GenerateModules(level, m.ModelType);
            m.ParryChance = GenerateParryChance(level, m.ModelType);
            m.BlockChance = GenerateBlockChance(level, m.ModelType);
            m.Durability = GenerateDurability(level, m.ModelType);
            m.DamageRange = GenerateDamageRange(level, m);
            m.DamageOffset = GenerateDamageOffset(level, m);
            m.UsableRange = GenerateUsableRange(level, m.ModelType, m.DamageType);
            m.Stats = GenerateStats();
            m.Manufacturer = GenerateManufacturer();
            m.Value = GenerateValue();
            m.Name = GenerateName(m);

            return m;
        }

        private static int GenerateParryChance(int level, string modeltype)
        {
            int parrychance = 0;

            switch (modeltype)
            {
                // model type modifier + ((level * ParryChanceMultiplier) * Random)
            }

            return parrychance;
        }

        private static int GenerateBlockChance(int level, string modeltype)
        {
            int blockchance = 0;

            switch (modeltype)
            {
                // model type modifier + ((level * BlockChanceMultiplier) * Random)
            }

            return blockchance;
        }

        private static int GenerateDurability(int level, string modeltype)
        {
            int durability = 0;

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

        private static System.Windows.Controls.Image GeneratePicture(string modeltype)
        {
            int x = random.Next(0, ImageCols);
            int y = random.Next(0, ImageRows);

            Bitmap subimageLayer_1 = ImageLayers[0].Clone(new Rectangle((x * ImageWidth), (y * ImageHeight), ImageWidth, ImageHeight), ImageLayers[0].PixelFormat);
            Bitmap subimageLayer_2 = ImageLayers[1].Clone(new Rectangle((x * ImageWidth), (y * ImageHeight), ImageWidth, ImageHeight), ImageLayers[1].PixelFormat);
            Bitmap subimageLayer_3 = ImageLayers[2].Clone(new Rectangle((x * ImageWidth), (y * ImageHeight), ImageWidth, ImageHeight), ImageLayers[2].PixelFormat);

            switch (modeltype)
            {
                // Random based on model type
            }

            return null;
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
                case "Piercing":
                    // D4 - D8
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(0, 3)];
                    break;
                case "Explosive":
                    // D10 - D20
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(3, DamageRanges.Length)];
                    break;
                case "Plasma":
                    // D6 - D12
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(1, DamageRanges.Length - 1)];
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
                default:
                    // D4 - D20
                    damagerange += random.Next(basedice, basedice + (level / dicemodifier) + 1);
                    damagerange += DamageRanges[random.Next(0, DamageRanges.Length)];
                    break;
            }

                return damagerange;
        }

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
            // Temporary
            return ModelTypes[random.Next(0, ModelTypes.Length)];
        }

    }
}
