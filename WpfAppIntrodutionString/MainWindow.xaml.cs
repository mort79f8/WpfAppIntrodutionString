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
using WpfAppIntrodutionString.BIZ;

namespace WpfAppIntrodutionString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ClassBIZ classBiz = new ClassBIZ();
        
        public MainWindow()
        {
            InitializeComponent();
            classBiz.GetTextForTextBox(textboxLeft);
        }

        private void opgave11_Click(object sender, RoutedEventArgs e)
        {
            textboxRight.Text = $"Antal linier med text i venster textbox: {classBiz.CountNumberOfLines(textboxLeft).ToString()}";
        }
    }
}
