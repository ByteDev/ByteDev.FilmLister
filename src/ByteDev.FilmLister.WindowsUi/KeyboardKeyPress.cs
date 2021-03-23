using System.Windows.Forms;

namespace ByteDev.FilmLister.WindowsUi
{
    public class KeyboardKeyPress
    {
        public static bool IsReturn(KeyPressEventArgs e)
        {
            return e.KeyChar.ToString() == "\r";
        }
    }
}
