using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongTermCare.Models
{
    public class User
    {
        public string id { get; set; }
        public string pwd { get; set; }
    }
    
    public class User_Result
    {
        public string id { get; set; }
        public string name { get; set; }

        public DateTime offdate { get; set; }
    }
}
