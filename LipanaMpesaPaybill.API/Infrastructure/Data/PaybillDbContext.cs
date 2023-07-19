using LipanaMpesaPaybill.API.Core;
using Microsoft.EntityFrameworkCore;


namespace LipanaMpesaPaybill.API.Infrastructure.Data
{
    public class PaybillDbContext : DbContext
    {
        public PaybillDbContext(DbContextOptions<PaybillDbContext> options) : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.HasIndex(i => new { i.TransID }).IsUnique();
            });
        }
    }

}
