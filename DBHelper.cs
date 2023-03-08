using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102210247_LeVanTienDat
{
    internal class DBHelper
    {
        private static DBHelper _Instance;
        private SqlConnection _cnn;
        private SqlCommand cmd;
        private DBHelper(string s)
        {
            _cnn = new SqlConnection(s);
        }
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DBHelper("Data Source=DESKTOP-6CLAM5L\\TIENDAT_SQL;Initial Catalog=DBSinhVien;Integrated Security=True");
                return _Instance;
            }
            private set { }
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }
        
        public void ExecuteDBS(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        public DataTable GetAllSV()
        {
            string query = "Select MSSV,LOPSINHHOAT.LOPSH,NGAYSINH,GIOITINH,DIEMTRUNGBINH,ANH,HOCBA,CCCD  " +
                "from SINHVIEN JOIN LOPSINHHOAT ON LOPSINHHOAT.ID = SINHVIEN.MALOP ";
            DataTable dt = new DataTable();
            dt = GetRecords(query);
            return dt;
        }
        public void Add(List<string> sv)
        {

            string query1 =string.Format( "Insert INTO SINHVIEN(MSSV,MALOP,NGAYSINH,GIOITINH,DIEMTRUNGBINH,ANH,HOCBA,CCCD) " +
                "VALUES('{0}',{1},'{2}','{3}',{4},'{5}','{6}','{7}')", sv[0], sv[1], sv[2],sv[3], sv[4] , sv[5], sv[6], sv[7]);
            
            ExecuteDBS(query1);
            
            
            
        }
        public void Update(List<string> sv)
        {
            string query = "UPDATE SINHVIEN SET ";
            query +=" MALOP ="+sv[1]  ;
            query += " ,NGAYSINH = '" + sv[2]+"'";
            query+=" ,GIOITINH = '" + sv[3] + "'";
            query += " ,DIEMTRUNGBINH =" + sv[4] ;
            query+=" ,ANH = '"+ sv[5] + "'";
            query += " ,HOCBA = '" + sv[6] + "'";
            query += " ,CCCD = '" + sv[7] + "'";
            query += " WHERE MSSV = '" + sv[0] + "'";
            ExecuteDBS(query);
        }
        public void Delete(string mssv)
        {
            string query = "DELETE FROM SINHVIEN WHERE MSSV='"+mssv+"'";
            ExecuteDBS(query);
        }
    }
}
