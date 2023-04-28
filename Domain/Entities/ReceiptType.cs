using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a type of receipt for a warehouse.
    /// </summary>
    public class ReceiptType
    {
        /// <summary>
        /// Gets or sets the receipt type ID.
        /// </summary>
        [Key]
        public int ReceiptTypeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the receipt type.
        /// </summary>
        [Required]
        public string ReceiptTypeName { get; set; }
    }
}
