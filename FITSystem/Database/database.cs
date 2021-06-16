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
        public DbSet<BRANCH> BRANCH_SET { get; set; }
        public DbSet<BRANCH_MANAGER> BRANCH_MANAGER_SET { get; set; }
        public DbSet<EMPLOYEE> EMPLOYEE_SET { get; set; }
        public DbSet<ITEM> ITEM_SET { get; set; }
        public DbSet<MEDICAL_OFFICER> MEDICAL_OFFICER_SET { get; set; }
        public DbSet<MEMBER> MEMBER_SET { get; set; }
        public DbSet<PACKAGE> PACKAGE_SET { get; set; }
        public DbSet<PRODUCT> PRODUCT_SET { get; set; }
        public DbSet<SALARY_PROFILE> SALARY_PROFILE_SET { get; set; }
        public DbSet<SALARY_RATE> SALARY_RATE_SET { get; set; }
        public DbSet<SECTION> SECTION_SET { get; set; }
        public DbSet<SUPPLIER> SUPPLIER_SET { get; set; }
        public DbSet<TRAINER> TRAINER_SET { get; set; }
        public DbSet<TRAINING_PROFILE> TRAINING_PROFILE_SET { get; set; }
        public DbSet<TRANSACTIONS> TRANSACTION_SET { get; set; }
    }
    

}
