using Microsoft.EntityFrameworkCore;
using TelecomDB.Models;

namespace TelecomDB
{
    public class TelecomDatabase2 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-56G226H\SQLEXPRESS;Initial Catalog=TelecomDatabase2;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Service> Services { set; get; }
        public virtual DbSet<Tariff> Tariffs { set; get; }
    }
}