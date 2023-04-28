using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class StoreType
    {
        /// <summary>
        /// The ID of the store type.
        /// </summary>
        [Key]
        public int TypeID { get; set; }

        /// <summary>
        /// The name of the store type.
        /// </summary>
        public string TypeName { get; set; }
    }
}
