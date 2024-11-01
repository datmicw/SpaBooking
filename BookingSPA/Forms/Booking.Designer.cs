namespace BookingSPA.Forms
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_custumerName = new System.Windows.Forms.TextBox();
            this.cbx_serviceName = new System.Windows.Forms.ComboBox();
            this.cbx_staff = new System.Windows.Forms.ComboBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.btn_AddBooking = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgt_booking = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_booking)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOKING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custumer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Staff";
            // 
            // txt_custumerName
            // 
            this.txt_custumerName.Location = new System.Drawing.Point(144, 58);
            this.txt_custumerName.Name = "txt_custumerName";
            this.txt_custumerName.Size = new System.Drawing.Size(121, 20);
            this.txt_custumerName.TabIndex = 5;
            // 
            // cbx_serviceName
            // 
            this.cbx_serviceName.FormattingEnabled = true;
            this.cbx_serviceName.Location = new System.Drawing.Point(144, 88);
            this.cbx_serviceName.Name = "cbx_serviceName";
            this.cbx_serviceName.Size = new System.Drawing.Size(121, 21);
            this.cbx_serviceName.TabIndex = 6;
            this.cbx_serviceName.SelectedIndexChanged += new System.EventHandler(this.cbx_serviceName_SelectedIndexChanged);
            // 
            // cbx_staff
            // 
            this.cbx_staff.FormattingEnabled = true;
            this.cbx_staff.Location = new System.Drawing.Point(144, 160);
            this.cbx_staff.Name = "cbx_staff";
            this.cbx_staff.Size = new System.Drawing.Size(121, 21);
            this.cbx_staff.TabIndex = 7;
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(144, 134);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(121, 20);
            this.txt_Time.TabIndex = 8;
            this.txt_Time.TextChanged += new System.EventHandler(this.txt_Time_TextChanged_1);
            // 
            // btn_AddBooking
            // 
            this.btn_AddBooking.Location = new System.Drawing.Point(636, 53);
            this.btn_AddBooking.Name = "btn_AddBooking";
            this.btn_AddBooking.Size = new System.Drawing.Size(93, 23);
            this.btn_AddBooking.TabIndex = 9;
            this.btn_AddBooking.Text = "ADD BOOKING";
            this.btn_AddBooking.UseVisualStyleBackColor = true;
            this.btn_AddBooking.Click += new System.EventHandler(this.btn_AddBooking_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(636, 83);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(636, 115);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dgt_booking
            // 
            this.dgt_booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_booking.Location = new System.Drawing.Point(42, 197);
            this.dgt_booking.Name = "dgt_booking";
            this.dgt_booking.Size = new System.Drawing.Size(687, 230);
            this.dgt_booking.TabIndex = 12;
            this.dgt_booking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgt_booking_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(176, 115);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(0, 13);
            this.lb_Price.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "TOTAL";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(393, 88);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 15);
            this.lbl_total.TabIndex = 16;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(354, 149);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(121, 20);
            this.txt_status.TabIndex = 17;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgt_booking);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_AddBooking);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.cbx_staff);
            this.Controls.Add(this.cbx_serviceName);
            this.Controls.Add(this.txt_custumerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_custumerName;
        private System.Windows.Forms.ComboBox cbx_serviceName;
        private System.Windows.Forms.ComboBox cbx_staff;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.Button btn_AddBooking;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgt_booking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_status;
    }
}