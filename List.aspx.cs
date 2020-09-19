using System;
using System.Web.UI;

namespace WebApplication2
{
    public partial class Entry : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshData();
            }
        }

        private void RefreshData()
        {
            GridView1.DataSource = DB.List();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }
    }
}