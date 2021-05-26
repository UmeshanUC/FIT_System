using FITSystem.Models;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class database : DbContext
    {
        public database() : base("FIT_db")
        { }


        public DbSet<LOGIN> LOGIN_SET { get; set; }
        public DbSet<PERMISSIONS> PERMISSIONS_SET { get; set; }
        public DbSet<LOGIN_LOG> LOGIN_LOG_SET { get; set; }
        public DbSet<WORK_ROLE> WORK_ROLE_SET { get; set; }

    }
    

}
