using BookingSPA.BLL;
using BookingSPA.DAL;
using BookingSPA.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookingSPA.Forms
{
    public partial class Booking : Form
    {
        private BookingDAL bookingDAL;
        private ServiceDAL serviceDAL;
        private EmployeeDAL employeeDAL;
        private int selectedId;

        public Booking()
        {
            InitializeComponent();
            bookingDAL = new BookingDAL();
            serviceDAL = new ServiceDAL();
            employeeDAL = new EmployeeDAL();
            dgt_booking.CellClick += dgt_booking_CellClick;
            LoadBookingData();

        }
        private void LoadBookingData()
        {
            var book = bookingDAL.GetAllBooking();
            dgt_booking.DataSource = book;
            dgt_booking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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

        private void LoadStaff()
        {
            try
            {
                var staff = employeeDAL.GetAllEmployees();
                cbx_staff.Items.Clear();
                if (staff.Count == 0)
                {
                    MessageBox.Show("Không có staff nào trong cơ sở dữ liệu.");
                    return;
                }
                foreach (var employee in staff)
                {
                    cbx_staff.Items.Add(employee.FullName);
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
            LoadStaff();
            LoadBookingData();
            dgt_booking.CellClick += dgt_booking_CellClick;
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

        private void txt_Time_TextChanged_1(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Giá dịch vụ không hợp lệ.");
            }
        }

        private void btn_AddBooking_Click(object sender, EventArgs e)
        {

            try
            {
                decimal totalAmount = decimal.Parse(lbl_total.Text.Replace(" VNĐ", "").Trim());

                var booking = new BookingEnti
                {
                    CustomerName = txt_custumerName.Text,
                    ServiceName = cbx_serviceName.SelectedItem?.ToString(), 
                    StaffName = cbx_staff.SelectedItem?.ToString(),
                    BookingDate = DateTime.Now,
                    Status = txt_status.Text,
                    TotalAmount = totalAmount,
                    Time = int.TryParse(txt_Time.Text, out int time) ? time : 0
                };

                bookingDAL.AddBooking(booking); 
                MessageBox.Show("Đặt lịch thành công!");
                LoadBookingData();
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin ");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount = decimal.Parse(lbl_total.Text.Replace(" VNĐ", "").Trim());

                var booking = new BookingEnti
                {
                    Id = selectedId,
                    CustomerName = txt_custumerName.Text,
                    ServiceName = cbx_serviceName.SelectedItem?.ToString(),
                    StaffName = cbx_staff.SelectedItem?.ToString(),
                    BookingDate = DateTime.Now,
                    Status = txt_status.Text,
                    TotalAmount = totalAmount,
                    Time = int.TryParse(txt_Time.Text, out int time) ? time : 0
                };

                bookingDAL.UpdateBooking(booking);
                MessageBox.Show("Cập nhật lịch thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lịch: " + ex.Message);
            }
        }

        private void dgt_booking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo hàng được nhấn là hợp lệ
            {
                DataGridViewRow row = dgt_booking.Rows[e.RowIndex];

                // Kiểm tra và gán giá trị cho các trường
                txt_custumerName.Text = row.Cells["CustomerName"].Value?.ToString();
                cbx_serviceName.SelectedItem = row.Cells["ServiceName"].Value?.ToString();
                cbx_staff.SelectedItem = row.Cells["StaffName"].Value?.ToString();
                txt_status.Text = row.Cells["Status"].Value?.ToString();
                txt_Time.Text = row.Cells["Time"].Value?.ToString();
                lbl_total.Text = row.Cells["TotalAmount"].Value?.ToString();
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }

    }
}
