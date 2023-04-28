using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ReceiptDetail
    {
        [Key]
        public int ReceiptID { get; set; } // شناسه فاکتور (کلید اصلی)

        [Required]
        public int Quantity { get; set; } // تعداد کالا (مقدار آیتم در فاکتور)

        [Required]
        public string Description { get; set; }

        [Required]
        public double UnitPrice { get; set; } // قیمت واحد کالا (قیمت آیتم در فاکتور)

        [Required]
        public int ReceiptTypeID { get; set; } // شناسه نوع فاکتور (وارداتی یا خروجی) - خودشون اضافه کردند
        [ForeignKey(nameof(ReceiptTypeID))]
        public virtual ReceiptType ReceiptType { get; set; } // رابطه با کلاس ReceiptType (هر ReceiptDetail یک ReceiptType دارد)

        [Required]
        public DateTime ReceiptDate { get; set; } // تاریخ فاکتور - خودشون اضافه کردند

        [Required]
        public int CommodityID { get; set; } // شناسه کالا (اسم آیتم در فاکتور)
        [ForeignKey(nameof(CommodityID))]
        public virtual Commodity Commodity { get; set; } // رابطه با کلاس Commodity (هر ReceiptDetail یک Commodity دارد)


    }
}
