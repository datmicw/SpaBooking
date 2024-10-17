using BookingSPA.BLL;
using BookingSPA.DAL;
using BookingSPA.Entities;
using System;
using System.Windows.Forms;

namespace BookingSPA
{
    public partial class EmployeeForm : Form
    {
        private EmployeeBLL employeeBLL;
        private EmployeeDAL employeeDAL;
        private int selectedId;
        public EmployeeForm()
        {   
            InitializeComponent();
            employeeBLL = new EmployeeBLL();
            employeeDAL = new EmployeeDAL();
            LoadPositions();
            LoadEmployeeData();
            dtg_view.CellClick += dtg_view_CellClick;
        }   

        private void LoadPositions()
        {
            cbx_position.Items.Add("Manager");
            cbx_position.Items.Add("Staff");
            cbx_position.Items.Add("Receptionist");
            cbx_position.Items.Add("Therapist");
        }
        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            var employee = new EmployeeEnti
            {
                FullName = txt_fullname.Text,
                Position = cbx_position.SelectedItem?.ToString(),
                Phone = txt_phone.Text,
                DateHired = dtp_DateHired.Value,
            };
            try
            {
                employeeBLL.AddEmployee(employee);
                MessageBox.Show("Nhân viên đã được thêm thành công");
                ClearField();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void ClearField()
        {
            txt_fullname.Clear();
            cbx_position.SelectedIndex = -1;
            txt_phone.Clear();
        }
        private void LoadEmployeeData()
        {
            var employees = employeeDAL.GetAllEmployees(); 
            dtg_view.DataSource = employees;
            dtg_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dtg_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_view.Rows[e.RowIndex];

                txt_fullname.Text = row.Cells["FullName"].Value.ToString();
                cbx_position.SelectedItem = row.Cells["Position"].Value.ToString();
                txt_phone.Text = row.Cells["Phone"].Value.ToString();
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                if (row.Cells["DateHired"].Value != null && row.Cells["DateHired"].Value != DBNull.Value)
                {
                    DateTime dateHired;
                    if (DateTime.TryParse(row.Cells["DateHired"].Value.ToString(), out dateHired))
                    {
                        dtp_DateHired.Value = dateHired;
                    }
                }
                else
                {
                    dtp_DateHired.Value = DateTime.Now; 
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var employee = new EmployeeEnti
            {
                Id = selectedId,
                FullName = txt_fullname.Text,
                Position = cbx_position.SelectedItem?.ToString(),
                Phone = txt_phone.Text,
                DateHired = dtp_DateHired.Value,
            };
            try
            {
                employeeBLL.UpdateEmployee(employee);
                MessageBox.Show("Nhân viên đã được cập nhật thành công");
                LoadEmployeeData(); 
                ClearField(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadPositions();
            LoadEmployeeData();
            dtg_view.CellClick += dtg_view_CellClick;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var employee = new EmployeeEnti
            {
                Id = selectedId
            };
            try
            {
                employeeBLL.DeleteEmployee(employee);
                MessageBox.Show("Nhân viên đã được xóa thành công");
                LoadEmployeeData();
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
