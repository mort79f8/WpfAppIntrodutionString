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

        ClassBIZ cb = new ClassBIZ();
        
        public MainWindow()
        {
            InitializeComponent();
            cb.GetTextForTextBox(textboxLeft);
        }

        private void opgave11_Click(object sender, RoutedEventArgs e)
        {
            textboxRight.Text = $"Antal linier med text i venstre textbox: {cb.CountNumberOfLines(textboxLeft).ToString()}";
        }

        private void opgave12_Click(object sender, RoutedEventArgs e)
        {
            textboxRight.Text = $"Antal characters i venstre textbox: {cb.CountAllChars(textboxLeft).ToString()}"; 
        }

        private void opgave13_Click(object sender, RoutedEventArgs e)
        {
            textboxRight.Text = $"Antal vokaler i venstre textbox: {cb.CountAllVokals(textboxLeft).ToString()}";
        }

        private void opgave14_Click(object sender, RoutedEventArgs e)
        {
            textboxRight.Text = cb.RemoveAllVokals(textboxLeft);
        }

        private void opgave15_Click(object sender, RoutedEventArgs e)
        {
            textboxRight.Text = cb.ReplaceWord(textboxLeft,textboxBottom);
        }

        private void opgave16_Click(object sender, RoutedEventArgs e)
        {
            textboxRight.Text = cb.CountNumberOFWordLength(textboxLeft);
        }
    }
}
