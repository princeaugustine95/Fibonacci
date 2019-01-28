using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fibonnaci
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int a = 0, b = 1, c = 0;
            Response.Write(a);
            Response.Write(b);
            for(int i=2;i<num;i++)
            {
                c = a + b;
                Response.Write(c);
                a = b;
                b = c;
            }

        }
    }
}