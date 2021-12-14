using eWallet.API.EfCore_Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eWallet.API.Data_Access.Repositories.Database.EfCore
{
    public class EwalletDbContext : IdentityDbContext<AppUser>
    {
        public EwalletDbContext(DbContextOptions<EwalletDbContext> options) : base(options)
        {

        }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }


        //protected override onModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AppUser>()
        //        .HasMany(x => x.Wallets)
        //        .WithOne(x => x.AppUser);
        //}
    }
}
