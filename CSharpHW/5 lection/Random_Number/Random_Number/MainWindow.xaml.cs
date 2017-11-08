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

namespace Random_Number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int count = 0;
        public int rnd = 0;

        static int Generate_Random()
        {
            Random rand = new Random();
            return rand.Next(1,11);
        }

        private bool Guess()
        {
            var inputNum = 0;
            try
            {
                inputNum = int.Parse(EnteredNumber.Text);
                if (rnd == inputNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public MainWindow()
        {
            InitializeComponent();
            rnd = Generate_Random();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (!Guess())
            {
                count += 1;
                switch (count)
                {
                    case 1:
                        MessageBox.Show("This time unlucky. Try more");
                        EnteredNumber.Text = "";
                        break;
                    case 2:
                        MessageBox.Show("Hmmmm... No. The last chance");
                        EnteredNumber.Text = "";
                        break;
                    case 3:
                        MessageBox.Show("Not your day. You lost:(\nWanna more?");
                        EnteredNumber.Text = "";
                        rnd = Generate_Random();
                        count = 0;
                        break;
                }
            }
            else
            {
                MessageBox.Show("You win");
                EnteredNumber.Text = "";
                rnd = Generate_Random();
                count = 0;
            }
        }
    }
}
