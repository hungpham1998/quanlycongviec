namespace demonet
{
    partial class Form_CONGVIEC
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
            this.field_noidung = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labe_noidung = new System.Windows.Forms.Label();
            this.label_thoihan = new System.Windows.Forms.Label();
            this.label_duan = new System.Windows.Forms.Label();
            this.label_thoigian = new System.Windows.Forms.Label();
            this.field_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.field_tencv = new System.Windows.Forms.TextBox();
            this.field_duan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.View1 = new System.Windows.Forms.DataGridView();
            this.tim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.field_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.field_thoihan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            this.SuspendLayout();
            // 
            // field_noidung
            // 
            this.field_noidung.Location = new System.Drawing.Point(165, 231);
            this.field_noidung.Margin = new System.Windows.Forms.Padding(4);
            this.field_noidung.Name = "field_noidung";
            this.field_noidung.Size = new System.Drawing.Size(212, 22);
            this.field_noidung.TabIndex = 110;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(407, 231);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(666, 296);
            this.dgv.TabIndex = 107;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(277, 466);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 49);
            this.buttonDelete.TabIndex = 106;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(150, 466);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 49);
            this.buttonUpdate.TabIndex = 105;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(28, 466);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 49);
            this.buttonInsert.TabIndex = 104;
            this.buttonInsert.Text = "Thêm";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labe_noidung
            // 
            this.labe_noidung.AutoSize = true;
            this.labe_noidung.Location = new System.Drawing.Point(9, 234);
            this.labe_noidung.Name = "labe_noidung";
            this.labe_noidung.Size = new System.Drawing.Size(133, 17);
            this.labe_noidung.TabIndex = 101;
            this.labe_noidung.Text = "Nội Dung Công việc";
            // 
            // label_thoihan
            // 
            this.label_thoihan.AutoSize = true;
            this.label_thoihan.Location = new System.Drawing.Point(12, 337);
            this.label_thoihan.Name = "label_thoihan";
            this.label_thoihan.Size = new System.Drawing.Size(70, 17);
            this.label_thoihan.TabIndex = 100;
            this.label_thoihan.Text = "Thời Hạn ";
            // 
            // label_duan
            // 
            this.label_duan.AutoSize = true;
            this.label_duan.Location = new System.Drawing.Point(8, 100);
            this.label_duan.Name = "label_duan";
            this.label_duan.Size = new System.Drawing.Size(51, 17);
            this.label_duan.TabIndex = 98;
            this.label_duan.Text = "DỰ ÁN";
            // 
            // label_thoigian
            // 
            this.label_thoigian.AutoSize = true;
            this.label_thoigian.Location = new System.Drawing.Point(12, 285);
            this.label_thoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_thoigian.Name = "label_thoigian";
            this.label_thoigian.Size = new System.Drawing.Size(111, 17);
            this.label_thoigian.TabIndex = 97;
            this.label_thoigian.Text = "NGÀY BẮT ĐẦU";
            // 
            // field_id
            // 
            this.field_id.AutoSize = true;
            this.field_id.Location = new System.Drawing.Point(176, 65);
            this.field_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(46, 17);
            this.field_id.TabIndex = 96;
            this.field_id.Text = "label2";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(8, 65);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(94, 17);
            this.label_id.TabIndex = 95;
            this.label_id.Text = "MÃ Công việc";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(973, 545);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 54);
            this.buttonCancel.TabIndex = 103;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 111;
            this.label1.Text = "Tên Công Việc";
            // 
            // field_tencv
            // 
            this.field_tencv.Location = new System.Drawing.Point(165, 192);
            this.field_tencv.Name = "field_tencv";
            this.field_tencv.Size = new System.Drawing.Size(212, 22);
            this.field_tencv.TabIndex = 112;
            this.field_tencv.TextChanged += new System.EventHandler(this.field_tencv_TextChanged);
            // 
            // field_duan
            // 
            this.field_duan.AutoSize = true;
            this.field_duan.Location = new System.Drawing.Point(176, 100);
            this.field_duan.Name = "field_duan";
            this.field_duan.Size = new System.Drawing.Size(46, 17);
            this.field_duan.TabIndex = 114;
            this.field_duan.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 115;
            this.button1.Text = "chọn dự án";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // View1
            // 
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Location = new System.Drawing.Point(407, 12);
            this.View1.Name = "View1";
            this.View1.RowHeadersWidth = 51;
            this.View1.RowTemplate.Height = 24;
            this.View1.Size = new System.Drawing.Size(666, 124);
            this.View1.TabIndex = 116;
            this.View1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.View1_CellEnter);
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(871, 170);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(157, 44);
            this.tim.TabIndex = 117;
            this.tim.Text = "tìm kiếm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(606, 168);
            this.txttim.Multiline = true;
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(234, 44);
            this.txttim.TabIndex = 118;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 59);
            this.button2.TabIndex = 120;
            this.button2.Text = "XUẤT FILE EXCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(347, 50);
            this.button3.TabIndex = 121;
            this.button3.Text = "XEM CHI TIẾT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // field_ngaybd
            // 
            this.field_ngaybd.Location = new System.Drawing.Point(165, 285);
            this.field_ngaybd.Name = "field_ngaybd";
            this.field_ngaybd.Size = new System.Drawing.Size(200, 22);
            this.field_ngaybd.TabIndex = 122;
            // 
            // field_thoihan
            // 
            this.field_thoihan.Location = new System.Drawing.Point(165, 337);
            this.field_thoihan.Name = "field_thoihan";
            this.field_thoihan.Size = new System.Drawing.Size(200, 22);
            this.field_thoihan.TabIndex = 125;
            this.field_thoihan.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form_CONGVIEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 631);
            this.Controls.Add(this.field_thoihan);
            this.Controls.Add(this.field_ngaybd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.View1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.field_duan);
            this.Controls.Add(this.field_tencv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.field_noidung);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labe_noidung);
            this.Controls.Add(this.label_thoihan);
            this.Controls.Add(this.label_duan);
            this.Controls.Add(this.label_thoigian);
            this.Controls.Add(this.field_id);
            this.Controls.Add(this.label_id);
            this.Name = "Form_CONGVIEC";
            this.Text = "Form_CONGVIEC";
            this.Load += new System.EventHandler(this.Form_CONGVIEC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox field_noidung;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labe_noidung;
        private System.Windows.Forms.Label label_thoihan;
        private System.Windows.Forms.Label label_duan;
        private System.Windows.Forms.Label label_thoigian;
        private System.Windows.Forms.Label field_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox field_tencv;
        private System.Windows.Forms.Label field_duan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView View1;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker field_ngaybd;
        private System.Windows.Forms.DateTimePicker field_thoihan;
    }
}