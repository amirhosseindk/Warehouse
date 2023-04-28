using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a detail of a transfer document.
    /// </summary>
    public class TransferDetail
    {
        /// <summary>
        /// Gets or sets the ID of the transfer detail.
        /// </summary>
        [Key]
        public int TransferDetailID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the transfer document.
        /// </summary>
        [Required]
        public int TransferID { get; set; }

        [ForeignKey(nameof(TransferID))]
        public virtual StockTransfer StockTransfer { get; set; }

        /// <summary>
        /// Gets or sets the ID of the commodity being transferred.
        /// </summary>
        [Required]
        public int CommodityID { get; set; }

        [ForeignKey(nameof(CommodityID))]
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the commodity being transferred.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the description of the transfer detail.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the transferred commodity.
        /// </summary>
        [Required]
        public decimal Price { get; set; }
    }
}
