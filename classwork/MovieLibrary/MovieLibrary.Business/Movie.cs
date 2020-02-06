using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Business
{
    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// Lots of info.
    /// </remarks>
    public class Movie
    {
        public string title;

        /// <summary>Run length in minutes.</summary>
        public int runLength;

        public string description;

        public int releaseYear = 1900;

        public bool isClassic;
    }
}
