using System;
using System.Collections.Generic;
using System.Data;
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
            //lblmsg3.Text = "hi page load evnt";
            //if (!IsPostBack)
            //{
            //    DataTable dt=new DataTable();
            //    dt.Columns.Add("name");
            //    dt.Columns.Add("email");
            //    dt.Columns.Add("mvname");
            //    dt.Columns.Add("show time");
            //    dt.Columns.Add("add ons");
            //    ViewState["movie"]=dt;
            //    Bindgrid();

            //}
            //btnbook.Visible = false;
            //if(!IsPostBack)
            //{
            //    ViewState["clickcount"] = 0;
            //}



        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            HttpCookie usercookie = new HttpCookie("userinfo");
            usercookie["Username"]="Name:"+txtname.Text;
            usercookie["Password"]="password :"+txtpass.Text;
            usercookie.Expires = DateTime.Now.AddSeconds(30);
            Response.Cookies.Add(usercookie);
            Response.Redirect("aspexample.aspx");








            //Response.Redirect("aspexample.aspx?firstname= " + txtname.Text + " " + "&password=" + txtpass.Text);
        }

        //protected void btnsub_click(object sender, EventArgs e)
        //{

        //    int count = (int)ViewState["clickcount"];
        //    count++;
        //    ViewState["clickcount"]=count;
        //    lblmsg.Text = "click counts" + count;

        //}
        //protected void Page_PreInIT(object sender, EventArgs e)
        //{
        //    lblmsg.Text = "pre init event <br>";

        //}
        //protected void Page_InIT(object sender, EventArgs e)
        //{
        //    lblmsg1.Text = " init event <br>";

        //}
        //protected void Page_InITComplete(object sender, EventArgs e)
        //{
        //    lblmsg2.Text = " initComplete event <br>";

        //}
        //protected void Page_LoadComplete(object sender, EventArgs e)
        //{
        //    lblmsg4.Text = "page load complete <br>";

        //}
        //protected void tstfname_textchanged(object sender, EventArgs e)
        //{
        //   if(txtname.Text.Length > 2)
        //    {
        //        btnbook.Visible = true;

        //    }
        //}
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

        //protected void btnbook_Click(object sender, EventArgs e)   
        //{
        //    string snacks = "";

        //    foreach (ListItem item in checkadd.Items)
        //    {
        //        if (item.Selected)
        //        {
        //            snacks += item.Text + ", ";
        //        }
        //    }


        //lblmsg.Text = " Your Movie Booking Deatils:" + "<br>" + "name:" + txtname.Text + "<br>" + "email:" + txtemail.Text + "<<br>" + "movie name: " + radiomv.SelectedValue +
        //    "<br>" + "show Time: " + radioshow.SelectedValue + "<br>" + "snacks: " +snacks+

        //    "<br>"+"enjoy your movie😊";

        //    DataTable dt = ViewState["movie"] as DataTable;
        //    dt.Rows.Add(txtname.Text,txtemail.Text,radiomv.SelectedValue,radioshow.SelectedValue,snacks);
        //    Bindgrid();

        //}
        //void Bindgrid()
        //{
        //    gvmv.DataSource = ViewState["movie"] as DataTable;
        //    gvmv.DataBind();
        //}




    }
}