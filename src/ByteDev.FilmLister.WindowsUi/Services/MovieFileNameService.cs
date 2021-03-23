using System.Collections.Generic;
using System.IO;
using System.Linq;
using ByteDev.Io;
using ByteDev.VideoArchive;

namespace ByteDev.FilmLister.WindowsUi.Services
{
    public interface IMovieFileNameService
    {
        IList<MovieFileName> GetMovieFileNames(string folderPath);
    }

	public class MovieFileNameService : IMovieFileNameService
	{
		public IList<MovieFileName> GetMovieFileNames(string folderPath)
		{
		    var names = GetFiles(folderPath);

			return names.Select(x => new MovieFileName(x)).ToList();
		}

        private static IEnumerable<string> GetFiles(string folderPath)
        {
            var dirInfo = new DirectoryInfo(folderPath);

            return dirInfo.GetVideoFiles()
                .OrderBy(fi => fi.Name)
                .Select(fi => fi.Name)
                .ToList();
        }
    }
}