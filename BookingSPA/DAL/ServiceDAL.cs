using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSPA.DAL
{
    public class ServiceDAL
    {
        private readonly DbConnection dbConnection;
        public ServiceDAL()
        {
            dbConnection = new DbConnection();
        }
    }
}
