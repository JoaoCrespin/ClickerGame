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
using System.Windows.Media.Animation;
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

        NarizClasse narizClasse = new NarizClasse();

        double upgrade1;
        double upgrade2;
        double upgrade3;
        double upgrade4;
        int upgradeMultiplicador;

        public MainWindow()
        {
            InitializeComponent();

            //Timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(0.1);
            _timer.Start();
            _timer.Tick += Timer_Tick;

            //Configuração inicial
            narizClasse.Nariz = 5000;
            narizClasse.NarizPorClique = 1;
            narizClasse.NarizPorSegundo = 0;
            narizClasse.Acessorio = "";
            upgradeMultiplicador = 1;

            upgrade1 = 10;
            upgrade2 = 20;
            upgrade3 = 200;
            upgrade4 = 500;
        }

        //Somar nariz por segundo
        private void Timer_Tick(object sender, EventArgs e)
        {
            narizClasse.Nariz += narizClasse.NarizPorSegundo / 10;
            labelNariz.Content = narizClasse.Nariz.ToString("F0", CultureInfo.InvariantCulture);
        }

        //Clique no nariz
        private void botaoNariz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            narizClasse.Nariz += narizClasse.NarizPorClique;
            labelNariz.Content = narizClasse.Nariz.ToString("F0", CultureInfo.InvariantCulture);

            //Diminuir o tamanho do nariz quando clicar
            botaoNariz.Width = 100;
            botaoNariz.Height = 100;

            //Chamando a função de mostrar +
            mostrarMais();
        }

        //Upgrade 1 (+1 por clique)
        private void botaoUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < upgradeMultiplicador; i++)
            {
                if (narizClasse.Nariz >= upgrade1)
                {
                    narizClasse.Nariz -= upgrade1;
                    upgrade1 = upgrade1 + 10;
                    narizClasse.NarizPorClique += 1;
                    botaoUpgrade1.Content = $"Toque macio ({upgrade1})";
                    labelNariz.Content = narizClasse.Nariz.ToString("F0", CultureInfo.InvariantCulture);
                    labelNpC.Content = $"Nariz por Clique: {narizClasse.NarizPorClique}";
                }
                else
                {
                    break;
                }
            }
        }

        //Upgrade 2 (+1 por segundo)
        private void botaoUpgrade2_Click(object sender, RoutedEventArgs e)
        {
            if (narizClasse.Nariz >= upgrade2)
            {
                narizClasse.Nariz -= upgrade2;
                upgrade2 = upgrade2 + 15;
                narizClasse.NarizPorSegundo += 1;
                botaoUpgrade2.Content = $"Cotonete ({upgrade2})";
                labelNariz.Content = narizClasse.Nariz.ToString("F0", CultureInfo.InvariantCulture);
                labelNpS.Content = $"Nariz por Segundo: {narizClasse.NarizPorSegundo}";
            }
        }

        //Upgrade 3 (+20 por clique)
        private void botaoUpgrade3_Click(object sender, RoutedEventArgs e)
        {
            if (narizClasse.Nariz >= upgrade3)
            {
                narizClasse.Nariz -= upgrade3;
                upgrade3 = upgrade3 + 20;
                narizClasse.NarizPorClique += 20;
                botaoUpgrade3.Content = $"Cafungada ({upgrade3})";
                labelNariz.Content = narizClasse.Nariz.ToString("F0", CultureInfo.InvariantCulture);
                labelNpC.Content = $"Nariz por Clique: {narizClasse.NarizPorClique}";
            }
        }

        //Upgrade 4 (+25 por segundo)
        private void botaoUpgrade4_Click(object sender, RoutedEventArgs e)
        {
            if (narizClasse.Nariz >= upgrade4)
            {
                narizClasse.Nariz -= upgrade4;
                upgrade4 = upgrade4 + 25;
                narizClasse.NarizPorSegundo += 25;
                botaoUpgrade4.Content = $"Pelos ({upgrade4})";
                labelNariz.Content = narizClasse.Nariz.ToString("F0", CultureInfo.InvariantCulture);
                labelNpS.Content = $"Nariz por Segundo: {narizClasse.NarizPorSegundo}";

                if (narizClasse.Acessorio == "")
                {
                    adicionarPelos();
                }

            }
        }

        //Mudar tamanho da imagem quando o mouse estiver no nariz
        private void botaoNariz_MouseEnter(object sender, MouseEventArgs e)
        {
            botaoNariz.Width = 105;
            botaoNariz.Height = 105;
        }

        //Voltar o tamanho da imagem quando o mouse sair do nariz
        private void botaoNariz_MouseLeave(object sender, MouseEventArgs e)
        {
            botaoNariz.Width = 100;
            botaoNariz.Height = 100;
        }

        //Aumentar o tamanho do nariz quando soltar o botão de clicar
        private void botaoNariz_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            botaoNariz.Width = 105;
            botaoNariz.Height = 105;
        }

        //Mostra animação +N
        private void mostrarMais()
        {
            //Cria a label
            Label labelMais = new Label();
            labelMais.Content = $"+{narizClasse.NarizPorClique}";
            labelMais.FontSize = 15;
            labelMais.IsHitTestVisible = false; //Deixa a label não clicável, permitindo clicar no botão que está atrás
            labelMais.HorizontalAlignment = HorizontalAlignment.Center;
            labelMais.VerticalAlignment = VerticalAlignment.Center;
            grid1.Children.Add(labelMais);

            //Movimento
            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.From = 50;
            heightAnimation.To = 250;
            heightAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            labelMais.BeginAnimation(Label.HeightProperty, heightAnimation);

            //Opacidade
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 1.0;
            opacityAnimation.To = 0;
            opacityAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            labelMais.BeginAnimation(Label.OpacityProperty, opacityAnimation);
        }

        //Adiciona a imagem de pelos
        private void adicionarPelos()
        {
            BitmapImage minhaBitmapImage = new BitmapImage();
            minhaBitmapImage.BeginInit();
            minhaBitmapImage.UriSource = new Uri("/Imagens/Pelos.png", UriKind.RelativeOrAbsolute);
            minhaBitmapImage.EndInit();

            Image imagemPelos = new Image();
            imagemPelos.Width = 100;
            imagemPelos.Height = 100;
            imagemPelos.IsHitTestVisible = false;
            imagemPelos.Source = minhaBitmapImage;
            imagemPelos.HorizontalAlignment = HorizontalAlignment.Center;
            imagemPelos.VerticalAlignment = VerticalAlignment.Center;
            grid1.Children.Add(imagemPelos);

            narizClasse.Acessorio = "pelos";
        }

        private void botaox1_Click(object sender, RoutedEventArgs e)
        {
            upgradeMultiplicador = 1;
        }

        private void botaox10_Click(object sender, RoutedEventArgs e)
        {
            upgradeMultiplicador = 10;
        }

        private void botaox100_Click(object sender, RoutedEventArgs e)
        {
            upgradeMultiplicador = 100;
        }
    }
}
