using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InvoiceRegister.Common.DomainModel
{
    [Table("Klient")]
    public class Klient
    {
        [Key]
        public int Id { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public string PESEL { get; set; }
        public string Miejscowosc { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Ulica { get; set; }
        public int Numer_domu { get; set; }
        public int Numer_lokalu { get; set; }

        public IList<Faktura> Faktury { get; set; }
    }
}
