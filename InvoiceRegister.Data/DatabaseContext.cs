using InvoiceRegister.Common.DomainModel;
using System;
using System.Data.Entity;

namespace InvoiceRegister.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=InvoiceRegisterDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Migrations.Configuration>());
        }

        public virtual DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public virtual DbSet<Klient> Klienci { get; set; }
        public virtual DbSet<Sprzedawca> Sprzedawcy { get; set; }
        public virtual DbSet<Faktura> Faktury { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
