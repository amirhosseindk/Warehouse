using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a commodity or a product.
    /// </summary>
    public class Commodity
    {
        /// <summary>
        /// The unique identifier for the commodity.
        /// </summary>
        [Key]
        public int CommodityID { get; set; }

        /// <summary>
        /// The name of the commodity.
        /// </summary>
        [Required]
        public string CommodityName { get; set; }

        /// <summary>
        /// The unit of measurement for the commodity.
        /// </summary>
        [Required]
        public int UnitID { get; set; }
        [ForeignKey(nameof(UnitID))]
        public virtual Unit Unit { get; set; }

        [Required]
        public Decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the ID of the country where the commodity was made.
        /// </summary>
        public int? MadeinCountryCountryID { get; set; }
        [ForeignKey(nameof(MadeinCountryCountryID))]
        public virtual Country MadeinCountry { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
        public virtual ICollection<InventoryTurnover> InventoryTurnovers { get; set; }
        public virtual ICollection<TransferDetail> TransferDetails { get; set; }
    }
}
