using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities {
    public class Reviews {

        public int MovieId { get; set; }
        public Movies Movie { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(3, 2)")]
        public decimal Rating { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string ReviewText { get; set; }

    }
}
