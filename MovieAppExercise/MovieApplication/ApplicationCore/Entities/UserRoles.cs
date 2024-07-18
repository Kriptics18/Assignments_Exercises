using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities {
    public class UserRoles {

        public int RoleId { get; set; }
        public Roles Role { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

    }
}
