using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities {
    public class Users {

        
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        [MaxLength(128)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(1024)]
        public string HashedPassword { get; set; }

        public bool IsLocked { get; set; }

        [Required]
        [MaxLength(128)]
        public string LastName { get; set; }

        [MaxLength(16)]
        public string PhoneNumber { get; set; }

        public string ProfilePictureUrl { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Salt { get; set; }

        public ICollection<Favorites> Favorites { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<Purchases> Purchases { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }

    }
}
