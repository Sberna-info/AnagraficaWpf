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

namespace AnagraficaWpf
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bntSaluta_Click(object sender, RoutedEventArgs e)
        {
            if (txtCognome.Text != "" && txtEta.Text != "" && txtNome.Text != "")
            {
                try
                {
                    string nome = Convert.ToString(txtNome.Text);
                    string cognome = Convert.ToString(txtCognome.Text);
                    int eta = int.Parse(txtEta.Text);
                    if (eta < 20)
                        MessageBox.Show("Non sei abbastanza grande", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
                    else
                    {
                        if(rdbCalcio.IsChecked == true)
                        {

                            if(rdbBarce.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e la tua squadra preferita di calcio è il barcellona.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else if(rdbReal.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e la tua squadra preferita di calcio è il Real Madrid.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else if(rdbJuve.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e la tua squadra preferita di calcio è la Juventus.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                        else if(rdbPallavolo.IsChecked == true)
                        {
                            if (rdbTreviso.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e la tua squadra preferita di pallavolo è il treviso volley.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else if (rdbSir.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e la tua squadra preferita di pallavolo è la Sir Safety.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else if (rdbModena.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e la tua squadra preferita di pallavolo è il Modena volley.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                        else if(rdbNuoto.IsChecked == true)
                        {
                            if (rdbPhelps.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e il tuo nuotatore preferito è Phelps.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else if (rdbPellegrini.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e la tua nuotatrice preferita è la Pellegrini.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else if (rdbLedecky.IsChecked == true)
                            {
                                MessageBox.Show($"Sei {nome} {cognome} hai {eta} anni e il tuo nuotatore preferito è Ledecky.", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Inserisci tutti i dati", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void rdbCalcio_Checked(object sender, RoutedEventArgs e)
        {
            rdbBarce.IsEnabled = true;
            rdbJuve.IsEnabled = true;
            rdbReal.IsEnabled = true;
            lblCalcio.IsEnabled = true;

            rdbLedecky.IsEnabled = false;
            rdbPellegrini.IsEnabled = false;
            rdbPhelps.IsEnabled = false;
            lblNuoto.IsEnabled = false;

            rdbModena.IsEnabled = false;
            rdbSir.IsEnabled = false;
            rdbTreviso.IsEnabled = false;
            lblPallavolo.IsEnabled = false;
        }

        private void rdbNuoto_Checked(object sender, RoutedEventArgs e)
        {
            rdbLedecky.IsEnabled = true;
            rdbPellegrini.IsEnabled = true;
            rdbPhelps.IsEnabled = true;
            lblNuoto.IsEnabled = true;

            rdbModena.IsEnabled = false;
            rdbSir.IsEnabled = false;
            rdbTreviso.IsEnabled = false;
            lblPallavolo.IsEnabled = false;

            rdbBarce.IsEnabled = false;
            rdbJuve.IsEnabled = false;
            rdbReal.IsEnabled = false;
            lblCalcio.IsEnabled = false;
        }

        private void rdbPallavolo_Checked(object sender, RoutedEventArgs e)
        {
            rdbModena.IsEnabled = true;
            rdbSir.IsEnabled = true;
            rdbTreviso.IsEnabled = true;
            lblPallavolo.IsEnabled = true;

            rdbBarce.IsEnabled = false;
            rdbJuve.IsEnabled = false;
            rdbReal.IsEnabled = false;
            lblCalcio.IsEnabled = false;

            rdbLedecky.IsEnabled = false;
            rdbPellegrini.IsEnabled = false;
            rdbPhelps.IsEnabled = false;
            lblNuoto.IsEnabled = false;
        }
    }
}
