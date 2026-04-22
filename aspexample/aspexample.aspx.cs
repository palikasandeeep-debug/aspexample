using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspexample
{
    public partial class aspexample : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["fistname"] == null && Session["password"]==null)
                {
                    Session["fistname"] = "Abc";
                    Session["password"] = "123";
                    lblstring.Text = "Well come :" + Session["fistname"] + Session["password"];
                    
                }
                else
                {
                    lblstring.Text = Session["fistname"] + " " + Session["password"];
                    lblfmsg.Text = Session["fistname"].ToString();
                    lblpmsg.Text = Session["password"].ToString();
                }
            }




















            //HttpCookie cookie = Request.Cookies["userinfo"];
            //if (cookie != null) 
            //{
               
            //    lblfmsg.Text = cookie["Username"];
            //    lblpmsg.Text = cookie["Password"];

            //}







            //string firstname=Request.QueryString["firstname"];
            //string password=Request.QueryString["password"];
            //lblmsg.Text = "well come" + firstname + " " + password;





            //if (!IsPostBack)
            //{
            //    btnadd.Enabled = false;
            //}
            //lblmsg3.Text = "hi page load event <br>";
            //btnsubmit.Visible = false;

            //if(!IsPostBack)
            //{
            //    DataTable dt=new DataTable();
            //    dt.Columns.Add("Fistname");
            //    dt.Columns.Add("Lastname");
            //    dt.Columns.Add("mobile");
            //    dt.Columns.Add("email");
            //    dt.Columns.Add("password");
            //    dt.Columns.Add("cpassword");
            //    dt.Columns.Add("gender");
            //    ViewState["person"] = dt;
            //    BindGrid();

            //}

        }
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
        //protected void txtfname_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtfname.Text.Length > 2)
        //    {
        //        btnsubmit.Visible = true;
        //    }
        //}
        //protected void btnsubmit_Click(object sender, EventArgs e)
        //{
        
        //    DataTable dt = ViewState["person"] as DataTable;
        //    dt.Rows.Add(txtfname.Text,txtlname.Text,txtmob.Text,txtemail.Text,txtpass.Text,txtcpass.Text,radiogen.SelectedValue);
        //    ViewState["person"]=dt;
        //    BindGrid();
        //    txtcpass.Text = "";
        //    txtemail.Text = "";
        //    txtfname.Text = "";
        //    txtlname.Text = "";
        //    txtmob.Text = "";
        //    txtpass.Text = "";
        //    radiogen.SelectedIndex = -1;
      
            

            

        //}
        
        //void BindGrid()
        //{
        //    gvperson.DataSource = ViewState["person"] as DataTable;
        //    gvperson.DataBind();
           

        //}

        //protected void txtfname_TextChanged1(object sender, EventArgs e)
        //{
        //    if (txtfname.Text.Length > 2)
        //    {
        //        btnsubmit.Visible = true;
        //    }
        //}


        //protected void btnsubmit_Click(object sender, EventArgs e)
        //{

        //    lblmsg.Text="perseon details are"+"<br>"+txtname.Text+"<br>"+txtmob.Text+"<br>"+txtemail.Text+"<br>"+radiogen.SelectedValue+"<br>"+chkhabbies.SelectedValue;

        //}

        //protected void btnlogout_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect ( "login.aspx");

        //}

        //protected void checkloginfileds(object sender, EventArgs e)
        //{
        //    if (txtusername.Text!= "" && txtpassword.Text 
        //        != "")
        //    {
        //        btnadd.Enabled = true;
        //    }


        //}
        // protected void CalculateFee(object sender, EventArgs e)
        //{
        //  int total = 0;
        //int net = 5000;
        //int java = 8000;
        ////int javanet = 0;
        //int python = 10000;
        //if (chkDotNet.Checked)
        //{
        //    lblmsg.Text = ".net fee is" + net;
        //}
        //if (Checkjava.Checked)
        //{
        //    lblmsg.Text = "java fee is: " + java;
        //}
        //if (Checkpython.Checked)
        //{
        //    lblmsg.Text = "python fee is:" + python;

        //}
        //if (Checkjava.Checked && chkDotNet.Checked)
        //{
        //    total = java + net;
        //    lblmsg.Text = "java and python fee is:" + total;
        //}
        //if (Checkjava.Checked && Checkpython.Checked)
        //{

        //    total = java + python;
        //    lblmsg.Text = "python and .net fee:" + total;


        //}
        //if (chkDotNet.Checked && Checkpython.Checked)
        //{
        //    total = net + python;
        //    lblmsg.Text = "dotnet and python fee" + total;

        //}
        //if (chkDotNet.Checked && Checkpython.Checked && Checkjava.Checked)
        //{
        //    total = net + python + java;
        //    lblmsg.Text = "total fee is:" + total;
        //}
        // ==================================
        //if(chkDotNet.Checked)
        //{
        //    total += 5000;
        //    lblmsg.Text = total.ToString();
        //}
        //if(Checkjava.Checked)
        //{
        //    total += 8000;
        //    lblmsg.Text=total
        //}
        //if(Checkpython.Checked)
        //{

        //}





        // }


        //protected void Habbies(object sender,EventArgs e)
        //{
        //    string habbi = "";
        //    if(chkread.Checked)
        //    {
        //        habbi += "reading"+"<br>";
        //        lblmsg.Text = "you are "+habbi;
        //    }
        //    if(Chkplaying.Checked)
        //    {
        //        habbi += "playing"+"<br>";
        //        lblmsg.Text = "your are " + habbi;
        //    }
        //    if(chkmvs.Checked)
        //    {
        //        habbi += " Watching movie";
        //        lblmsg.Text = "you are " + habbi;
        //    }

        //}


    }
}