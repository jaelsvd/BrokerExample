using System.Data.Entity;
using AppBroker.Entities;

namespace AppBroker.DAL
{
    public class BrokerDBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public BrokerDBContext() :base("BrokerDbConnName")
        {

        }

        public DbSet<BrokerInfo> BrokerInfo { get; set; }

    }
}
