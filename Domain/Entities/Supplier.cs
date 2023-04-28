using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a supplier of goods.
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// The unique identifier for the supplier.
        /// </summary>
        [Key]
        public int SupplierID { get; set; }

        /// <summary>
        /// The name of the supplier.
        /// </summary>
        [Required]
        public string SupplierName { get; set; }

        /// <summary>
        /// The phone number of the supplier.
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The email of the supplier.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// The address of the supplier.
        /// </summary>
        [Required]
        public string Address { get; set; }
    }
}
