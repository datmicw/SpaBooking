namespace BookingSPA.Forms
{
    partial class ServiceForm
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
            this.txt_serviceName = new System.Windows.Forms.TextBox();
            this.txt_servicePrice = new System.Windows.Forms.TextBox();
            this.btn_addService = new System.Windows.Forms.Button();
            this.dtg_service = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_service)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txt_serviceName
            // 
            this.txt_serviceName.Location = new System.Drawing.Point(400, 119);
            this.txt_serviceName.Name = "txt_serviceName";
            this.txt_serviceName.Size = new System.Drawing.Size(173, 20);
            this.txt_serviceName.TabIndex = 3;
            // 
            // txt_servicePrice
            // 
            this.txt_servicePrice.Location = new System.Drawing.Point(400, 161);
            this.txt_servicePrice.Name = "txt_servicePrice";
            this.txt_servicePrice.Size = new System.Drawing.Size(173, 20);
            this.txt_servicePrice.TabIndex = 4;
            // 
            // btn_addService
            // 
            this.btn_addService.Location = new System.Drawing.Point(485, 217);
            this.btn_addService.Name = "btn_addService";
            this.btn_addService.Size = new System.Drawing.Size(88, 23);
            this.btn_addService.TabIndex = 5;
            this.btn_addService.Text = "ADD SERVICE";
            this.btn_addService.UseVisualStyleBackColor = true;
            this.btn_addService.Click += new System.EventHandler(this.btn_addService_Click);
            // 
            // dtg_service
            // 
            this.dtg_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_service.Location = new System.Drawing.Point(259, 217);
            this.dtg_service.Name = "dtg_service";
            this.dtg_service.Size = new System.Drawing.Size(216, 221);
            this.dtg_service.TabIndex = 6;
            this.dtg_service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_service_CellClick);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(485, 262);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(485, 308);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dtg_service);
            this.Controls.Add(this.btn_addService);
            this.Controls.Add(this.txt_servicePrice);
            this.Controls.Add(this.txt_serviceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_serviceName;
        private System.Windows.Forms.TextBox txt_servicePrice;
        private System.Windows.Forms.Button btn_addService;
        private System.Windows.Forms.DataGridView dtg_service;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Delete;
    }
}