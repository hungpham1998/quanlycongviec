namespace demonet
{
    partial class Form_NHANVIEN
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.field_chucvu = new System.Windows.Forms.TextBox();
            this.field_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label_chucvu = new System.Windows.Forms.Label();
            this.field_sdt = new System.Windows.Forms.TextBox();
            this.label_sdt = new System.Windows.Forms.Label();
            this.field_diachi = new System.Windows.Forms.TextBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.field_matkhau = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.field_taikhoan = new System.Windows.Forms.TextBox();
            this.label_taikhoan = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label_hoten = new System.Windows.Forms.Label();
            this.field_hoten = new System.Windows.Forms.TextBox();
            this.txttim = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.field_ngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(36, 545);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 43);
            this.buttonInsert.TabIndex = 52;
            this.buttonInsert.Text = "Thêm";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(949, 545);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 43);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // field_chucvu
            // 
            this.field_chucvu.Location = new System.Drawing.Point(148, 313);
            this.field_chucvu.Margin = new System.Windows.Forms.Padding(4);
            this.field_chucvu.Name = "field_chucvu";
            this.field_chucvu.Size = new System.Drawing.Size(192, 22);
            this.field_chucvu.TabIndex = 50;
            // 
            // field_id
            // 
            this.field_id.AutoSize = true;
            this.field_id.Location = new System.Drawing.Point(144, 49);
            this.field_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(54, 17);
            this.field_id.TabIndex = 49;
            this.field_id.Text = "label12";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(42, 49);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 48;
            this.label_id.Text = "ID";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(179, 545);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 43);
            this.buttonUpdate.TabIndex = 47;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(317, 545);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 43);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label_chucvu
            // 
            this.label_chucvu.AutoSize = true;
            this.label_chucvu.Location = new System.Drawing.Point(42, 318);
            this.label_chucvu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_chucvu.Name = "label_chucvu";
            this.label_chucvu.Size = new System.Drawing.Size(59, 17);
            this.label_chucvu.TabIndex = 44;
            this.label_chucvu.Text = "Chức vụ";
            // 
            // field_sdt
            // 
            this.field_sdt.Location = new System.Drawing.Point(147, 198);
            this.field_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.field_sdt.Name = "field_sdt";
            this.field_sdt.Size = new System.Drawing.Size(192, 22);
            this.field_sdt.TabIndex = 43;
            // 
            // label_sdt
            // 
            this.label_sdt.AutoSize = true;
            this.label_sdt.Location = new System.Drawing.Point(41, 203);
            this.label_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(72, 17);
            this.label_sdt.TabIndex = 42;
            this.label_sdt.Text = "Điện thoại";
            // 
            // field_diachi
            // 
            this.field_diachi.Location = new System.Drawing.Point(147, 257);
            this.field_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.field_diachi.Name = "field_diachi";
            this.field_diachi.Size = new System.Drawing.Size(192, 22);
            this.field_diachi.TabIndex = 41;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(41, 261);
            this.label_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(51, 17);
            this.label_diachi.TabIndex = 40;
            this.label_diachi.Text = "Địa chỉ";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Location = new System.Drawing.Point(42, 149);
            this.label_ngaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(71, 17);
            this.label_ngaysinh.TabIndex = 36;
            this.label_ngaysinh.Text = "Ngày sinh";
            // 
            // field_matkhau
            // 
            this.field_matkhau.Location = new System.Drawing.Point(147, 409);
            this.field_matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.field_matkhau.Name = "field_matkhau";
            this.field_matkhau.Size = new System.Drawing.Size(192, 22);
            this.field_matkhau.TabIndex = 35;
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Location = new System.Drawing.Point(41, 413);
            this.label_matkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(66, 17);
            this.label_matkhau.TabIndex = 34;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // field_taikhoan
            // 
            this.field_taikhoan.Location = new System.Drawing.Point(147, 358);
            this.field_taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.field_taikhoan.Name = "field_taikhoan";
            this.field_taikhoan.Size = new System.Drawing.Size(192, 22);
            this.field_taikhoan.TabIndex = 33;
            // 
            // label_taikhoan
            // 
            this.label_taikhoan.AutoSize = true;
            this.label_taikhoan.Location = new System.Drawing.Point(41, 361);
            this.label_taikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(71, 17);
            this.label_taikhoan.TabIndex = 32;
            this.label_taikhoan.Text = "Tài khoản";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(386, 99);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(673, 354);
            this.dgv.TabIndex = 31;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Location = new System.Drawing.Point(42, 99);
            this.label_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(50, 17);
            this.label_hoten.TabIndex = 38;
            this.label_hoten.Text = "Họ tên";
            // 
            // field_hoten
            // 
            this.field_hoten.Location = new System.Drawing.Point(148, 95);
            this.field_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.field_hoten.Name = "field_hoten";
            this.field_hoten.Size = new System.Drawing.Size(192, 22);
            this.field_hoten.TabIndex = 39;
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(435, 38);
            this.txttim.Multiline = true;
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(331, 38);
            this.txttim.TabIndex = 60;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(859, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 38);
            this.button7.TabIndex = 59;
            this.button7.Text = "TÌM KIẾM NHÂN VIÊN";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 42);
            this.button1.TabIndex = 62;
            this.button1.Text = "XUẤT FILE EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // field_ngaysinh
            // 
            this.field_ngaysinh.Location = new System.Drawing.Point(147, 149);
            this.field_ngaysinh.Name = "field_ngaysinh";
            this.field_ngaysinh.Size = new System.Drawing.Size(200, 22);
            this.field_ngaysinh.TabIndex = 63;
            // 
            // Form_NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 699);
            this.Controls.Add(this.field_ngaysinh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.field_chucvu);
            this.Controls.Add(this.field_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label_chucvu);
            this.Controls.Add(this.field_sdt);
            this.Controls.Add(this.label_sdt);
            this.Controls.Add(this.field_diachi);
            this.Controls.Add(this.label_diachi);
            this.Controls.Add(this.field_hoten);
            this.Controls.Add(this.label_hoten);
            this.Controls.Add(this.label_ngaysinh);
            this.Controls.Add(this.field_matkhau);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.field_taikhoan);
            this.Controls.Add(this.label_taikhoan);
            this.Controls.Add(this.dgv);
            this.Name = "Form_NHANVIEN";
            this.Text = "Form_NHANVIEN";
            this.Load += new System.EventHandler(this.Form_NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox field_chucvu;
        private System.Windows.Forms.Label field_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label_chucvu;
        private System.Windows.Forms.TextBox field_sdt;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.TextBox field_diachi;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.TextBox field_matkhau;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.TextBox field_taikhoan;
        private System.Windows.Forms.Label label_taikhoan;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.TextBox field_hoten;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker field_ngaysinh;
    }
}