using BookingSPA.BLL;
using BookingSPA.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookingSPA.Forms
{
    public partial class Booking : Form
    {
        private BookingDAL bookingDAL;
        private ServiceDAL serviceDAL;

        public Booking()
        {
            InitializeComponent();
            bookingDAL = new BookingDAL();
            serviceDAL = new ServiceDAL();
        }

        private void LoadServiceNames()
        {
            try
            {
                var services = serviceDAL.GetAllService();
                cbx_serviceName.Items.Clear();
                if (services.Count == 0)
                {
                    MessageBox.Show("Không có dịch vụ nào trong cơ sở dữ liệu.");
                    return;
                }
                foreach (var service in services)
                {
                    cbx_serviceName.Items.Add(service.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadServiceNames();
        }
        private void cbx_serviceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServiceName = cbx_serviceName.SelectedItem.ToString();

            var service = serviceDAL.GetAllService().FirstOrDefault(s => s.Name == selectedServiceName);

            if (service != null)
            {
                lb_Price.Text = $"{service.Price} VNĐ/60 minutes"; 
                CalculateTotal(); 
            }
        }
        private void txt_Time_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal(); 
        }
        private void CalculateTotal()
        {
            if (decimal.TryParse(lb_Price.Text.Split(' ')[0], out decimal price)) 
            {
                if (int.TryParse(txt_Time.Text, out int time))
                {
                    decimal total = price * time;

                    lbl_total.Text = $"{total} VNĐ";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thời gian hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Giá dịch vụ không hợp lệ.");
            }
        }

        private void txt_Time_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}
