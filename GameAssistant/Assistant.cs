using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssistant
{
    public static class Assistant
    {
        public static void LaunchLootManager()
        {
            LootManager.MainWindow w = new LootManager.MainWindow();
            w.Show();
        }
    }
}
