using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cars
{
    public partial class Cars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //confirm item present; add if it isn't
            string text = string.Format("{0}|{1}|{2}",
                    txtMake.Text.PadRight(15, '\u00A0'),
                    txtModel.Text.PadRight(15, '\u00A0'),
                    txtYear.Text.PadRight(15, '\u00A0'));

            if (ddlCars.Items.FindByText(text) != null)
            {
                
            }
            else
            {
                ddlCars.Items.Add(text);
            }
            ddlCars.SelectedValue = text;

        }

        protected void ddlCars_IndexChanged(object sender, EventArgs e)
        {
            string[] words = ddlCars.Text.Split('|');
            int i = 1;
            foreach (string word in words)
            {
                switch (i)
                {
                    case 1:
                        txtMake.Text = word;
                        break;
                    case 2:
                        txtModel.Text = word;
                        break;
                    case 3:
                        txtYear.Text = word;
                        break;
                    default:
                        break;
                }
                i++;
            }
        }
    }
}