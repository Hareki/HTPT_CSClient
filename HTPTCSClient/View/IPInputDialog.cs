using HTPTCSClient.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTPTCSClient.View
{
    public partial class IPInputDialog : Form
    {
        MainForm MainForm;
        WSController Controller;
        public IPInputDialog()
        {
            InitializeComponent();
        }
        public IPInputDialog(MainForm main)
        {
            InitializeComponent();
            this.MainForm = main;
            this.Controller = main.Controller;
        }


        private static Regex _ipV4Regex = new Regex(@"^((25[0-5]|(2[0-4]|1[0-9]|[1-9]|)[0-9])(\.(?!$)|$)){4}$");
        private void btnOK_Click(object sender, EventArgs e)
        {
            textIP.Text = textIP.Text.Trim();
            if (_ipV4Regex.IsMatch(textIP.Text) || textIP.Text.Equals("localhost"))
            {
                MainForm.PreviousIP = MainForm.lblIPAddress.Text;
                MainForm.lblIPAddress.Text = textIP.Text;
                Controller.RefreshRestClient(textIP.Text);

                if (!this.MainForm.Visible)////nếu như là lúc khởi động chương trình
                {
                    this.MainForm.Visible = true;
                    this.Visible = false;
                }
                else//nếu như là lúc đổi
                {
                    this.MainForm.Activate();
                    this.MainForm.LoadAllFileInfos();
                    this.MainForm.CheckBtnXoaBtnTaiXuongState();
                    this.Close();
                }

            }
            else
            {
                lblThongBao.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
