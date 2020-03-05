namespace InvoiceRegister.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InvoiceRegisterDBv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faktura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numer = c.String(),
                        Data_wystawienia = c.DateTime(nullable: false),
                        Data_sprzedazy = c.DateTime(nullable: false),
                        Sposob_platnosci = c.String(),
                        Suma = c.Double(nullable: false),
                        Wplacono = c.Double(nullable: false),
                        Uwagi = c.String(),
                        Klient_Id = c.Int(),
                        Uzytkownik_Id = c.Int(),
                        Sprzedawca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klient", t => t.Klient_Id)
                .ForeignKey("dbo.Uzytkownik", t => t.Uzytkownik_Id)
                .ForeignKey("dbo.Sprzedawca", t => t.Sprzedawca_Id)
                .Index(t => t.Klient_Id)
                .Index(t => t.Uzytkownik_Id)
                .Index(t => t.Sprzedawca_Id);
            
            CreateTable(
                "dbo.Klient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        NIP = c.String(),
                        PESEL = c.String(),
                        Miejscowosc = c.String(),
                        Kod_pocztowy = c.String(),
                        Ulica = c.String(),
                        Numer_domu = c.Int(nullable: false),
                        Numer_lokalu = c.Int(nullable: false),
                        Uzytkownik_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uzytkownik", t => t.Uzytkownik_Id)
                .Index(t => t.Uzytkownik_Id);
            
            CreateTable(
                "dbo.Uzytkownik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Hasło = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pozycja_faktury",
                c => new
                    {
                        Id_pozycja = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Ilosc = c.Int(nullable: false),
                        Jednostka_miary = c.String(),
                        Cena_netto = c.Double(nullable: false),
                        Cena_brutto = c.Double(nullable: false),
                        Faktura_Id = c.Int(),
                        Uzytkownik_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id_pozycja)
                .ForeignKey("dbo.Faktura", t => t.Faktura_Id)
                .ForeignKey("dbo.Uzytkownik", t => t.Uzytkownik_Id)
                .Index(t => t.Faktura_Id)
                .Index(t => t.Uzytkownik_Id);
            
            CreateTable(
                "dbo.Sprzedawca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        NIP = c.String(),
                        PESEL = c.String(),
                        Miejscowosc = c.String(),
                        Kod_pocztowy = c.String(),
                        Ulica = c.String(),
                        Numer_domu = c.Int(nullable: false),
                        Numer_lokalu = c.Int(nullable: false),
                        Uzytkownik_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uzytkownik", t => t.Uzytkownik_Id)
                .Index(t => t.Uzytkownik_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sprzedawca", "Uzytkownik_Id", "dbo.Uzytkownik");
            DropForeignKey("dbo.Faktura", "Sprzedawca_Id", "dbo.Sprzedawca");
            DropForeignKey("dbo.Pozycja_faktury", "Uzytkownik_Id", "dbo.Uzytkownik");
            DropForeignKey("dbo.Pozycja_faktury", "Faktura_Id", "dbo.Faktura");
            DropForeignKey("dbo.Klient", "Uzytkownik_Id", "dbo.Uzytkownik");
            DropForeignKey("dbo.Faktura", "Uzytkownik_Id", "dbo.Uzytkownik");
            DropForeignKey("dbo.Faktura", "Klient_Id", "dbo.Klient");
            DropIndex("dbo.Sprzedawca", new[] { "Uzytkownik_Id" });
            DropIndex("dbo.Pozycja_faktury", new[] { "Uzytkownik_Id" });
            DropIndex("dbo.Pozycja_faktury", new[] { "Faktura_Id" });
            DropIndex("dbo.Klient", new[] { "Uzytkownik_Id" });
            DropIndex("dbo.Faktura", new[] { "Sprzedawca_Id" });
            DropIndex("dbo.Faktura", new[] { "Uzytkownik_Id" });
            DropIndex("dbo.Faktura", new[] { "Klient_Id" });
            DropTable("dbo.Sprzedawca");
            DropTable("dbo.Pozycja_faktury");
            DropTable("dbo.Uzytkownik");
            DropTable("dbo.Klient");
            DropTable("dbo.Faktura");
        }
    }
}
