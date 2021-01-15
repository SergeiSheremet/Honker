using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honker.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Nickname { get; set; }
        public DateTime RegistrationDate { get; set; }


        public IEnumerable<Honk> Honks { get; set; }
    }
}
