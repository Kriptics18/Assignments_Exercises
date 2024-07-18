using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities {
    public class Purchases {

        public int MovieId { get; set; }
        public Movies Movie { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime PurchaseDateTime { get; set; }

        [Required]
        public Guid PurchaseNumber { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal TotalPrice { get; set; }

    }
}
