using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
        {

        }

        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Country> MadeinCountries { get; set; }
        public DbSet<InventoryTurnover> InventoryTurnovers { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptType> ReceiptTypes { get; set; }
        public DbSet<StockTransfer> StockTransfers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreCommodity> StoreCommodities { get; set; }
        public DbSet<StoreType> StoreTypes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<TransferType> TransferTypes { get; set; }
        public DbSet<TransferDetail> TransferDetails { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //modelBuilder.Entity<Commodity>().HasOne<Country>(c => c.Country)
            //    .WithMany(c => c.Commodities)
            //    .HasForeignKey(c => c.CountryID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<MadeinCountry>().HasOne<Country>(m => m.Country)
            //    .WithMany(c => c.MadeinCountries)
            //    .HasForeignKey(m => m.CountryID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<StoreCommodity>().HasKey(sc => new { sc.StoreID, sc.CommodityID });
            //modelBuilder.Entity<StoreCommodity>().HasOne<Store>(sc => sc.Store)
            //    .WithMany(s => s.StoreCommodities)
            //    .HasForeignKey(sc => sc.StoreID)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<StoreCommodity>().HasOne<Commodity>(sc => sc.Commodity)
            //    .WithMany(c => c.StoreCommodities)
            //    .HasForeignKey(sc => sc.CommodityID)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=myDataBase;Trusted_Connection=True;TrustServerCertificate=true");
            optionsBuilder.UseSqlServer("Server=.;Database=myDataBase;User Id=sa;Password=P@ssw0rd09198799866;TrustServerCertificate=true");

        }
    }
}
