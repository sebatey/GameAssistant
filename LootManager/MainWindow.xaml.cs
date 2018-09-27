using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LootManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int ToGenerate = 10;
        private int LevelMin = 0;
        private int LevelMax = 0;

        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateWeaponButton_Click(object sender, RoutedEventArgs e)
        {
            dGrid.ItemsSource = null;
            dGrid.Items.Clear();

            LevelMin = Convert.ToInt32(LevelMinTextBox.Text);
            LevelMax = Convert.ToInt32(LevelMaxTextBox.Text);

            List<ViewModels.Weapon> weapons = new List<ViewModels.Weapon>();
            for (int i = 0; i < ToGenerate; i++)
            {
                weapons.Add(ViewModels._WeaponGenerator.GenerateWeapon(random.Next(LevelMin, LevelMax), "Melee"));
            }

            dGrid.ItemsSource = weapons;
        }
    }
}
