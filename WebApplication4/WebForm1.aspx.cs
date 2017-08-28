using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Number"] = new Random().Next(1, 101);
            }
        }

        protected void checkButton_Click(object sender, EventArgs e)
        {

            int guess = Convert.ToInt32(text.Text);
            int number = (int)ViewState["Number"];

            if (guess > number)
            {
                this.serverAnswerLabel.Text = "Look for lower number";
            }
            if (guess < number)
            {
                this.serverAnswerLabel.Text = "Look for higher number";
            }
            if (guess == number)
            {
                this.serverAnswerLabel.Text = "Right!";
            }

        }

        protected void text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}