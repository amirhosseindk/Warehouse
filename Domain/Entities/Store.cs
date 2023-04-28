using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a store of a commodity in a warehouse.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Gets or sets the store ID.
        /// </summary>
        [Key]
        public int StoreID { get; set; }

        /// <summary>
        /// Gets or sets the commodity ID.
        /// </summary>
        [Required]
        public int CommodityID { get; set; }
        [ForeignKey(nameof(CommodityID))]
        public virtual Commodity Commodity { get; set; }

        [Required]
        public DateTime LastAction { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the commodity in the store.
        /// </summary>
        [Required]
        public int Stock { get; set; }

        [Required]
        public int StoreTypeID { get; set; }

        [ForeignKey(nameof(StoreTypeID))]
        public virtual StoreType StoreType { get; set; }
    }
}
