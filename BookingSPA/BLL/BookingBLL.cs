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
        public void UpdateBooking(BookingEnti book)
        {
            ValidateBooking(book);
            bookingDAL.UpdateBooking(book);
        }

        private void ValidateBooking(BookingEnti book)
        {
            if (string.IsNullOrWhiteSpace(book.CustomerName))
                throw new ArgumentException("Name Of Customer not empty !");

            if (string.IsNullOrWhiteSpace(book.Status))
                throw new ArgumentException("Status not empty !");

        }
    }
}
