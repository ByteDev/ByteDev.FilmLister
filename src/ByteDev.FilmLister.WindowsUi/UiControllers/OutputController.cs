using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ByteDev.VideoArchive;

namespace ByteDev.FilmLister.WindowsUi.UiControllers
{
	public class OutputController
	{
		private readonly TextBox _textBox;

	    public OutputController(TextBox textBox)
		{
			_textBox = textBox;
		}

        public void PrintFilmList(IList<MovieFileName> films)
		{
            _textBox.Clear();

			MovieFileName previous = null;

			foreach (var film in films)
			{
				if (previous == null)
				{
                    _textBox.PrintLine(Path.GetFileNameWithoutExtension(film.ToString()));
				}
				else
				{
					if (IsDiffYear(film, previous))
                        _textBox.PrintLine();

					if (previous.ToString() != film.ToString())
                        _textBox.PrintLine(Path.GetFileNameWithoutExtension(film.ToString()));
				}

				previous = film;
			}
		}

        public void Clear()
        {
            _textBox.Clear();
        }

		private bool IsDiffYear(MovieFileName film1, MovieFileName film2)
		{
			if (film1 == null || film2 == null)
				return false;

            return film1.Year != film2.Year;
		}
    }
}
