using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();

            Label1.Text = proxy.loginId(Convert.ToInt32(TextBox5.Text)).ToString();
            Label2.Text = proxy.password(TextBox3.Text, TextBox4.Text, Convert.ToInt32(TextBox5.Text));
        }
    }
}