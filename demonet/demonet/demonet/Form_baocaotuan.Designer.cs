namespace demonet
{
    partial class Form_baocaotuan
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
            this.field_macv = new System.Windows.Forms.TextBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.field_manv = new System.Windows.Forms.TextBox();
            this.field_ghichu = new System.Windows.Forms.TextBox();
            this.label_tiendo = new System.Windows.Forms.Label();
            this.label_thoigian = new System.Windows.Forms.Label();
            this.field_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.field_tiendo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.view2 = new System.Windows.Forms.DataGridView();
            this.view1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "đề xuất";
            // 
            // field_dexuat
            // 
            this.field_dexuat.Location = new System.Drawing.Point(179, 426);
            this.field_dexuat.Multiline = true;
            this.field_dexuat.Name = "field_dexuat";
            this.field_dexuat.Size = new System.Drawing.Size(192, 36);
            this.field_dexuat.TabIndex = 106;
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Location = new System.Drawing.Point(49, 102);
            this.label_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(82, 17);
            this.label_hoten.TabIndex = 105;
            this.label_hoten.Text = "NHÂN VIÊN";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 104;
            this.button2.Text = "Chọn Công việc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 103;
            this.button1.Text = "chọn nhân viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(1045, 546);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 43);
            this.buttonCancel.TabIndex = 102;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(35, 535);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(117, 43);
            this.buttonInsert.TabIndex = 101;
            this.buttonInsert.Text = "Thêm";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(179, 535);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 43);
            this.buttonUpdate.TabIndex = 100;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(317, 535);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 43);
            this.buttonDelete.TabIndex = 99;
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
            this.dgv.Location = new System.Drawing.Point(434, 254);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(795, 231);
            this.dgv.TabIndex = 98;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // field_id
            // 
            this.field_id.AutoSize = true;
            this.field_id.Location = new System.Drawing.Point(176, 53);
            this.field_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(54, 17);
            this.field_id.TabIndex = 97;
            this.field_id.Text = "label12";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(55, 53);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 96;
            this.label_id.Text = "ID";
            // 
            // field_macv
            // 
            this.field_macv.Location = new System.Drawing.Point(179, 174);
            this.field_macv.Margin = new System.Windows.Forms.Padding(4);
            this.field_macv.Name = "field_macv";
            this.field_macv.Size = new System.Drawing.Size(70, 22);
            this.field_macv.TabIndex = 95;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(52, 179);
            this.label_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(83, 17);
            this.label_diachi.TabIndex = 94;
            this.label_diachi.Text = "CÔNG VIỆC";
            // 
            // field_manv
            // 
            this.field_manv.Location = new System.Drawing.Point(180, 102);
            this.field_manv.Margin = new System.Windows.Forms.Padding(4);
            this.field_manv.Name = "field_manv";
            this.field_manv.Size = new System.Drawing.Size(69, 22);
            this.field_manv.TabIndex = 93;
            // 
            // field_ghichu
            // 
            this.field_ghichu.Location = new System.Drawing.Point(180, 365);
            this.field_ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.field_ghichu.Multiline = true;
            this.field_ghichu.Name = "field_ghichu";
            this.field_ghichu.Size = new System.Drawing.Size(192, 34);
            this.field_ghichu.TabIndex = 92;
            // 
            // label_tiendo
            // 
            this.label_tiendo.AutoSize = true;
            this.label_tiendo.Location = new System.Drawing.Point(49, 368);
            this.label_tiendo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tiendo.Name = "label_tiendo";
            this.label_tiendo.Size = new System.Drawing.Size(56, 17);
            this.label_tiendo.TabIndex = 91;
            this.label_tiendo.Text = "ghi Chú";
            // 
            // label_thoigian
            // 
            this.label_thoigian.AutoSize = true;
            this.label_thoigian.Location = new System.Drawing.Point(49, 273);
            this.label_thoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_thoigian.Name = "label_thoigian";
            this.label_thoigian.Size = new System.Drawing.Size(111, 17);
            this.label_thoigian.TabIndex = 109;
            this.label_thoigian.Text = "NGÀY BẮT ĐẦU";
            // 
            // field_ngaybd
            // 
            this.field_ngaybd.CustomFormat = "yyyy-MM-dd";
            this.field_ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.field_ngaybd.Location = new System.Drawing.Point(180, 268);
            this.field_ngaybd.Margin = new System.Windows.Forms.Padding(4);
            this.field_ngaybd.Name = "field_ngaybd";
            this.field_ngaybd.Size = new System.Drawing.Size(193, 22);
            this.field_ngaybd.TabIndex = 108;
            // 
            // field_tiendo
            // 
            this.field_tiendo.Location = new System.Drawing.Point(179, 314);
            this.field_tiendo.Margin = new System.Windows.Forms.Padding(4);
            this.field_tiendo.Multiline = true;
            this.field_tiendo.Name = "field_tiendo";
            this.field_tiendo.Size = new System.Drawing.Size(192, 34);
            this.field_tiendo.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tiến Độ";
            // 
            // view2
            // 
            this.view2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view2.Location = new System.Drawing.Point(434, 53);
            this.view2.Name = "view2";
            this.view2.RowTemplate.Height = 24;
            this.view2.Size = new System.Drawing.Size(749, 194);
            this.view2.TabIndex = 112;
            this.view2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.view2_CellEnter);
            // 
            // view1
            // 
            this.view1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view1.Location = new System.Drawing.Point(434, 41);
            this.view1.Name = "view1";
            this.view1.RowTemplate.Height = 24;
            this.view1.Size = new System.Drawing.Size(749, 195);
            this.view1.TabIndex = 113;
            this.view1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view1_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 43);
            this.button3.TabIndex = 114;
            this.button3.Text = "Thông tin báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_baocaotuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.view1);
            this.Controls.Add(this.view2);
            this.Controls.Add(this.field_tiendo);
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
            this.Controls.Add(this.field_macv);
            this.Controls.Add(this.label_diachi);
            this.Controls.Add(this.field_manv);
            this.Controls.Add(this.field_ghichu);
            this.Controls.Add(this.label_tiendo);
            this.Name = "Form_baocaotuan";
            this.Text = "Form_baocaotuan";
            this.Load += new System.EventHandler(this.Form_baocaotuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox field_macv;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.TextBox field_manv;
        private System.Windows.Forms.TextBox field_ghichu;
        private System.Windows.Forms.Label label_tiendo;
        private System.Windows.Forms.Label label_thoigian;
        private System.Windows.Forms.DateTimePicker field_ngaybd;
        private System.Windows.Forms.TextBox field_tiendo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView view2;
        private System.Windows.Forms.DataGridView view1;
        private System.Windows.Forms.Button button3;
    }
}