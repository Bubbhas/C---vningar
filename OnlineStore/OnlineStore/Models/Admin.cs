using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Admin
    {
        public string Email { get; set; }
        public string RoleName { get; set; }
    }
}

