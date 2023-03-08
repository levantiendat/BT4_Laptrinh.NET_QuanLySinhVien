using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102210247_LeVanTienDat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetAllData();
        }
        public void GetAllData()
        {       
            
            QLSV e = new QLSV();
            data.DataSource =e.GetAllSV();
            lop1.Items.AddRange(e.GetAllLSH().ToArray());
        }
        public void ShowDGV(string lopsh, string txt)
        {
            QLSV f=new QLSV();
            data.DataSource=f.GetSVBySearch(lopsh, txt);

        }
        private void buttonadd_Click(object sender, EventArgs e)
        {
            DetailForm dtf = new DetailForm("");
            
            dtf.d += new DetailForm.MyDel(ShowDGV);
            //ShowDGV("All", "");
            dtf.Show();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count == 1)
            {
                string mssv = data.SelectedRows[0].Cells["MSSV"].Value.ToString();
                DetailForm f = new DetailForm(mssv);
                f.d += new DetailForm.MyDel(ShowDGV);
                f.Show();
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (data.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in data.SelectedRows)
                {
                    list.Add(i.Cells["MSSV"].Value.ToString());
                }
                QLSV f = new QLSV();
                f.DelSV(list);
                ShowDGV("All", "");
                //ShowDGV(lop1.SelectedItem.ToString(), textsearch.Text);
            }
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            
            QLSV f = new QLSV();

            data.DataSource = f.SortBy(sort.SelectedItem.ToString());
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string lopsh = lop1.SelectedItem.ToString();
            string txt=textsearch.Text;
            ShowDGV(lopsh, txt);
        }
    }
}
