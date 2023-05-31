using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace IT_AV2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                string[] predmeti = new string[]{
               "Интернет Технологии",
                "Интернет",
               "Дигитална Електроника"
                };
                foreach (string s in predmeti)
                {
                    lbPredmeti.Items.Add(s);
                }
                string[] krediti = new string[]
                {
                 "6" ,
                "5.5",
                "5.5"
                };
                for (int i = 0; i < krediti.Length; i++)
                {
                    lbKrediti.Items.Add(krediti[i]);
                }
                string[] profesori = new string[]
              {
                    "Проф. д-р Гоце Арменски",
                    "Проф. Интернет",
                    "Проф. ДЕ"
              };
                foreach (string prof in profesori)
                {
                    listProf.Items.Add(prof);
                }
            }
        }

        protected void vote(object sender, EventArgs e)
        {
            if (lbPredmeti.SelectedItem != null && lbKrediti.SelectedItem != null)
            {
                string predmet = lbPredmeti.SelectedItem.Text;
                Session["predmet"] = predmet;
               // Response.Redirect("UspeshnoGlasanje.aspx");
                Server.Transfer("UspeshnoGlasanje.aspx");
            }
        }


        protected void add_Click(object sender, EventArgs e)
        {


            string predmet = addDelPredmeti.Text;
            string krediti = addDelKrediti.Text;
            string prof = "Проф. " + predmet;
            if (!lbPredmeti.Items.Contains(new ListItem(predmet)))
            {
                lbPredmeti.Items.Add(predmet);
                lbKrediti.Items.Add(krediti);
                listProf.Items.Add(prof);
            }
            else
            {
                lblProfesor.Text = "Cant Add the same Subject";
                lblProfesor.CssClass = "text-danger";
            }
        }
        protected void delete_Click(object sender, EventArgs e)
        {
            if (lbPredmeti.SelectedIndex != -1 )
            {
                int index = lbPredmeti.SelectedIndex;
                lbPredmeti.Items.RemoveAt(index);
                lbKrediti.Items.RemoveAt(index);
                listProf.Items.RemoveAt(index);
                lblProfesor.Text = string.Empty;
            }

        }
        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKrediti.SelectedIndex = lbPredmeti.SelectedIndex;
            var selected = lbPredmeti.SelectedIndex;
            var prof = listProf.Items[selected];
            lblProfesor.Text = prof.Text;
        }
    }
}