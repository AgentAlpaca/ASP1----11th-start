using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hangman : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.Panel2.Visible = false;
        this.Panel2.Visible = true;
        foreach (Control c in Panel2.Controls)
        {
            if (c is Button)
                ((Button)c).Enabled = false;
        }
    }
    protected void Button_click(object sender, System.EventArgs e)
    {
        Button buttonClicked=(Button)sender;
        buttonClicked.Enabled = false;
        lblLetter.Text=buttonClicked.Text;
    }

    protected void A_Click(object sender, EventArgs e)
    {
        this.A.Enabled = false;
        this.Label1.Text=this.A.Text;
    }

    protected void B_Click(object sender, EventArgs e)
    {
        this.B.Enabled = false;
        this.Label1.Text=this.B.Text;
    }


    protected void C_Click(object sender, EventArgs e)
    {
        this.C.Enabled = false;
        this.Label1.Text=this.C.Text;
    }
}