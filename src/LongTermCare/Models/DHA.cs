using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace LongTermCare.Models
{
    public partial class DHADBContext: DbContext
    {
        public DHADBContext(DbContextOptions options)
            :base(options)
        {
        }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}
