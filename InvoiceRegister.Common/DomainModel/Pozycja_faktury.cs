using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InvoiceRegister.Common.DomainModel
{
    [Table("Pozycja_faktury")]
    public class Pozycja_faktury
    {
        [Key]
        public int Id_pozycja{ get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        public Faktura Faktura { get; set; }
        public string Nazwa{ get; set; }
        public int Ilosc { get; set; }
        public string Jednostka_miary { get; set; }
        public double Cena_netto { get; set; }
        public double Cena_brutto { get; set; }
    }
}
