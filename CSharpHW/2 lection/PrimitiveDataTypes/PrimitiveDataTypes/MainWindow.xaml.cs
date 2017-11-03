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

namespace PrimitiveDataTypes
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

        private void typeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (type.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "int":
                    showIntValue();
                    break;
                case "long":
                    showLongValue();
                    break;
                case "float":
                    showFloatValue();
                    break;
                case "double":
                    showDoubleValue();
                    break;
                case "decimal":
                    showDecimalValue();
                    break;
                case "string":
                    showStringValue();
                    break;
                case "char":
                    showCharValue();
                    break;
                case "bool":
                    showBoolValue();
                    break;
            }
        }

        private void showIntValue()
        {
            var intVar = default(int);
            value.Text = "default value is " + intVar.ToString();
            var intMax = int.MaxValue;
            max.Text = "Max = " + intMax.ToString();
            var intMin = int.MinValue;
            min.Text = "Min = " + intMin.ToString();
        }

        private void showLongValue()
        {
            var longVar = default(long);
            value.Text = "default value is " + longVar.ToString();
            var longMax = long.MaxValue;
            max.Text = "Max = " + longMax.ToString();
            var longMin = long.MinValue;
            min.Text = "Min = " + longMin.ToString();
        }

        private void showFloatValue()
        {
            var floatVar = default(float);
            value.Text = "default value is " + floatVar.ToString();
            var floatMax = float.MaxValue;
            max.Text = "Max = " + floatMax.ToString();
            var floatMin = float.MinValue;
            min.Text = "Min = " + floatMin.ToString();
        }

        private void showDoubleValue()
        {
            var doubleVar = default(double);
            value.Text = "default value is " + doubleVar.ToString();
            var doubleMax = double.MaxValue;
            max.Text = "Max = " + doubleMax.ToString();
            var doubleMin = double.MinValue;
            min.Text = "Min = " + doubleMin.ToString();
        }

        private void showDecimalValue()
        {
            decimal decimalVar = default(decimal);
            value.Text = "default value is " + decimalVar.ToString();
            var decimalMax = decimal.MaxValue;
            max.Text = "Max = " + decimalMax.ToString();
            var decimalMin = decimal.MinValue;
            min.Text = "Min = " + decimalMin.ToString();
        }

        private void showStringValue()
        {
            string stringVar;
            stringVar = "String has no default";
            value.Text = stringVar; // ToString not needed
            max.Text = "";
            min.Text = "";
        }

        private void showCharValue()
        {
            char charVar;
            charVar = 'x';
            value.Text = charVar.ToString();
            max.Text = "";
            min.Text = "";
        }

        private void showBoolValue()
        {

            bool boolVar = default(bool);
            value.Text = boolVar.ToString();
            max.Text = "";
            min.Text = "";
        }

        private void quitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
