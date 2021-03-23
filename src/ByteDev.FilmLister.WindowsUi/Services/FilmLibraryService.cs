using System.Collections.Generic;
using System.IO;
using ByteDev.VideoArchive;

namespace ByteDev.FilmLister.WindowsUi.Services
{
	public class FilmLibraryService
	{
		private readonly IMovieFileNameService _movieFileNameService;

		public FilmLibraryService(IMovieFileNameService movieFileNameService)
		{
			_movieFileNameService = movieFileNameService;
		}

		public IList<MovieFileName> ListAllMovieFileNames(string rootPath)
        {
			var movieFileNames = new List<MovieFileName>();
			
			foreach(var year in YearService.GetYears())
			{
			    try
			    {
                    var movies = GetFilmsFilesFor(rootPath, year);

                    movieFileNames.AddRange(movies);
			    }
                catch (DirectoryNotFoundException)
                {
                    // Ignore year folders that don't exist
                }
			}
			
		    return movieFileNames;
		}

        private IEnumerable<MovieFileName> GetFilmsFilesFor(string rootPath, int year)
		{
			var path = Path.Combine(rootPath, year.ToString());

			return _movieFileNameService.GetMovieFileNames(path);
		}
    }
}
