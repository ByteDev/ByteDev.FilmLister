using System;
using System.Collections.Generic;
using ByteDev.Collections.Sequences;

namespace ByteDev.FilmLister.WindowsUi.Services
{
    public static class YearService
    {
        public static IEnumerable<int> GetYears()
        {
            const int startYear = 1920;

            return Sequencer.Arithmetic(DateTime.Now.Year - startYear + 1, startYear, 1);  // 1920 - 2021
        }
    }
}