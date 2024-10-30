using System;

namespace BookingSPA.Entities
{
    public class BookingEnti
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string StaffName { get; set; }
        public string ServiceName { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
        public Decimal TotalAmount { get; set; }
        public int Time {  get; set; }

        public EmployeeEnti Employee { get; set; }
        public ServiceEnti Service { get; set; }
    }
}
