
namespace HTPTCSClient
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiXuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiLen = new Guna.UI2.WinForms.Guna2Button();
            this.tblDanhSachFile = new System.Windows.Forms.DataGridView();
            this.hMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTenFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hKichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNgayTaiLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIPAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblDanhSachFile)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách file";
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "C:\\";
            this.openFileDialog.Title = "Chọn tệp tin";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.InitialDirectory = "C:\\";
            this.saveFileDialog.Title = "Lưu tệp tin";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamMoi.BorderRadius = 15;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(193)))), ((int)(((byte)(90)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Image = global::HTPTCSClient.Properties.Resources.reset_480px;
            this.btnLamMoi.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLamMoi.Location = new System.Drawing.Point(817, 521);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(164, 45);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::HTPTCSClient.Properties.Resources.trash_480px;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(596, 521);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(164, 45);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnTaiXuong
            // 
            this.btnTaiXuong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTaiXuong.BorderRadius = 15;
            this.btnTaiXuong.CheckedState.Parent = this.btnTaiXuong;
            this.btnTaiXuong.CustomImages.Parent = this.btnTaiXuong;
            this.btnTaiXuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.btnTaiXuong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiXuong.ForeColor = System.Drawing.Color.White;
            this.btnTaiXuong.HoverState.Parent = this.btnTaiXuong;
            this.btnTaiXuong.Image = global::HTPTCSClient.Properties.Resources.download_480px;
            this.btnTaiXuong.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTaiXuong.Location = new System.Drawing.Point(375, 521);
            this.btnTaiXuong.Name = "btnTaiXuong";
            this.btnTaiXuong.ShadowDecoration.Parent = this.btnTaiXuong;
            this.btnTaiXuong.Size = new System.Drawing.Size(164, 45);
            this.btnTaiXuong.TabIndex = 7;
            this.btnTaiXuong.Text = "Tải xuống";
            this.btnTaiXuong.Click += new System.EventHandler(this.BtnTaiXuong_Click);
            // 
            // btnTaiLen
            // 
            this.btnTaiLen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTaiLen.BorderRadius = 15;
            this.btnTaiLen.CheckedState.Parent = this.btnTaiLen;
            this.btnTaiLen.CustomImages.Parent = this.btnTaiLen;
            this.btnTaiLen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(198)))), ((int)(((byte)(109)))));
            this.btnTaiLen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLen.ForeColor = System.Drawing.Color.White;
            this.btnTaiLen.HoverState.Parent = this.btnTaiLen;
            this.btnTaiLen.Image = global::HTPTCSClient.Properties.Resources.upload_480px;
            this.btnTaiLen.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTaiLen.Location = new System.Drawing.Point(154, 521);
            this.btnTaiLen.Name = "btnTaiLen";
            this.btnTaiLen.ShadowDecoration.Parent = this.btnTaiLen;
            this.btnTaiLen.Size = new System.Drawing.Size(164, 45);
            this.btnTaiLen.TabIndex = 6;
            this.btnTaiLen.Text = "Tải lên";
            this.btnTaiLen.Click += new System.EventHandler(this.BtnTaiLen_Click);
            // 
            // tblDanhSachFile
            // 
            this.tblDanhSachFile.AllowUserToAddRows = false;
            this.tblDanhSachFile.AllowUserToDeleteRows = false;
            this.tblDanhSachFile.AllowUserToResizeColumns = false;
            this.tblDanhSachFile.AllowUserToResizeRows = false;
            this.tblDanhSachFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDanhSachFile.BackgroundColor = System.Drawing.Color.White;
            this.tblDanhSachFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblDanhSachFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDanhSachFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDanhSachFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDanhSachFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hMa,
            this.hTenFile,
            this.hKichThuoc,
            this.hNgayTaiLen});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDanhSachFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblDanhSachFile.EnableHeadersVisualStyles = false;
            this.tblDanhSachFile.Location = new System.Drawing.Point(39, 62);
            this.tblDanhSachFile.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.tblDanhSachFile.Name = "tblDanhSachFile";
            this.tblDanhSachFile.ReadOnly = true;
            this.tblDanhSachFile.RowHeadersVisible = false;
            this.tblDanhSachFile.RowHeadersWidth = 51;
            this.tblDanhSachFile.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDanhSachFile.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tblDanhSachFile.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.tblDanhSachFile.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tblDanhSachFile.RowTemplate.Height = 45;
            this.tblDanhSachFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDanhSachFile.Size = new System.Drawing.Size(1056, 441);
            this.tblDanhSachFile.TabIndex = 10;
            this.tblDanhSachFile.SizeChanged += new System.EventHandler(this.tblDanhSachFile_SizeChanged);
            // 
            // hMa
            // 
            this.hMa.HeaderText = "Mã";
            this.hMa.MinimumWidth = 75;
            this.hMa.Name = "hMa";
            this.hMa.ReadOnly = true;
            this.hMa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hMa.Width = 75;
            // 
            // hTenFile
            // 
            this.hTenFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hTenFile.HeaderText = "Tên file";
            this.hTenFile.MinimumWidth = 6;
            this.hTenFile.Name = "hTenFile";
            this.hTenFile.ReadOnly = true;
            // 
            // hKichThuoc
            // 
            this.hKichThuoc.HeaderText = "Kích thước";
            this.hKichThuoc.MinimumWidth = 200;
            this.hKichThuoc.Name = "hKichThuoc";
            this.hKichThuoc.ReadOnly = true;
            this.hKichThuoc.Width = 200;
            // 
            // hNgayTaiLen
            // 
            this.hNgayTaiLen.HeaderText = "Ngày tải lên";
            this.hNgayTaiLen.MinimumWidth = 250;
            this.hNgayTaiLen.Name = "hNgayTaiLen";
            this.hNgayTaiLen.ReadOnly = true;
            this.hNgayTaiLen.Width = 250;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblIPAddress,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1134, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(204, 20);
            this.toolStripStatusLabel1.Text = "Địa chỉ IP Web Service Server:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(93, 20);
            this.lblIPAddress.Text = "192.168.1.1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(33, 20);
            this.toolStripStatusLabel3.Text = "Đổi";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1134, 620);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tblDanhSachFile);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaiXuong);
            this.Controls.Add(this.btnTaiLen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "Đề tài 18 HTPT - Web Service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDanhSachFile)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Guna.UI2.WinForms.Guna2Button btnTaiLen;
        private Guna.UI2.WinForms.Guna2Button btnTaiXuong;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private System.Windows.Forms.DataGridView tblDanhSachFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn hMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn hKichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNgayTaiLen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel lblIPAddress;
    }
}

