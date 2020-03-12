using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceRegister.Common.DomainModel
{
    [Table("Faktura")]
    public class Faktura
    {
        [Key]
        public int Id { get; set; }
        public string Numer { get; set; }
        public DateTime Data_wystawienia { get; set; }
        public DateTime Data_sprzedazy { get; set; }
        public string Sposob_platnosci { get; set; }
        public string Przedmiot_transakcji { get; set; }
        public double Suma { get; set; }
        public double Wplacono { get; set; }
        public string Uwagi { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        public Klient Klient { get; set; }
        public Sprzedawca Sprzedawca { get; set; }


    }
}
