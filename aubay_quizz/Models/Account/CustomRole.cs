using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aubay_quizz.Models
{
    public class CustomRole : IdentityRole<int>
    {
        public CustomRole(string roleName) : base(roleName)
        {
        }
    }
}
