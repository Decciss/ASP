using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASPPAB
{
    public partial class Zawodnicy : System.Web.UI.Page
    {
        //string connString = "Data Source = DESKTOP - UQOV7LN; Initial Catalog = DBPROJEKT; Integrated Security = True";
        string connString = @"Data Source=KAKA-KOMPUTER\BAZYPROJEKT;Initial Catalog=SRBD;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.Visible = true;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("AfterLogin.aspx");

        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            int maxid = 0;
            String query = "SELECT MAX(prod_id) FROM Producent;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            maxid = (int)cmd.ExecuteScalar();
            maxid += 1;
            conn = new SqlConnection(connString);
            conn.Open();
            query = "Insert into Producent Values("+maxid+",'" + TextBox1.Text+ "','" + TextBox2.Text + "');";
            SqlCommand dmd = new SqlCommand(query, conn);
            dmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("Zawodnicy.aspx");
        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        protected void Button16_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            int maxid = 0;
            String query = "SELECT MAX(pro_id) FROM Produkt;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            maxid = (int)cmd.ExecuteScalar();
            maxid += 1;
            conn = new SqlConnection(connString);
            conn.Open();
            query = "Insert into Produkt Values(" + maxid + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "');";
            SqlCommand dmd = new SqlCommand(query, conn);
            dmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}