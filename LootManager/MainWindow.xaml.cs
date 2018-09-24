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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateWeaponButton_Click(object sender, RoutedEventArgs e)
        {
            WeaponsListView.Items.Clear();
            for (int i = 0; i < ToGenerate; i++)
            {
                WeaponsListView.Items.Add(ViewModels._WeaponGenerator.GenerateWeapon(1, "Melee").Name);
            }
        }
    }
}
