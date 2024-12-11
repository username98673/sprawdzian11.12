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
using static System.Net.Mime.MediaTypeNames;

namespace sprawdzian11._12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listObrazkow = new List<string>();
        int liczbaPolubien = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            
            listObrazkow.Add("obrazik.jpg");
            listObrazkow.Add("obrazik2.jpg");
            listObrazkow.Add("obrazix2.jpg");
            listObrazkow.Add("obrazx.jpg");
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            liczbaPolubien++;
            liczbapolubienTextBlock.Text = liczbaPolubien.ToString();
            int aktualny = 0;
                if (combobox_zdjecie.Text == "zdjecie2")
                {
                    aktualny = 1;
                }
                if (combobox_zdjecie.Text == "zdjecie3")
                {
                    aktualny = 2;
                }
                if (combobox_zdjecie.Text == "zdjecie4")
                {
                    aktualny = 3;
                }
            if (combobox_zdjecie.Text == "zdjecie1")
            {
                aktualny = 0;
            }

            wyswietlObraz(aktualny);
        }
        private void wyswietlObraz(int i)
        {
            obraz.Source = new BitmapImage(new Uri(listObrazkow[i], UriKind.Relative));
        }
    }
}
