using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Represents the relationship between a store and a commodity.
    /// </summary>
    public class StoreCommodity
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the store ID.
        /// </summary>
        public int StoreID { get; set; }
        [ForeignKey(nameof(StoreID))]
        public virtual Store Store { get; set; }

        /// <summary>
        /// Gets or sets the commodity ID.
        /// </summary>
        public int CommodityID { get; set; }
        [ForeignKey(nameof(CommodityID))]
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the commodity in the store.
        /// </summary>
        [Required]
        public int Stock { get; set; }
    }
}
