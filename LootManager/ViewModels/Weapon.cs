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
        // Critical Hit Multiplier
        // Critical Hit Range

        // Items already included in MainWindow.xaml
        // + Name
        // + DamageOffset
        // + DamageRange
        // + Accuracy
        public string Name { get; set; }                    // Name of Weapon
        public int DamageOffset { get; set; }               // Minimum Damage
        public int DamageRange { get; set; }                // DamageOffset + DamageRange = Maximum Damage
        public int AttacksPerTurn { get; set; }             // Actions Per Turn
        public int Value { get; set; }                      // Value
        public int UsableRange { get; set; }                // Range
        public int Size { get; set; }                       // Hands Required to Wield
        public double Accuracy { get; set; }                // Dificulty
        public string WeaponType { get; set; }              // Melee / Projectile
        public string DamageType { get; set; }              // Damage "Element"
        public string Manufacturer { get; set; }            // Weapon Manufacturer
        public string ModelType { get; set; }               // Pistol / Rifle / Plasma Sword / Baseball Bat
        public string Rarity { get; set; }                  // How unique this weapon is
        public Statistics Stats { get; set; }               // Stats
        public Image Picture { get; set; }                  // Image
        public List<Module> Modules { get; set; }           // Maximum Ability Slots
    }
}
