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

namespace Registration_form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private BitmapImage Get_Image(string s, UriKind uk)
        {
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(s, uk);
            bi3.EndInit();
            return bi3;
        }

        private void showSign_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var date = DateTime.Parse(dateField.Text);
                if (date.Month == 3 && date.Day >= 21 || date.Month == 4 && date.Day <= 20)
                {//овен
                    /*BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("/img/oven.jpg", UriKind.Relative);
                    bi3.EndInit();*/
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/oven.jpg", UriKind.Absolute);
                }
                else if (date.Month == 4 && date.Day >= 21 || date.Month == 5 && date.Day <= 21)
                {//телец
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/telec.jpg", UriKind.Absolute);
                }
                else if (date.Month == 5 && date.Day >= 22 || date.Month == 6 && date.Day <= 21)
                {//близнецы
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/blizneci.jpg", UriKind.Absolute);
                }
                else if (date.Month == 6 && date.Day >= 22 || date.Month == 7 && date.Day <= 22)
                {//рак
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/rak.jpg", UriKind.Absolute);
                }
                else if (date.Month == 7 && date.Day >= 23 || date.Month == 8 && date.Day <= 23)
                {//лев
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/lev.jpg", UriKind.Absolute);
                }
                else if (date.Month == 8 && date.Day >= 24 || date.Month == 9 && date.Day <= 23)
                {//дева
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/deva.jpg", UriKind.Absolute);
                }
                else if (date.Month == 9 && date.Day >= 24 || date.Month == 10 && date.Day <= 23)
                {//весы
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/vesy.jpg", UriKind.Absolute);
                }
                else if (date.Month == 10 && date.Day >= 24 || date.Month == 11 && date.Day <= 22)
                {//скорпион
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/skorpion.jpg", UriKind.Absolute);
                }
                else if (date.Month == 11 && date.Day >= 23 || date.Month == 12 && date.Day <= 21)
                {//стрелец
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/strelec.jpg", UriKind.Absolute);
                }
                else if (date.Month == 12 && date.Day >= 22 || date.Month == 1 && date.Day <= 20)
                {//козерог
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/kozerog.jpg", UriKind.Absolute);
                }
                else if (date.Month == 1 && date.Day >= 21 || date.Month == 2 && date.Day <= 18)
                {//водолей 
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/vodolej.jpg", UriKind.Absolute);
                }
                else if (date.Month == 2 && date.Day >= 19 || date.Month == 3 && date.Day <= 20)
                {//рыбы
                    imageOfSign.Source = Get_Image("http://www.astrovedus.com/wp-content/uploads/2010/02/ryby.jpg", UriKind.Absolute);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
