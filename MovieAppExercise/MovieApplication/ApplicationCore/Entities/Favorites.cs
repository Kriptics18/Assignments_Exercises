using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities {
    public class Favorites {

        public int MovieId { get; set; }
        public Movies Movie { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

    }
}
