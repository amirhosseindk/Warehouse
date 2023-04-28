using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Unit
    {
        /// <summary>
        /// Gets or sets the unit ID.
        /// </summary>
        [Key]
        public int UnitID { get; set; }

        /// <summary>
        /// Gets or sets the unit name.
        /// </summary>
        [Required]
        public string UnitName { get; set; }
    }

}
