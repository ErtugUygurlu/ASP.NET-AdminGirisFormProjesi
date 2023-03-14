using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminGirisProjesi
{
    public partial class Veriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblAdminTableAdapter dt = new DataSet1TableAdapters.TblAdminTableAdapter();
            Repeater1.DataSource = dt.AdminListesi();
            Repeater1.DataBind();


        }
    }
}