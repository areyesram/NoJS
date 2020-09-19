using System;
using System.Web.UI;

namespace WebApplication2
{
    public partial class Edit : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            DB.Save(new BE
            {
                ID = int.Parse(TextBox1.Text),
                Name = TextBox2.Text
            });
            Response.Redirect("List.aspx");
        }
    }
}