using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LongTermCare.Models
{
    public class User
    {
        public string id { get; set; }
        public string pwd { get; set; }
    }
    
    public class UserInfo
    {
        [Key]
        public string userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime? offdate { get; set; }
    }
}
