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
            serviceDAL.DeleteService(service);
        }
        private void ValidateService(ServiceEnti service)
        {
            if (string.IsNullOrWhiteSpace(service.Name))
                throw new ArgumentException("Tên không được để trống.");

            if (service.Price == null || service.Price == 0)
                throw new ArgumentException("Gía không được để trống hoặc bằng 0.");
        }
    }
    
}
