namespace demonet
{
    partial class Form_THANHVIEN
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
            this.field_chucvu = new System.Windows.Forms.TextBox();
            this.label_tiendo = new System.Windows.Forms.Label();
            this.label_hoten = new System.Windows.Forms.Label();
            this.field_congviec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.View1 = new System.Windows.Forms.DataGridView();
            this.View2 = new System.Windows.Forms.DataGridView();
            this.tim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 37);
            this.button2.TabIndex = 87;
            this.button2.Text = "Chọn dự án";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 86;
            this.button1.Text = "chọn nhân viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(868, 449);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 43);
            this.buttonCancel.TabIndex = 85;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(37, 449);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 43);
            this.buttonInsert.TabIndex = 84;
            this.buttonInsert.Text = "Thêm";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(176, 449);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 43);
            this.buttonUpdate.TabIndex = 83;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(314, 449);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 43);
            this.buttonDelete.TabIndex = 82;
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
            this.dgv.Location = new System.Drawing.Point(390, 205);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(674, 180);
            this.dgv.TabIndex = 81;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // field_id
            // 
            this.field_id.AutoSize = true;
            this.field_id.Location = new System.Drawing.Point(158, 60);
            this.field_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(54, 17);
            this.field_id.TabIndex = 80;
            this.field_id.Text = "label12";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(37, 60);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 79;
            this.label_id.Text = "ID";
            // 
            // field_macv
            // 
            this.field_macv.Location = new System.Drawing.Point(160, 154);
            this.field_macv.Margin = new System.Windows.Forms.Padding(4);
            this.field_macv.Name = "field_macv";
            this.field_macv.Size = new System.Drawing.Size(70, 22);
            this.field_macv.TabIndex = 78;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(33, 159);
            this.label_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(51, 17);
            this.label_diachi.TabIndex = 77;
            this.label_diachi.Text = "DỰ ÁN";
            // 
            // field_manv
            // 
            this.field_manv.Location = new System.Drawing.Point(161, 106);
            this.field_manv.Margin = new System.Windows.Forms.Padding(4);
            this.field_manv.Name = "field_manv";
            this.field_manv.Size = new System.Drawing.Size(69, 22);
            this.field_manv.TabIndex = 76;
            // 
            // field_chucvu
            // 
            this.field_chucvu.Location = new System.Drawing.Point(161, 215);
            this.field_chucvu.Margin = new System.Windows.Forms.Padding(4);
            this.field_chucvu.Multiline = true;
            this.field_chucvu.Name = "field_chucvu";
            this.field_chucvu.Size = new System.Drawing.Size(192, 34);
            this.field_chucvu.TabIndex = 74;
            // 
            // label_tiendo
            // 
            this.label_tiendo.AutoSize = true;
            this.label_tiendo.Location = new System.Drawing.Point(33, 218);
            this.label_tiendo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tiendo.Name = "label_tiendo";
            this.label_tiendo.Size = new System.Drawing.Size(69, 17);
            this.label_tiendo.TabIndex = 73;
            this.label_tiendo.Text = "CHỨC VỤ";
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Location = new System.Drawing.Point(30, 106);
            this.label_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(82, 17);
            this.label_hoten.TabIndex = 88;
            this.label_hoten.Text = "NHÂN VIÊN";
            // 
            // field_congviec
            // 
            this.field_congviec.Location = new System.Drawing.Point(161, 275);
            this.field_congviec.Multiline = true;
            this.field_congviec.Name = "field_congviec";
            this.field_congviec.Size = new System.Drawing.Size(192, 36);
            this.field_congviec.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "CÔNG VIỆC";
            // 
            // View1
            // 
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Location = new System.Drawing.Point(390, 60);
            this.View1.Name = "View1";
            this.View1.RowTemplate.Height = 24;
            this.View1.Size = new System.Drawing.Size(674, 138);
            this.View1.TabIndex = 92;
            this.View1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.View1_CellEnter);
            // 
            // View2
            // 
            this.View2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View2.Location = new System.Drawing.Point(390, 60);
            this.View2.Name = "View2";
            this.View2.RowTemplate.Height = 24;
            this.View2.Size = new System.Drawing.Size(674, 138);
            this.View2.TabIndex = 93;
            this.View2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View2_CellClick);
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(892, 139);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(142, 38);
            this.tim.TabIndex = 94;
            this.tim.Text = "tìm kiếm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(522, 139);
            this.txttim.Multiline = true;
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(277, 38);
            this.txttim.TabIndex = 95;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 44);
            this.button3.TabIndex = 96;
            this.button3.Text = "xem chi tiết ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form_THANHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 605);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.View2);
            this.Controls.Add(this.View1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.field_congviec);
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
            this.Controls.Add(this.field_chucvu);
            this.Controls.Add(this.label_tiendo);
            this.Name = "Form_THANHVIEN";
            this.Text = "Form_THANHVIEN";
            this.Load += new System.EventHandler(this.Form_THANHVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox field_chucvu;
        private System.Windows.Forms.Label label_tiendo;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.TextBox field_congviec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView View1;
        private System.Windows.Forms.DataGridView View2;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button button3;
    }
}