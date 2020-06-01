namespace demonet
{
    partial class Form_BAOCAOTONGHOP
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
            this.view1 = new System.Windows.Forms.DataGridView();
            this.field_tondong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_thoigian = new System.Windows.Forms.Label();
            this.field_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.field_dexuat = new System.Windows.Forms.TextBox();
            this.label_hoten = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.field_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.field_mada = new System.Windows.Forms.TextBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.field_manv = new System.Windows.Forms.TextBox();
            this.View2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).BeginInit();
            this.SuspendLayout();
            // 
            // view1
            // 
            this.view1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view1.Location = new System.Drawing.Point(420, 97);
            this.view1.Name = "view1";
            this.view1.RowTemplate.Height = 24;
            this.view1.Size = new System.Drawing.Size(795, 122);
            this.view1.TabIndex = 135;
            this.view1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.view1_CellEnter);
            // 
            // field_tondong
            // 
            this.field_tondong.Location = new System.Drawing.Point(185, 249);
            this.field_tondong.Margin = new System.Windows.Forms.Padding(4);
            this.field_tondong.Multiline = true;
            this.field_tondong.Name = "field_tondong";
            this.field_tondong.Size = new System.Drawing.Size(192, 34);
            this.field_tondong.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 133;
            this.label2.Text = "Tồn ĐỌNG";
            // 
            // label_thoigian
            // 
            this.label_thoigian.AutoSize = true;
            this.label_thoigian.Location = new System.Drawing.Point(34, 339);
            this.label_thoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_thoigian.Name = "label_thoigian";
            this.label_thoigian.Size = new System.Drawing.Size(143, 17);
            this.label_thoigian.TabIndex = 132;
            this.label_thoigian.Text = "NGÀY HOÀN THÀNH";
            // 
            // field_ngaybd
            // 
            this.field_ngaybd.CustomFormat = "yyyy-MM-dd";
            this.field_ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.field_ngaybd.Location = new System.Drawing.Point(185, 334);
            this.field_ngaybd.Margin = new System.Windows.Forms.Padding(4);
            this.field_ngaybd.Name = "field_ngaybd";
            this.field_ngaybd.Size = new System.Drawing.Size(173, 22);
            this.field_ngaybd.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 130;
            this.label1.Text = "ĐỀ XUẤT";
            // 
            // field_dexuat
            // 
            this.field_dexuat.Location = new System.Drawing.Point(185, 405);
            this.field_dexuat.Multiline = true;
            this.field_dexuat.Name = "field_dexuat";
            this.field_dexuat.Size = new System.Drawing.Size(192, 36);
            this.field_dexuat.TabIndex = 129;
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Location = new System.Drawing.Point(13, 114);
            this.label_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(135, 17);
            this.label_hoten.TabIndex = 128;
            this.label_hoten.Text = "CHỌN THÀNH VIÊN";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 127;
            this.button2.Text = "Chọn Công việc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 126;
            this.button1.Text = "chọn thành viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(1031, 541);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 43);
            this.buttonCancel.TabIndex = 125;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(38, 530);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 43);
            this.buttonInsert.TabIndex = 124;
            this.buttonInsert.Text = "Thêm";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(177, 530);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 43);
            this.buttonUpdate.TabIndex = 123;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(315, 530);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 43);
            this.buttonDelete.TabIndex = 122;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(420, 249);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(795, 231);
            this.dgv.TabIndex = 121;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // field_id
            // 
            this.field_id.AutoSize = true;
            this.field_id.Location = new System.Drawing.Point(182, 48);
            this.field_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(54, 17);
            this.field_id.TabIndex = 120;
            this.field_id.Text = "label12";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(41, 48);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 119;
            this.label_id.Text = "ID";
            // 
            // field_mada
            // 
            this.field_mada.Location = new System.Drawing.Point(172, 179);
            this.field_mada.Margin = new System.Windows.Forms.Padding(4);
            this.field_mada.Name = "field_mada";
            this.field_mada.Size = new System.Drawing.Size(70, 22);
            this.field_mada.TabIndex = 118;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(25, 184);
            this.label_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(95, 17);
            this.label_diachi.TabIndex = 117;
            this.label_diachi.Text = "CHỌN DỰ ÁN";
            // 
            // field_manv
            // 
            this.field_manv.Location = new System.Drawing.Point(167, 109);
            this.field_manv.Margin = new System.Windows.Forms.Padding(4);
            this.field_manv.Name = "field_manv";
            this.field_manv.Size = new System.Drawing.Size(69, 22);
            this.field_manv.TabIndex = 116;
            // 
            // View2
            // 
            this.View2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View2.Location = new System.Drawing.Point(420, 87);
            this.View2.Name = "View2";
            this.View2.RowTemplate.Height = 24;
            this.View2.Size = new System.Drawing.Size(795, 143);
            this.View2.TabIndex = 136;
            this.View2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.View2_CellEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 43);
            this.button3.TabIndex = 137;
            this.button3.Text = "In báo cáo tổng hợp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_BAOCAOTONGHOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 607);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.View2);
            this.Controls.Add(this.view1);
            this.Controls.Add(this.field_tondong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_thoigian);
            this.Controls.Add(this.field_ngaybd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.field_dexuat);
            this.Controls.Add(this.label_hoten);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.field_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.field_mada);
            this.Controls.Add(this.label_diachi);
            this.Controls.Add(this.field_manv);
            this.Name = "Form_BAOCAOTONGHOP";
            this.Text = "Form_BAOCAOTONGHOP";
            this.Load += new System.EventHandler(this.Form_BAOCAOTONGHOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view1;
        private System.Windows.Forms.TextBox field_tondong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_thoigian;
        private System.Windows.Forms.DateTimePicker field_ngaybd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox field_dexuat;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label field_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox field_mada;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.TextBox field_manv;
        private System.Windows.Forms.DataGridView View2;
        private System.Windows.Forms.Button button3;
    }
}