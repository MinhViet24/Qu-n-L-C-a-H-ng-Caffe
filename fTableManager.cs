using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;


namespace QuanLyCuaHangCaffee
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount account = new fAccount();
            account.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin admin = new fAdmin();
            admin.ShowDialog();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            fLogin login = new fLogin();

            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;             
            }

            TableShow();

        }

        public void TableShow()
        {
            
            DataTable dt = new TablesBUS().Get();
            foreach (DataRow item in dt.Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(80, 80);
                //btn.Text = item. + Environment.NewLine + item.status;

                flpTable.Controls.Add(btn);
            }
            //Button btn = new Button();
            //btn.Size = new Size(80, 80);
            //btn.Text = dgvFood.rows[index].cell[1].values.tostring().trim();
        }

        private void btAddFood_Click(object sender, EventArgs e)
        {

            string food;
            int categoryId;
            food = cbFood.SelectedValue.ToString();
            categoryId = int.Parse(cbCatagory.SelectedValue.ToString());
            
        }

        //void LoadTable()
        //{
        //    List<Tables> tableList = TableDAO.Instance.LoadTableList();

        //    foreach (Tables item in tableList)
        //    {
        //        Button btn = new Button() { Width = TablesDAO.TableWidth, Height = TablesDAO.TableHeight };
        //        btn.Text = item.Name + Environment.NewLine + item.Status;

        //        switch (item.Status)
        //        {
        //            case "Trống":
        //                btn.BackColor = Color.Aqua;
        //                break;
        //            default:
        //                btn.BackColor = Color.LightPink;
        //                break;
        //        }

        //        flpTable.Controls.Add(btn);
        //    }
        //}

    }
}
