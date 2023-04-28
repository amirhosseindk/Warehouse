using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Warehouse
    {
        [Key]
        public int ReceiptID { get; set; }

        [Required]
        public int StoreID { get; set; }

        [ForeignKey(nameof(StoreID))]
        public Store Store { get; set; }

        [Required]
        public int ReceiptTypeID { get; set; }

        [ForeignKey(nameof(ReceiptTypeID))]
        public virtual ReceiptType ReceiptType { get; set; }

        [Required]
        public DateTime ReceiptDate { get; set; }

        [Required]
        public int SupplierID { get; set; }

        [ForeignKey(nameof(SupplierID))]
        public virtual Supplier Supplier { get; set; }
    }


}
