using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Database
{
    public class database : DbContext
    {
        public database() : base("FIT_db")
        { }


        public DbSet<User> User_Set { get; set; }
        public DbSet<Login> Login_Set { get; set; }
        public DbSet<UserLoginLog> LoginLog_Set { get; set; }

    }
    

}
