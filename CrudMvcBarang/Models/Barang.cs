using System.ComponentModel.DataAnnotations;

namespace CrudMvcBarang.Models
{
    public class Barang
    {
        public int Id { get; set; }

        [Required]
        public string NamaBarang { get; set; }

        [Required]
        public decimal Harga { get; set; }

        [Required]
        public int Stok { get; set; }
    }
}
