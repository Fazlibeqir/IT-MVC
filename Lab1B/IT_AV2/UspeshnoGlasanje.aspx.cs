using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_AV2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblemail.Text = (string)Session["email"];
            finkiPredmet.Text = (string)Session["predmet"];
        }
    }
}