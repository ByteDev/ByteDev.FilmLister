using System;
using System.Windows.Forms;

namespace ByteDev.FilmLister.WindowsUi
{
    public static class TextBoxExtensions
    {
        public static void PrintLine(this TextBox source)
        {
            PrintLine(source, string.Empty);
        }

        public static void PrintLine(this TextBox source, string message)
        {
            source.Text += message + Environment.NewLine;
        }
    }
}