using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Country
    {
        /// <summary>
        /// Gets or sets the country ID.
        /// </summary>
        [Key]
        public int CountryID { get; set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        [Required]
        public string Name { get; set; }
    }

}
