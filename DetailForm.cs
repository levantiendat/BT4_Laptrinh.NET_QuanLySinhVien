using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102210247_LeVanTienDat
{
    
    
    public partial class DetailForm : Form
    {
        public delegate void MyDel(string lsh, string txt);
        public MyDel d { get; set; }
        public string MSSV { get; set; }
    
    
        public DetailForm(string mssv)
        {
            MSSV= mssv;
            InitializeComponent();
            GetAllLSH();
            GUI();
        }
        public void GetAllLSH()
        {
            
            QLSV e = new QLSV();

            textlopsh.Items.AddRange(e.GetAllLSH().ToArray());
        }
        public void GUI()
        {
            if (MSSV != "")
            {
                QLSV f =new QLSV();
                DataTable p= new DataTable();
                p = f.GetSVByMSSV(MSSV);
                textname.Text = MSSV;
                textlopsh.Text = p.Rows[0][1].ToString();
                textDate.Text = p.Rows[0][2].ToString();
                textdtb.Text = p.Rows[0][4].ToString();
                if (Convert.ToBoolean(p.Rows[0][3].ToString()) == true)
                {
                    nam.Checked = true;
                }
                else
                {
                    nu.Checked = true;
                }

                anh.Checked = Convert.ToBoolean(p.Rows[0][5].ToString());
                hocba.Checked = Convert.ToBoolean(p.Rows[0][6].ToString());
                cccd.Checked = Convert.ToBoolean(p.Rows[0][7].ToString());
                textname.Enabled = false;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            QLSV f = new QLSV();
            List<string> sv=new List<string>();
            sv.Add(textname.Text.ToString());
            string idlop = f.GetClassID(textlopsh.Text.ToString());
            sv.Add(idlop.ToString());
            sv.Add(Convert.ToString(Convert.ToDateTime(textDate.Text.ToString())));
            if (nam.Checked) sv.Add("true");
            else sv.Add("false");
            string dtb1 = textdtb.Text.ToString();
            if (dtb1.Length == 1) dtb1 += ".0";
            if(dtb1.Length==3) dtb1 = dtb1[0] + "." + dtb1[2]+'0';
            else
            dtb1 = dtb1[0] + "." + dtb1[2]+dtb1[3];
            
            sv.Add(dtb1);
            sv.Add(anh.Checked.ToString());
            sv.Add(hocba.Checked.ToString());
            sv.Add(hocba.Checked.ToString());
            f.SyncDB(sv);
            d("All", "");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
