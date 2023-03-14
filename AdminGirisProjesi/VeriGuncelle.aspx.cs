using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminGirisProjesi
{
    public partial class VeriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            DataSet1TableAdapters.TblAdminTableAdapter dt = new DataSet1TableAdapters.TblAdminTableAdapter();
            TextBox1.Text= x.ToString();
            TextBox1.Enabled = false;
            if(Page.IsPostBack==false)
            {
                TextBox2.Text = dt.VeriGetir(Convert.ToInt32(TextBox1.Text))[0].Kullanici;
                TextBox3.Text = dt.VeriGetir(Convert.ToInt32(TextBox1.Text))[0].Sifre;
                TextBox4.Text = dt.VeriGetir(Convert.ToInt32(TextBox1.Text))[0].Sifre;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblAdminTableAdapter dt = new DataSet1TableAdapters.TblAdminTableAdapter();
            dt.AdminGuncelle(TextBox2.Text,TextBox3.Text,Convert.ToInt32(TextBox1.Text));
            Response.Redirect("Veriler.Aspx");
        }
    }
}