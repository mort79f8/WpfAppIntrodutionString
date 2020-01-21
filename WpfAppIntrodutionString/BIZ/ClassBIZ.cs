using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfAppIntrodutionString.IO;

namespace WpfAppIntrodutionString.BIZ
{
    class ClassBIZ
    {
        ClassIO CIO = new ClassIO();

        public ClassBIZ()
        {

        }

        public void GetTextForTextBox(TextBox textBox)
        {
            CIO.GetTestString(textBox);
        }

        public int CountNumberOfLines(TextBox textBox)
        {
            int result = 0;

            int numberOfLines = textBox.LineCount;

            for (int i = 0; i < numberOfLines; i++)
            {
                if (textBox.GetLineText(i).Trim().Length > 0)
                {
                    result++;
                }
            }

            return result;
        }

        public int CountAllChars(TextBox textBox)
        {
            int counter = 0;

            foreach (char c in textBox.Text)
            {
                counter++;
            }

            return counter;
        }

        public int CountAllVokals(TextBox textBox)
        {
            int counter = 0;

            foreach (char c in textBox.Text)
            {
                switch (c)
                {
                    case 'a':
                        counter++;
                        break;
                    case 'e':
                        counter++;
                        break;
                    case 'u':
                        counter++;
                        break;
                    case 'i':
                        counter++;
                        break;
                    case 'o':
                        counter++;
                        break;
                    case 'å':
                        counter++;
                        break;
                    case 'æ':
                        counter++;
                        break;
                    case 'ø':
                        counter++;
                        break;
                    default:
                        break;
                }
            }

            return counter;
        }
    }
}
