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

namespace Clicker
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        int nariz;
        int narizPorClique;
        int upgrade1;
        public MainWindow()
        {
            InitializeComponent();
            nariz = 0;
            narizPorClique = 1;
            upgrade1 = 10;
        }

        private void botaoUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (nariz >= upgrade1)
            {
                nariz -= upgrade1;
                upgrade1 = upgrade1 + 10;
                narizPorClique += 1;
                botaoUpgrade1.Content = $"Upgrade ({upgrade1})";
                labelNariz.Content = nariz;
                labelCpC.Content = $"Cravos por Clique: {narizPorClique}";
            }
        }

        private void botaoNariz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            nariz += narizPorClique;
            labelNariz.Content = nariz;
        }
    }
}
