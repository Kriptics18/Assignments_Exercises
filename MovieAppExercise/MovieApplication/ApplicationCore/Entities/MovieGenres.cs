using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities {
    public class MovieGenres {

        public int GenreId { get; set; }
        public Genres Genre { get; set; }

        public int MovieId { get; set; }
        public Movies Movie { get; set; }

    }
}
