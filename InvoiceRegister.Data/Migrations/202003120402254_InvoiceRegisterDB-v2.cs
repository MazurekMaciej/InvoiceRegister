namespace InvoiceRegister.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InvoiceRegisterDBv2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pozycja_faktury", "Faktura_Id", "dbo.Faktura");
            DropForeignKey("dbo.Pozycja_faktury", "Uzytkownik_Id", "dbo.Uzytkownik");
            DropIndex("dbo.Pozycja_faktury", new[] { "Faktura_Id" });
            DropIndex("dbo.Pozycja_faktury", new[] { "Uzytkownik_Id" });
            AddColumn("dbo.Faktura", "Przedmiot_transakcji", c => c.String());
            DropTable("dbo.Pozycja_faktury");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id_pozycja);
            
            DropColumn("dbo.Faktura", "Przedmiot_transakcji");
            CreateIndex("dbo.Pozycja_faktury", "Uzytkownik_Id");
            CreateIndex("dbo.Pozycja_faktury", "Faktura_Id");
            AddForeignKey("dbo.Pozycja_faktury", "Uzytkownik_Id", "dbo.Uzytkownik", "Id");
            AddForeignKey("dbo.Pozycja_faktury", "Faktura_Id", "dbo.Faktura", "Id");
        }
    }
}
