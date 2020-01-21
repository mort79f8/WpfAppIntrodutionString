using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
                    case 'y':
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
                    case 'A':
                        counter++;
                        break;
                    case 'E':
                        counter++;
                        break;
                    case 'Y':
                        counter++;
                        break;
                    case 'U':
                        counter++;
                        break;
                    case 'I':
                        counter++;
                        break;
                    case 'O':
                        counter++;
                        break;
                    case 'Å':
                        counter++;
                        break;
                    case 'Æ':
                        counter++;
                        break;
                    case 'Ø':
                        counter++;
                        break;
                    default:
                        break;
                }
            }

            return counter;
        }

        public string RemoveAllVokals(TextBox textBox)
        {
            string vowels = "aeyuioæøåAEYUIOÆØÅ";
            string text = textBox.Text;

            text = new string(text.Where(c => !vowels.Contains(c)).ToArray());

            return text;
        }

        public string ReplaceWord(TextBox textBox, TextBox replacementWord)
        {

            string text = textBox.Text;
            int count = 0;
            int i = text.IndexOf(replacementWord.Text);

            if (replacementWord.Text == "")
            {
                text = "Du skal skrive et ord fra teksten i textboksen i bunden at programmet";
            }
            else
            {

                while (i != -1)
                {
                    text = text.Insert(i, "#>");
                    count++;
                    i = text.IndexOf(replacementWord.Text, i + 3);
                }

                text = $"Ordet {replacementWord.Text} blev funder {count} gange og er blevet markeret med #>\n\n{text}";
            }

            return text;

            // old method do not count the number of times word have been found
            //string modified = "";
            //if (replacementWord.Text == "")
            //{
            //    modified = "Du skal skrive et ord fra teksten i textboksen i bunden at programmet";
            //}
            //else
            //{
            //    modified = text.Replace(replacementWord.Text, $"#>{replacementWord.Text}");
            //}


            //return modified;
        }

        public string CountNumberOFWordLength(TextBox textBox)
        {

            string result = "";

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            string[] allWords = textBox.Text.Split(' ');

            foreach (string w in allWords)
            {
                if (dictionary.TryGetValue(w.Length, out int count))
                {
                    count++;
                    dictionary[w.Length] = count;
                }
                else
                {
                    dictionary.Add(w.Length, 1);
                }
            }

            var list = dictionary.Keys.ToList();
            list.Sort();

            foreach (int key in list)
            {
                string text = $"Ord med længde {key}: {dictionary[key]} stk" + System.Environment.NewLine;
                result = result + text;
            }

            return result;
        }

        public string CollectAllWords(TextBox textBox)
        {
            string result = "";
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string[] allWords = textBox.Text.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();

            foreach (string w in allWords)
            {
                if (dict.TryGetValue(w, out int count))
                {
                    count++;
                    dict[w] = count; 
                }
                else
                {
                    dict.Add(w, 1);
                }
            }

            var list = dict.Keys.ToList();
            list.Sort();

            foreach (string word in list)
            {
                string text = $"ordet >> {word} << forekommer: {dict[word]} antal gange." + System.Environment.NewLine;
                result = result + text;
            }


            return result;
        }

        public void CutAwayLastLetterWhereWordIsLongerThan3Chars(TextBox oldText, TextBox newText)
        {
            StringCollection lines = new StringCollection();
            string newFinalText = "";

            int lineCount = oldText.LineCount;
            
            for (int line = 0; line < lineCount; line++)
            {
                lines.Add(oldText.GetLineText(line));
            }

            foreach (string line in lines)
            {
                string newLine = "";
                string[] allWords = line.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();
                foreach (string word in allWords)
                {
                    if (word.Length > 3)
                    {
                        newLine += $" {word.Substring(0, (word.Length - 1))}";
                    }
                    else
                    {
                        newLine += $" {word}";
                    }
                }
                newFinalText += newLine + System.Environment.NewLine;
            }

            newText.Text = newFinalText;
        }

    }
}
