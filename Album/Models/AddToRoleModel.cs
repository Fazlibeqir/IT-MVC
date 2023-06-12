using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class AddToRoleModel
    {
        public string Email { get; set; }
        public string selectedRole { get; set; }
        public List<string> roles { get; set; }
      
    }
}