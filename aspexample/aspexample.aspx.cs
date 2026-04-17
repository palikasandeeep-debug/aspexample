using System;
using System.Collections.Generic;
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
            //if (!IsPostBack)
            //{
            //    btnadd.Enabled = false;
            //}

        }

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