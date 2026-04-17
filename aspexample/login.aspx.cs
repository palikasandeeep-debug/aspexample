using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspexample
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            



        }

        //protected void tbnlink_Click(object sender, EventArgs e)
        //{
        //    if (txtname.Text == "sandeep" && txtpassword.Text == "palika123")
        //    {

        //        Response.Redirect("aspexample.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("invalid credetials");

        //    }
        //}
        //protected void btninsta_click(object sender, EventArgs e)
        //{
        //    Response.Redirect("https://www.instagram.com/");

        //}

        protected void btnbook_Click(object sender, EventArgs e)   
        {
            string snacks = "";

            //foreach (ListItem item in checkadd.Items)
            //{
            //    if (item.Selected)
            //    {
            //        snacks += item.Text + ", ";
            //    }
            //}


            lblmsg.Text = " Your Movie Booking Deatils:" + "<br>" + "name:" + txtname.Text + "<br>" + "email:" + txtemail.Text + "<<br>" + "movie name: " + radiomv.SelectedValue +
                "<br>" + "show Time: " + radioshow.SelectedValue + "<br>" + "snacks: " +snacks+
                
                "<br>"+"enjoy your movie😊";
     

        }
    }
}