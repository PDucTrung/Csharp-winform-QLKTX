namespace Quanlykytucxadetai
{
    partial class Khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khoa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvbangkhoa = new System.Windows.Forms.DataGridView();
            this.Makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnquayve = new System.Windows.Forms.Button();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa";
            // 
            // dgvbangkhoa
            // 
            this.dgvbangkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbangkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makhoa,
            this.Tenkhoa});
            this.dgvbangkhoa.Location = new System.Drawing.Point(32, 208);
            this.dgvbangkhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvbangkhoa.Name = "dgvbangkhoa";
            this.dgvbangkhoa.RowHeadersWidth = 51;
            this.dgvbangkhoa.RowTemplate.Height = 24;
            this.dgvbangkhoa.Size = new System.Drawing.Size(701, 150);
            this.dgvbangkhoa.TabIndex = 2;
            this.dgvbangkhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbangkhoa_CellClick);
            // 
            // Makhoa
            // 
            this.Makhoa.DataPropertyName = "Makhoa";
            this.Makhoa.HeaderText = "Mã khoa";
            this.Makhoa.MinimumWidth = 6;
            this.Makhoa.Name = "Makhoa";
            this.Makhoa.Width = 125;
            // 
            // Tenkhoa
            // 
            this.Tenkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenkhoa.DataPropertyName = "Tenkhoa";
            this.Tenkhoa.HeaderText = "Tên khoa";
            this.Tenkhoa.MinimumWidth = 6;
            this.Tenkhoa.Name = "Tenkhoa";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(481, 32);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(619, 31);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(481, 75);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(619, 74);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnquayve
            // 
            this.btnquayve.Location = new System.Drawing.Point(581, 155);
            this.btnquayve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(152, 28);
            this.btnquayve.TabIndex = 7;
            this.btnquayve.Text = "Quay về trang chủ";
            this.btnquayve.UseVisualStyleBackColor = true;
            this.btnquayve.Click += new System.EventHandler(this.btnquayve_Click);
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(179, 38);
            this.txtmakhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(161, 22);
            this.txtmakhoa.TabIndex = 8;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(179, 81);
            this.txttenkhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(161, 22);
            this.txttenkhoa.TabIndex = 9;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.txttenkhoa);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.btnquayve);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvbangkhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khoa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Khoa_FormClosed);
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangkhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvbangkhoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhoa;
    }
}