using FITSystem.Models;
using System.Data.Entity;
using System.Threading;

namespace FITSystem.Database
{
    
    public class FitDb : DbContext
    {
        public FitDb() : base("FIT_db")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }


        public DbSet<Login> LoginSet { get; set; }
        public DbSet<Permissions> PermissionsSet { get; set; }
        public DbSet<LoginLog> LoginLogSet { get; set; }
        public DbSet<WorkRole> WorkRoleSet { get; set; }
        public DbSet<Branch> BranchSet { get; set; }
        public DbSet<BranchManager> BranchManagerSet { get; set; }
        public DbSet<Employee> EmployeeSet { get; set; }
        public DbSet<Item> ItemSet { get; set; }
        public DbSet<MedicalOfficer> MedicalOfficerSet { get; set; }
        public DbSet<Member> MemberSet { get; set; }
        public DbSet<Package> PackageSet { get; set; }
        public DbSet<Product> ProductSet { get; set; }
        public DbSet<SalaryProfile> SalaryProfileSet { get; set; }
        public DbSet<SalaryRate> SalaryRateSet { get; set; }
        public DbSet<Section> SectionSet { get; set; }
        public DbSet<Supplier> SupplierSet { get; set; }
        public DbSet<Trainer> TrainerSet { get; set; }
        public DbSet<TrainingProfile> TrainingProfileSet { get; set; }
        public DbSet<Transactions> TransactionSet { get; set; }
    }
    

}
