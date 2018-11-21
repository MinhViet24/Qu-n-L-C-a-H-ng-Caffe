using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;
using DTO;

namespace QuanLyCuaHangCaffee
{
    public partial class fLogin : Form
    {
        LoginBUS loginBus = new LoginBUS();
        public fLogin()
        {
           
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUserName.Text.Trim();
            pass = txtPass.Text.Trim();

            bool kq = false;
            try
            {
                Account acc = new Account(user, pass);
                kq = loginBus.Login(acc);
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Dang nhap loi.\n" + ex.Message, "Loi dang nhap");
            }

            if (kq)
                this.DialogResult = DialogResult.OK;
            else
            {
                DialogResult result = MessageBox.Show("Dang nhap sai.", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                    Application.Exit();
                else
                {
                    txtPass.Text = "";
                    txtUserName.Focus();
                }

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            //if (MessageBox.Show("Bạn muốn thoát!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //    e.Cancel = true;
        }

    
    }
}
        