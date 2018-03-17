namespace MVCApp.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerVerificationContext : DbContext
    {
        public CustomerVerificationContext()
            : base("name=CustomerVerificationContext")
        {
        }

        public virtual DbSet<verification> verification { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
