using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class DocType
    {
        [Key]
        public int DocTypeID { get; set; }

        public string DocTypeName { get; set; }
    }
}
