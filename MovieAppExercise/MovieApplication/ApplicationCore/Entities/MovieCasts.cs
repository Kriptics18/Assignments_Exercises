using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities {
    public class MovieCasts {

        public int CastId { get; set; }
        public Casts Cast { get; set; }

        public int MovieId { get; set; }
        public Movies Movie { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(450)")]
        public string Character { get; set; }

    }
}
