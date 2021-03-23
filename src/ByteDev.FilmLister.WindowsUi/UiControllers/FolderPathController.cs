using System.IO;
using System.Windows.Forms;

namespace ByteDev.FilmLister.WindowsUi.UiControllers
{
	public class FolderPathController
	{
		private readonly TextBox _pathTextBox;

		public FolderPathController(TextBox pathTextBox)
		{
			_pathTextBox = pathTextBox;
		}

		public string GetPath()
		{
			if(!Directory.Exists(_pathTextBox.Text))
				throw new DirectoryNotFoundException($"Path: '{_pathTextBox.Text}' does not exist");

            return _pathTextBox.Text;
		}
	}
}
