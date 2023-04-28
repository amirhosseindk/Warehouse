using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a record of the inventory turnover of a commodity in a store.
    /// </summary>
    public class InventoryTurnover
    {
        /// <summary>
        /// Gets or sets the ID of the inventory turnover record.
        /// </summary>
        [Key]
        public int DocID { get; set; }

        /// <summary>
        /// Gets or sets the date of the inventory turnover.
        /// </summary>
        [Required]
        public DateTime DocDate { get; set; }

        /// <summary>
        /// Gets or sets the ID of the commodity involved in the inventory turnover.
        /// </summary>
        [Required]
        public int CommodityID { get; set; }
        [ForeignKey(nameof(CommodityID))]
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// Gets or sets the ID of the store involved in the inventory turnover.
        /// </summary>
        [Required]
        public int StoreID { get; set; }
        [ForeignKey(nameof(StoreID))]
        public virtual Store Store { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the commodity involved in the inventory turnover.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the ID of the store commodity record that this inventory turnover record corresponds to.
        /// </summary>
        [Required]
        public int StoreCommodityID { get; set; }
        [ForeignKey(nameof(StoreCommodityID))]
        public virtual StoreCommodity StoreCommodity { get; set; }

        [Required]
        public int DocTypeID { get; set; }

        [ForeignKey(nameof(DocTypeID))]
        public virtual DocType DocType { get; set; }

        [Required]
        public int RemindeStock { get; set; }

        [Required]
        public int ConsumerID { get; set; }
        [ForeignKey(nameof(ConsumerID))]
        public virtual Consumer Consumer { get; set; }
    }
}
