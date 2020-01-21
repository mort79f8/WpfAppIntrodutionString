using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntrodutionString.IO
{
    class ClassIO
    {
        public ClassIO()
        {

        }

        public void GetTestString(TextBox textBox )
        {
            //string[] output = System.IO.File.ReadAllLines(@"D:\Software\S3_Dima\code\WPF\WpfAppIntrodutionString\WpfAppIntrodutionString\Admiralen.txt");

            //return output;

            string result = File.ReadAllText(@"D:\Software\S3_Dima\code\WPF\WpfAppIntrodutionString\WpfAppIntrodutionString\Admiralen.txt");

            textBox.Text = result;

        }

    }
}
