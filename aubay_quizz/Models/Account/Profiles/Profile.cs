using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aubay_quizz.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }

        public int UserId { get; set; }
        public CustomUser User { get; set; }
    }
}
