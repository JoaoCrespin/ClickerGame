using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Clicker
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer;

        double nariz;
        double narizPorClique;
        double upgrade1;
        double upgrade2;
        double narizPorSegundo;
        public MainWindow()
        {
            InitializeComponent();

            //Timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(0.1);
            _timer.Start();
            _timer.Tick += Timer_Tick;

            //Configuração inicial
            nariz = 0;
            narizPorClique = 1;
            upgrade1 = 10;
            upgrade2 = 20;
            narizPorSegundo = 0;
        }

        //Somar nariz por segundo
        private void Timer_Tick(object sender, EventArgs e)
        {
            nariz += narizPorSegundo/10;
            labelNariz.Content = nariz.ToString("F0", CultureInfo.InvariantCulture);
        }

        //Clique no nariz
        private void botaoNariz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            nariz += narizPorClique;
            labelNariz.Content = nariz.ToString("F0", CultureInfo.InvariantCulture);
        }

        //Upgrade 1 (+1 no clique)
        private void botaoUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (nariz >= upgrade1)
            {
                nariz -= upgrade1;
                upgrade1 = upgrade1 + 10;
                narizPorClique += 1;
                botaoUpgrade1.Content = $"Toque macio ({upgrade1})";
                labelNariz.Content = nariz.ToString("F0", CultureInfo.InvariantCulture);
                labelNpC.Content = $"Nariz por Clique: {narizPorClique}";
            }
        }

        //Upgrade 2 (+1 por segundo)
        private void botaoUpgrade2_Click(object sender, RoutedEventArgs e)
        {
            if (nariz >= upgrade2)
            {
                nariz -= upgrade2;
                upgrade2 = upgrade2 + 15;
                narizPorSegundo += 1;
                botaoUpgrade2.Content = $"Cotonete ({upgrade2})";
                labelNariz.Content = nariz.ToString("F0", CultureInfo.InvariantCulture);
                labelNpS.Content = $"Nariz por Segundo: {narizPorSegundo}";
            }
        }
    }
}
