using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InvoiceRegister.Common.DomainModel
{
    [Table("Uzytkownik")]
    public class Uzytkownik
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Hasło { get; set; }

        public IList<Faktura> Faktury { get; set; }
        public IList<Sprzedawca> Sprzedawcy { get; set; }
        public IList<Klient> Klienci { get; set; }
        public IList<Pozycja_faktury> Pozycje_faktury { get; set; }

    }
}
