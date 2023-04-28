using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TransferType
    {
        /// <summary>
        /// The ID of the transfer type.
        /// </summary>
        [Key]
        public int TypeID { get; set; }

        /// <summary>
        /// The name of the transfer type.
        /// </summary>
        public string TypeName { get; set; }
    }
}
