using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HTPTCSClient.Controller;
using HTPTCSClient.Model;
using HTPTCSClient.View;
using Microsoft.VisualBasic;

namespace HTPTCSClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public string PreviousIP;

        private readonly string[] Units = new string[] { "Bytes", "KB", "MB", "GB", "TB" };
        public readonly WSController Controller = new WSController();
        public void LoadAllFileInfos(bool isInit = false)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            List<FileInfo> listInfo = Controller.GetAllFileInfos();
            if (listInfo is null)
            {

                MessageBox.Show(this, "Không thể kết nối đến Server tại địa chỉ IP vừa nhập, đó có thể là do:\n" +
                    "   - Nhập sai địa chỉ IP mong muốn\n" +
                    "   - Server tại địa chỉ IP mong muốn chưa được khởi động",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

                if (isInit)
                {
                    lblIPAddress.Text += " (Lỗi kết nối)";
                }
                else
                {
                    lblIPAddress.Text = PreviousIP;
                }
                Cursor.Current = Cursors.Default;

                this.btnLamMoi.Enabled = this.btnTaiLen.Enabled = this.btnTaiXuong.Enabled = false;
                return;
            }
            tblDanhSachFile.DataSource = null;
            tblDanhSachFile.Rows.Clear();
            foreach (var info in listInfo)
            {
                Console.WriteLine(info.UploadedDate);
                tblDanhSachFile.Rows.Add(info.Id, info.Name, ReadableFileSize(info.Size), info.UploadedDate.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            lblIPAddress.Text = lblIPAddress.Text.Replace(" (Lỗi kết nối)", "");
            this.btnLamMoi.Enabled = this.btnTaiLen.Enabled = this.btnTaiXuong.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private string ReadableFileSize(long sizeInByte)
        {
            if (sizeInByte <= 0)
            {
                return "0";
            }
            int digitGroups = (int)(Math.Log10((double)sizeInByte) / Math.Log10(1024.0));
            double newSize = (double)sizeInByte / Math.Pow(1024.0, (double)digitGroups);
            return newSize.ToString("#,##0.#", CultureInfo.InvariantCulture) + " " + Units[digitGroups];

        }

        public void CheckBtnXoaBtnTaiXuongState()
        {
            if (tblDanhSachFile.Rows.Count == 0)
            {
                btnTaiXuong.Enabled =
                btnXoa.Enabled = false;
            }
            else
            {
                btnTaiXuong.Enabled =
                btnXoa.Enabled = true;
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadAllFileInfos();
        }

        private void CreateMessageBoxFromMyMessage(MyMessage message)
        {
            if (message.MStatus == MyMessage.Status.SUCCESS)
            {
                MessageBox.Show(this, message.Content,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, message.Content,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnTaiLen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                MyMessage message = Controller.UploadFile(fileName);
                CreateMessageBoxFromMyMessage(message);
                if (message.MStatus == MyMessage.Status.SUCCESS)
                {
                    LoadAllFileInfos();
                    CheckBtnXoaBtnTaiXuongState();
                }
            }
        }

        private void BtnTaiXuong_Click(object sender, EventArgs e)
        {
            int selectedRow = tblDanhSachFile.CurrentCell.RowIndex;
            if (selectedRow == -1)
            {
                MyMessage message = new MyMessage("Vui lòng chọn file!");
                CreateMessageBoxFromMyMessage(message);
                return;
            }
            int id = Int32.Parse(tblDanhSachFile.Rows[selectedRow]
                    .Cells["hMa"].Value.ToString());
            string suggestedFileName = tblDanhSachFile.Rows[selectedRow]
                    .Cells["hTenFile"].Value.ToString();
            saveFileDialog.FileName = suggestedFileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullFileName = saveFileDialog.FileName;
                MyMessage message = Controller.DownloadFile(id, fullFileName);
                CreateMessageBoxFromMyMessage(message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int selectedRow = tblDanhSachFile.CurrentCell.RowIndex;
            MyMessage message;
            if (selectedRow == -1)
            {
                message = new MyMessage("Vui lòng chọn file!");
                CreateMessageBoxFromMyMessage(message);
                return;
            }
            var confirmResult = MessageBox.Show(this, "Bạn có chắc muốn xoá file này không?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            int id = Int32.Parse(tblDanhSachFile.Rows[selectedRow]
                    .Cells["hMa"].Value.ToString());
            message = Controller.DeleteFile(id);
            CreateMessageBoxFromMyMessage(message);
            if (message.MStatus == MyMessage.Status.SUCCESS)
            {
                LoadAllFileInfos();
                CheckBtnXoaBtnTaiXuongState();
            }
        }

        private void tblDanhSachFile_SizeChanged(object sender, EventArgs e)
        {
            tblDanhSachFile.Region =
                System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblDanhSachFile.Width, tblDanhSachFile.Height, 20, 20));
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            new IPInputDialog(this).ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAllFileInfos(true);
            CheckBtnXoaBtnTaiXuongState();
            tblDanhSachFile.Region =
                System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tblDanhSachFile.Width, tblDanhSachFile.Height, 20, 20));
            tblDanhSachFile.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
