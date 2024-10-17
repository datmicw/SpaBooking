using System;
using BookingSPA.BLL;
using BookingSPA.DAL;
using BookingSPA.Entities;
using System.Windows.Forms;
using System.Diagnostics;

namespace BookingSPA.Forms
{
    public partial class ServiceForm : Form
    {
        private ServiceDAL serviceDAL;
        private ServiceBLL serviceBLL;
        private int selectedId;
        public ServiceForm()
        {
            InitializeComponent();
            serviceBLL = new ServiceBLL();
            serviceDAL = new ServiceDAL();
            dtg_service.CellClick += dtg_service_CellClick;
        }

        private void btn_addService_Click(object sender, EventArgs e)
        {

            string serviceName = txt_serviceName.Text;
            if (decimal.TryParse(txt_servicePrice.Text, out decimal servicePrice))
            {
                var service = new ServiceEnti
                {
                    Name = serviceName,
                    Price = servicePrice
                };
                try
                {
                    serviceDAL.AddService(service);
                    MessageBox.Show("Dịch vụ đã được thêm thành công");
                    LoadServiceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }
        private void LoadServiceData()
        {
            var service = serviceDAL.GetAllService();
            dtg_service.DataSource = service;
            dtg_service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void dtg_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_service.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txt_serviceName.Text = row.Cells["Name"].Value.ToString();
                txt_servicePrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            dtg_service.CellClick += dtg_service_CellClick;
            LoadServiceData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_servicePrice.Text, out decimal servicePrice))
            {
                var service = new ServiceEnti
                {
                    Id = selectedId,
                    Name = txt_serviceName.Text,
                    Price = servicePrice,
                };
                try
                {
                    serviceBLL.UpdateService(service);
                    MessageBox.Show("Dịch vụ đã được cập nhật thành công");
                    LoadServiceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var service = new ServiceEnti
            {
                Id = selectedId
            };
            try
            {
                serviceBLL.DeleteService(service);
                MessageBox.Show("Dịch vụ đã được xóa thành công");
                LoadServiceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
