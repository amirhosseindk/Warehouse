using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    /// <summary>
    /// کلاسی برای نمایش مصرف کنندگان
    /// </summary>
    public class Consumer
    {
        /// <summary>
        /// The ID of the consumer.
        /// </summary>
        [Key]
        public int ConsumerID { get; set; }

        /// <summary>
        /// The name of the consumer.
        /// </summary>
        [Required]
        public string ConsumerName { get; set; }

        /// <summary>
        /// The phone number of the consumer.
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The email of the consumer.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// The address of the consumer.
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// The Agent Name of the consumer.
        /// </summary>
        [Required]
        public string AgentName { get; set; }
    }
}
