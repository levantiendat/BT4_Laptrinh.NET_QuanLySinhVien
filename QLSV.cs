using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102210247_LeVanTienDat
{
    public class QLSV
    {
        public List<string> GetAllLSH()
        {
            List<string> db = new List<string>();
            string query = "Select LOPSH from LOPSINHHOAT";
            DataTable db1= new DataTable();
            db1 = DBHelper.Instance.GetRecords(query);
            for(int i=0; i < db1.Rows.Count; i++)
            {
                db.Add(db1.Rows[i][0].ToString());
            }
            return db.Distinct().ToList();
        }
        public DataTable GetAllSV()
        {
            DataTable db = new DataTable();
            
            db = DBHelper.Instance.GetAllSV();
            return db;
        }
        
        public DataTable GetSVBySearch(string lopsh, string txt)
        {
            DataTable db = new DataTable();
            string query;
            if (lopsh.CompareTo("All") == 0)
            {
                query = "Select MSSV,LOPSINHHOAT.LOPSH,NGAYSINH,GIOITINH,DIEMTRUNGBINH,ANH,HOCBA,CCCD  " +
                    "from SINHVIEN JOIN LOPSINHHOAT ON LOPSINHHOAT.ID = SINHVIEN.MALOP ";
                
            }
            else
            {
                
                query = "Select MSSV,LOPSINHHOAT.LOPSH,NGAYSINH,GIOITINH,DIEMTRUNGBINH,ANH,HOCBA,CCCD  " +
                    "from SINHVIEN JOIN LOPSINHHOAT ON LOPSINHHOAT.ID = SINHVIEN.MALOP " +
                    "where  LOPSINHHOAT.LOPSH= '"+lopsh+"' ";

            }
            if (txt != "")
            {
                SqlParameter name1 = new SqlParameter("@NameSV", txt);
                if (lopsh.CompareTo("All") == 0)
                query += " Where MSSV='" +txt+ "'";
                else query += " and MSSV='" + txt + "'";
                
            }
            db = DBHelper.Instance.GetRecords(query);
            return db;
        }
        public DataTable GetSVByMSSV(string mssv)
        {
            DataTable db = new DataTable();
            string query= "Select MSSV,LOPSINHHOAT.LOPSH,NGAYSINH,GIOITINH,DIEMTRUNGBINH,ANH,HOCBA,CCCD  " +
                "from SINHVIEN JOIN LOPSINHHOAT ON LOPSINHHOAT.ID = SINHVIEN.MALOP";
            query += " Where MSSV ='" + mssv + "'";
            db=DBHelper.Instance.GetRecords(query);
            return db;
        }
        public string GetClassID(string txt)
        {
            
            DataTable db= new DataTable();
            string query ="Select ID from LOPSINHHOAT WHERE LOPSH = '" + txt + "'";
            db=DBHelper.Instance.GetRecords(query);

            

            return db.Rows[0][0].ToString();
        }
        public void DelSV(List<string> li)
        {
            foreach(string i in li)
            {
                DBHelper.Instance.Delete(i);
            }
        }
        public DataTable SortBy(string txt)
        {
            DataTable db = new DataTable();
            string query = "Select MSSV,LOPSINHHOAT.LOPSH,NGAYSINH,GIOITINH,DIEMTRUNGBINH,ANH,HOCBA,CCCD  " +
                "from SINHVIEN JOIN LOPSINHHOAT ON LOPSINHHOAT.ID = SINHVIEN.MALOP ";
            if (txt == "MSSV")
            {

                query += " ORDER BY MSSV";
            }
            else if (txt == "Lớp SH")
            {
                query += " ORDER BY LOPSINHHOAT.LOPSH";
            }
            else if (txt == "Ngày sinh")
            {
                query += " ORDER BY NGAYSINH";
            }
            else
            {
                query += " ORDER BY DIEMTRUNGBINH desc";
            }
            db=DBHelper.Instance.GetRecords(query);
            return db;
        }
        private bool Check(string mssv)
        {
            bool check = false;

            foreach(DataRow i in DBHelper.Instance.GetAllSV().Rows)
            {
                if (mssv.CompareTo(i[0]) == 0)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public void SyncDB(List<string> sv)
        {
            if (Check(sv[0]))
            {
                DBHelper.Instance.Update(sv);
            }
            else
            {
                DBHelper.Instance.Add(sv);
            }
        }
    }
}
