using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a receipt document.
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// The unique identifier for the receipt.
        /// </summary>
        [Key]
        public int ReceiptID { get; set; }

        /// <summary>
        /// The date of the receipt.
        /// </summary>
        [Required]
        public DateTime ReceiptDate { get; set; }

        /// <summary>
        /// The store object.
        /// </summary>
        [Required]
        public int StoreID { get; set; }
        [ForeignKey(nameof(StoreID))]
        public virtual Store Store { get; set; }

        /// <summary>
        /// The commodity object.
        /// </summary>
        [Required]
        public int CommodityID { get; set; }
        [ForeignKey(nameof(CommodityID))]
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// The supplier object.
        /// </summary>
        [Required]
        public int SupplierID { get; set; }
        [ForeignKey(nameof(SupplierID))]
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// The quantity of the commodity received.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// The price per unit of the commodity received.
        /// </summary>
        [Required]
        public decimal PricePerUnit { get; set; }
    }
}
