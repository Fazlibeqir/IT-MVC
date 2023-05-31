using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace IT_AV2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void button_Click(object sender, EventArgs e)
        {
            /*
                  Table2.Visible = true;
            Table1.Visible = false;
          
            }*/
            if (password != null)
            {
                Session["email"] = email.Text;
                Response.Redirect("Glasaj.aspx");



            }

        

        }
    }
}