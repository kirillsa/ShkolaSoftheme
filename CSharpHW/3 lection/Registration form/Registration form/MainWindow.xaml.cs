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

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            if (firstNameText.Text == "" || firstNameText.Text.Length > 255 || int.TryParse(firstNameText.Text, out var n))
            {
                MessageBox.Show("Wrong Name format!");
            }
            if (lastNameText.Text == "" || lastNameText.Text.Length > 255 || int.TryParse(lastNameText.Text, out n))
            {
                MessageBox.Show("Wrong LastName format!");
            }
            if (dayText.Text == "" || !int.TryParse(dayText.Text, out n) || int.Parse(dayText.Text) < 1 || int.Parse(dayText.Text) > 31)
            {
                MessageBox.Show("Wrong Day of Birth format!");
            }
            if (monthText.Text == "" || !int.TryParse(monthText.Text, out n) || int.Parse(monthText.Text) < 1 || int.Parse(monthText.Text) > 12)
            {
                MessageBox.Show("Wrong Month of Birth format!");
            }
            if (yearText.Text == "" || !int.TryParse(yearText.Text, out n) || int.Parse(yearText.Text) < 1900 || int.Parse(yearText.Text) > DateTime.Today.Year)
            {
                MessageBox.Show("Wrong Year of Birth format!");
            }
            /*if (!genderm.IsChecked(genderm) && !genderf.Checked)
            {
                MessageBox.Show("Wrong Gender format!");
            }*/
            if (emailText.Text == "" || !emailText.Text.Contains('@'))
            {
                MessageBox.Show("Wrong email format!");
            }
            if (phoneNumberText.Text == "" || !double.TryParse(phoneNumberText.Text, out var m) || phoneNumberText.Text.Length != 12)
            {
                MessageBox.Show("Wrong phone format!");
            }
            if (infoText.Text.Length > 2000)
            {
                MessageBox.Show("Wrong phone format!");
            }
            else
            {
                MessageBox.Show("Registration complete");
            }
        }
    }
}
