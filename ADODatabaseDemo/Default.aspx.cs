using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace ADODatabaseDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        protected void SaveData(object sender, EventArgs e)
        {
            string ID = TxtID.Text;
            string name = TxtName.Text;
            string address = TxtAddress.Text;
            string sql = "insert into Student(ID,Name,Address) values('"+ ID +"','"  + name + "','" + address + "')";

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand(sql, con);
            using (con)
            {
                con.Open();                
                int k = cmd.ExecuteNonQuery();

                TxtID.Text = "ID";
                TxtName.Text = "Name";
                TxtAddress.Text = "Address";

                GetData();
            }                        
        }

        public void GetData()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            using (con)
            {
                string sql = "select * from Student";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }
        }
    }
}