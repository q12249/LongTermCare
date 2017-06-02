using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LongTermCare.Models
{
    public class User
    {
        [Required]
        [Display(Name = "帳號")]
        public string id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string pwd { get; set; }
        [Display(Name = "記住我?")]
        public bool RememberMe { get; set; }
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
