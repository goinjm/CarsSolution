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
            
            if (ddlCars.Items.FindByValue(txtMake.Text + " - " + txtModel.Text + " - " + txtYear.Text) != null)
            {
                
            }
            else
            {
                //ddlCars.Items.Add(txtMake.Text + " - " + txtModel.Text + " - " + txtYear.Text);
                string text = string.Format("{0}|{1}|{2}",
                    txtMake.Text.PadRight(15, '\u00A0'),
                    txtModel.Text.PadRight(15, '\u00A0'),
                    txtYear.Text.PadRight(15, '\u00A0'));
                ddlCars.Items.Add(text);
            }
            
            
        }

        protected void Cars_OnTextChanged(object sender, EventArgs e)
        {
            string[] words = ddlCars.Text.Split('|');
            foreach (string word in words)
            {
                txtMake.Text = word;
                txtModel.Text = word;
                txtYear.Text = word;
            }
        }
    }
}