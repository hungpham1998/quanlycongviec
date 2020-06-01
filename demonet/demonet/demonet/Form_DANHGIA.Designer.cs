namespace demonet
{
    partial class Form_DANHGIA
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
            this.field_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_hoten = new System.Windows.Forms.Label();
            this.field_tiendo = new System.Windows.Forms.TextBox();
            this.label_tiendo = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.View1 = new System.Windows.Forms.DataGridView();
            this.field_manv = new System.Windows.Forms.Label();
            this.field_macv = new System.Windows.Forms.Label();
            this.View2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).BeginInit();
            this.SuspendLayout();
            // 
            // field_id
            // 
            this.field_id.AutoSize = true;
            this.field_id.Location = new System.Drawing.Point(202, 32);
            this.field_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(54, 17);
            this.field_id.TabIndex = 65;
            this.field_id.Text = "label12";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(72, 32);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 64;
            this.label_id.Text = "ID";
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(68, 152);
            this.label_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(107, 17);
            this.label_diachi.TabIndex = 59;
            this.label_diachi.Text = "MÃ CÔNG VIỆC";
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Location = new System.Drawing.Point(72, 78);
            this.label_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(110, 17);
            this.label_hoten.TabIndex = 57;
            this.label_hoten.Text = " MÃ NHÂN VIÊN";
            // 
            // field_tiendo
            // 
            this.field_tiendo.Location = new System.Drawing.Point(205, 201);
            this.field_tiendo.Margin = new System.Windows.Forms.Padding(4);
            this.field_tiendo.Multiline = true;
            this.field_tiendo.Name = "field_tiendo";
            this.field_tiendo.Size = new System.Drawing.Size(192, 34);
            this.field_tiendo.TabIndex = 52;
            // 
            // label_tiendo
            // 
            this.label_tiendo.AutoSize = true;
            this.label_tiendo.Location = new System.Drawing.Point(81, 204);
            this.label_tiendo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tiendo.Name = "label_tiendo";
            this.label_tiendo.Size = new System.Drawing.Size(58, 17);
            this.label_tiendo.TabIndex = 51;
            this.label_tiendo.Text = "Tiến Độ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(54, 298);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(624, 237);
            this.dgv.TabIndex = 66;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(815, 298);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(117, 43);
            this.buttonInsert.TabIndex = 69;
            this.buttonInsert.Text = "Thêm";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(815, 372);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 43);
            this.buttonUpdate.TabIndex = 68;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(815, 437);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 43);
            this.buttonDelete.TabIndex = 67;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(815, 503);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 45);
            this.buttonCancel.TabIndex = 70;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 71;
            this.button1.Text = "chọn nhân viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 37);
            this.button2.TabIndex = 72;
            this.button2.Text = "Chọn công việc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // View1
            // 
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Location = new System.Drawing.Point(480, 57);
            this.View1.Name = "View1";
            this.View1.RowTemplate.Height = 24;
            this.View1.Size = new System.Drawing.Size(518, 178);
            this.View1.TabIndex = 73;
            this.View1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.View1_CellEnter);
            // 
            // field_manv
            // 
            this.field_manv.AutoSize = true;
            this.field_manv.Location = new System.Drawing.Point(201, 78);
            this.field_manv.Name = "field_manv";
            this.field_manv.Size = new System.Drawing.Size(46, 17);
            this.field_manv.TabIndex = 74;
            this.field_manv.Text = "label1";
            // 
            // field_macv
            // 
            this.field_macv.AutoSize = true;
            this.field_macv.Location = new System.Drawing.Point(202, 151);
            this.field_macv.Name = "field_macv";
            this.field_macv.Size = new System.Drawing.Size(46, 17);
            this.field_macv.TabIndex = 75;
            this.field_macv.Text = "label1";
            // 
            // View2
            // 
            this.View2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View2.Location = new System.Drawing.Point(480, 57);
            this.View2.Name = "View2";
            this.View2.RowTemplate.Height = 24;
            this.View2.Size = new System.Drawing.Size(518, 178);
            this.View2.TabIndex = 76;
            this.View2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.View2_CellEnter);
            // 
            // Form_DANHGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 596);
            this.Controls.Add(this.View2);
            this.Controls.Add(this.field_macv);
            this.Controls.Add(this.field_manv);
            this.Controls.Add(this.View1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.field_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_diachi);
            this.Controls.Add(this.label_hoten);
            this.Controls.Add(this.field_tiendo);
            this.Controls.Add(this.label_tiendo);
            this.Name = "Form_DANHGIA";
            this.Text = "Form_DANHGIA";
            this.Load += new System.EventHandler(this.Form_DANHGIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label field_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.TextBox field_tiendo;
        private System.Windows.Forms.Label label_tiendo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView View1;
        private System.Windows.Forms.Label field_manv;
        private System.Windows.Forms.Label field_macv;
        private System.Windows.Forms.DataGridView View2;
    }
}