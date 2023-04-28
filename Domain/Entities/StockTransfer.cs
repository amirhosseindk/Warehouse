using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    /// <summary>
    /// Class representing a stock transfer document.
    /// </summary>
    public class StockTransfer
    {
        /// <summary>
        /// The unique identifier for the stock transfer.
        /// </summary>
        [Key]
        public int TransferID { get; set; }

        /// <summary>
        /// The transfer type object.
        /// </summary>
        [Required]
        public int TransferTypeID { get; set; }
        [ForeignKey(nameof(TransferTypeID))]
        public virtual TransferType TransferType { get; set; }

        /// <summary>
        /// The date of the transfer.
        /// </summary>
        [Required]
        public DateTime TransferDate { get; set; }

        [Required]
        public int StoreID { get; set; }
        [ForeignKey(nameof(StoreID))]
        public virtual Store Store { get; set; }

        [Required]
        public int ConsumerID { get; set; }
        [ForeignKey(nameof(ConsumerID))]
        public virtual Consumer Consumer { get; set; }

    }
}
