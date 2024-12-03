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

namespace _4com1
{
    public partial class frmProductType : Form
    {
        string strConnect = @"Data Source=DESKTOP-LOOS25L\SQLEXPRESS;Initial Catalog=miniDB_4COM1;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr;
        SqlDataAdapter dar = null;
        public frmProductType()
        {
            InitializeComponent();
            connectionDB_checking();
            getData();
        }
        private void getData()
        {
            string sql = "select * from tbProductType";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvShow.DataSource = dt;
        }
        private void connectionDB_checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
    }
}
