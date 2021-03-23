using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ByteDev.FilmLister.WindowsUi.Services;
using ByteDev.FilmLister.WindowsUi.UiControllers;
using ByteDev.Io;
using ByteDev.WinForms.Dialogs;
using ByteDev.WinForms.Forms;

namespace ByteDev.FilmLister.WindowsUi
{
	public partial class MainForm : Form
    {
        private const string AppName = "Film Lister";

		private OutputController _outputController;
		private FolderPathController _folderPathController;

        private readonly FilmLibraryService _libraryService;

        public MainForm()
		{
		    InitializeComponent();

            _libraryService = new FilmLibraryService(new MovieFileNameService());

            SetFormText();
        }

		private OutputController OutputController => _outputController ?? (_outputController = new OutputController(outputTextBox));

        private FolderPathController FolderController => _folderPathController ?? (_folderPathController = new FolderPathController(pathTextBox));

        #region Event Handlers

        private void pathTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
			try
			{
                if (KeyboardKeyPress.IsReturn(e))
					PrintFilmList();
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
        }

		private void openFolderMenuItem_Click(object sender, EventArgs e)
		{
			BrowseFolder();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			ShowAboutForm();
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Quit();
		}

        private void refreshFolderMenuItem_Click(object sender, EventArgs e)
        {
            PrintFilmList();
        }

        private void clearFolderMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void copyAllMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextBox.Text);
        }

        #endregion

        private void BrowseFolder()
		{
			try
			{
				var newPath = FolderDialog.SelectFolder(FolderController.GetPath());

				if (newPath != pathTextBox.Text)
				{
					pathTextBox.Text = newPath;
					PrintFilmList();
				}
			}
			catch (Exception ex)
			{
				HandleException(ex);
			}
		}

        private void PrintFilmList()
		{
			var films = _libraryService.ListAllMovieFileNames(FolderController.GetPath());

			OutputController.PrintFilmList(films);

            SetFormText($"({films.Count} films)");
		}

        private static void HandleException(Exception ex)
        {
            var exceptionForm = new ExceptionForm(ex);
            exceptionForm.Show();
        }

        private static void Quit()
		{
			Application.Exit();
		}

        private static void ShowAboutForm()
		{
			var form = new About();
			form.Show();
		}

        private void SetFormText(string text = null)
        {
            Text = string.IsNullOrEmpty(text) ? AppName : $"{AppName} - {text}";
        }

        private void Clear()
        {
            SetFormText();
            OutputController.Clear();
        }

        private void createFoldersButton_Click(object sender, EventArgs e)
        {
            var years = YearService.GetYears();

            foreach (var year in years)
            {
                var dirInfo = new DirectoryInfo(Path.Combine(pathTextBox.Text, year.ToString()));

                dirInfo.CreateDirectory(); // if directory exists does not create it
            }

            MessageBox.Show($"Folders {years.First()} to {years.Last()} created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
