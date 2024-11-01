using System;
using BookingSPA.Entities;
using BookingSPA.DAL;

namespace BookingSPA.BLL
{
    public class ServiceBLL
    {
        private readonly ServiceDAL serviceDAL;

        public ServiceBLL()
        {
            serviceDAL = new ServiceDAL();
        }

        public void AddService(ServiceEnti service)
        {
            ValidateService(service);
            serviceDAL.AddService(service);
        }

        public void UpdateService(ServiceEnti service)
        {
            ValidateService(service);
            serviceDAL.UpdateService(service);
        }

        public void DeleteService(ServiceEnti service)
        {
            if (service == null)
                throw new ArgumentNullException(nameof(service), "Service cannot be null.");
            serviceDAL.DeleteService(service);
        }

        private void ValidateService(ServiceEnti service)
        {
            if (string.IsNullOrWhiteSpace(service.Name))
                throw new ArgumentException("Service name cannot be empty.", nameof(service.Name));

            if (service.Price <= 0)
                throw new ArgumentException("Price must be greater than zero.", nameof(service.Price));
        }
    }
}