using System;
using System.Collections.Generic;

namespace NeelyFood.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsReservation { get; set; } // طلب يومي أو حجز مستقبلي
        public decimal TotalAmount { get; set; }
        public string PaymentImage { get; set; } // صورة الدفع
        public string AdminMessage { get; set; } // رسالة اختيارية من المدير
        public string Status { get; set; } // "Pending", "Accepted", "Rejected"
        public DateTime? ReservationDate { get; set; } // لحفظ تاريخ الحجز
         public string BankAccount { get; set; } // رقم الحساب البنكي (يمكن تخزينه هنا أو في إعدادات)


        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
