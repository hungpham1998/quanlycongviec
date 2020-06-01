namespace demonet
{
    partial class Form_DUAN
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labe_hoanthanh = new System.Windows.Forms.Label();
            this.label_thoihan = new System.Windows.Forms.Label();
            this.field_hoanthanh = new System.Windows.Forms.DateTimePicker();
            this.field_thoihan = new System.Windows.Forms.TextBox();
            this.label_noidung = new System.Windows.Forms.Label();
            this.label_tenduan = new System.Windows.Forms.Label();
            this.label_thoigian = new System.Windows.Forms.Label();
            this.field_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.field_noidung = new System.Windows.Forms.TextBox();
            this.field_tenda = new System.Windows.Forms.TextBox();
            this.field_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(423, 102);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(651, 349);
            this.dgv.TabIndex = 90;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(287, 393);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 41);
            this.buttonDelete.TabIndex = 89;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(143, 393);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(124, 41);
            this.buttonUpdate.TabIndex = 88;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(17, 390);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(118, 41);
            this.buttonInsert.TabIndex = 87;
            this.buttonInsert.Text = "Thêm";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(933, 482);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 50);
            this.buttonCancel.TabIndex = 86;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labe_hoanthanh
            // 
            this.labe_hoanthanh.AutoSize = true;
            this.labe_hoanthanh.Location = new System.Drawing.Point(13, 304);
            this.labe_hoanthanh.Name = "labe_hoanthanh";
            this.labe_hoanthanh.Size = new System.Drawing.Size(124, 17);
            this.labe_hoanthanh.TabIndex = 84;
            this.labe_hoanthanh.Text = "Ngày Hoàn Thành";
            // 
            // label_thoihan
            // 
            this.label_thoihan.AutoSize = true;
            this.label_thoihan.Location = new System.Drawing.Point(19, 254);
            this.label_thoihan.Name = "label_thoihan";
            this.label_thoihan.Size = new System.Drawing.Size(70, 17);
            this.label_thoihan.TabIndex = 83;
            this.label_thoihan.Text = "Thời Hạn ";
            // 
            // field_hoanthanh
            // 
            this.field_hoanthanh.CustomFormat = "yyyy-MM-dd";
            this.field_hoanthanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.field_hoanthanh.Location = new System.Drawing.Point(177, 304);
            this.field_hoanthanh.Margin = new System.Windows.Forms.Padding(4);
            this.field_hoanthanh.Name = "field_hoanthanh";
            this.field_hoanthanh.Size = new System.Drawing.Size(212, 22);
            this.field_hoanthanh.TabIndex = 82;
            // 
            // field_thoihan
            // 
            this.field_thoihan.Location = new System.Drawing.Point(177, 251);
            this.field_thoihan.Margin = new System.Windows.Forms.Padding(4);
            this.field_thoihan.Name = "field_thoihan";
            this.field_thoihan.Size = new System.Drawing.Size(212, 22);
            this.field_thoihan.TabIndex = 81;
            // 
            // label_noidung
            // 
            this.label_noidung.AutoSize = true;
            this.label_noidung.Location = new System.Drawing.Point(13, 151);
            this.label_noidung.Name = "label_noidung";
            this.label_noidung.Size = new System.Drawing.Size(67, 17);
            this.label_noidung.TabIndex = 80;
            this.label_noidung.Text = "Nội Dung";
            // 
            // label_tenduan
            // 
            this.label_tenduan.AutoSize = true;
            this.label_tenduan.Location = new System.Drawing.Point(13, 102);
            this.label_tenduan.Name = "label_tenduan";
            this.label_tenduan.Size = new System.Drawing.Size(76, 17);
            this.label_tenduan.TabIndex = 79;
            this.label_tenduan.Text = "Tên Dự Án";
            // 
            // label_thoigian
            // 
            this.label_thoigian.AutoSize = true;
            this.label_thoigian.Location = new System.Drawing.Point(13, 201);
            this.label_thoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_thoigian.Name = "label_thoigian";
            this.label_thoigian.Size = new System.Drawing.Size(111, 17);
            this.label_thoigian.TabIndex = 78;
            this.label_thoigian.Text = "NGÀY BẮT ĐẦU";
            // 
            // field_id
            // 
            this.field_id.AutoSize = true;
            this.field_id.Location = new System.Drawing.Point(174, 64);
            this.field_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(46, 17);
            this.field_id.TabIndex = 77;
            this.field_id.Text = "label2";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(13, 64);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(74, 17);
            this.label_id.TabIndex = 76;
            this.label_id.Text = "Mã DỰ ÁN";
            // 
            // field_noidung
            // 
            this.field_noidung.Location = new System.Drawing.Point(177, 151);
            this.field_noidung.Margin = new System.Windows.Forms.Padding(4);
            this.field_noidung.Name = "field_noidung";
            this.field_noidung.Size = new System.Drawing.Size(212, 22);
            this.field_noidung.TabIndex = 75;
            // 
            // field_tenda
            // 
            this.field_tenda.Location = new System.Drawing.Point(177, 99);
            this.field_tenda.Margin = new System.Windows.Forms.Padding(4);
            this.field_tenda.Name = "field_tenda";
            this.field_tenda.Size = new System.Drawing.Size(212, 22);
            this.field_tenda.TabIndex = 74;
            // 
            // field_ngaybd
            // 
            this.field_ngaybd.CustomFormat = "yyyy-MM-dd";
            this.field_ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.field_ngaybd.Location = new System.Drawing.Point(177, 201);
            this.field_ngaybd.Margin = new System.Windows.Forms.Padding(4);
            this.field_ngaybd.Name = "field_ngaybd";
            this.field_ngaybd.Size = new System.Drawing.Size(212, 22);
            this.field_ngaybd.TabIndex = 73;
            this.field_ngaybd.ValueChanged += new System.EventHandler(this.field_ngaybd_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 93;
            this.button2.Text = "tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(573, 40);
            this.txttim.Multiline = true;
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(229, 41);
            this.txttim.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 50);
            this.button1.TabIndex = 95;
            this.button1.Text = "XUẤT FILE EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 46);
            this.button3.TabIndex = 96;
            this.button3.Text = "XEM THÔNG TIN DỰ ÁN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_DUAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 597);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labe_hoanthanh);
            this.Controls.Add(this.label_thoihan);
            this.Controls.Add(this.field_hoanthanh);
            this.Controls.Add(this.field_thoihan);
            this.Controls.Add(this.label_noidung);
            this.Controls.Add(this.label_tenduan);
            this.Controls.Add(this.label_thoigian);
            this.Controls.Add(this.field_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.field_noidung);
            this.Controls.Add(this.field_tenda);
            this.Controls.Add(this.field_ngaybd);
            this.Name = "Form_DUAN";
            this.Text = "Form_DUAN";
            this.Load += new System.EventHandler(this.Form_DUAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labe_hoanthanh;
        private System.Windows.Forms.Label label_thoihan;
        private System.Windows.Forms.DateTimePicker field_hoanthanh;
        private System.Windows.Forms.TextBox field_thoihan;
        private System.Windows.Forms.Label label_noidung;
        private System.Windows.Forms.Label label_tenduan;
        private System.Windows.Forms.Label label_thoigian;
        private System.Windows.Forms.Label field_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox field_noidung;
        private System.Windows.Forms.TextBox field_tenda;
        private System.Windows.Forms.DateTimePicker field_ngaybd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}