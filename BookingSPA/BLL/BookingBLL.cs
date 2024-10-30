using BookingSPA.DAL;
using BookingSPA.Entities;
using System;

namespace BookingSPA.BLL
{
    public class BookingBLL
    {
        private readonly BookingDAL bookingDAL;

        public BookingBLL()
        {
            bookingDAL = new BookingDAL();
        }

        public void AddBooking(BookingEnti book)
        {
            ValidateBooking(book);
            bookingDAL.AddBooking(book);
        }

        private void ValidateBooking(BookingEnti book)
        {
            if (string.IsNullOrWhiteSpace(book.CustomerName))
                throw new ArgumentException("Mã khách hàng phải lớn hơn 0.");

            if (string.IsNullOrWhiteSpace(book.Status))
                throw new ArgumentException("Mã nha vien phải lớn hơn 0");

        }
    }
}
