using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ex5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Image1.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Image1.Visible = true;
    }

    protected void Highlights_CheckedChanged(object sender, EventArgs e)
    {
        if (Highlights.Checked)
        {
            this.Label1.BorderWidth = 10;
        }
        else
        {
            this.Label1.BorderWidth = 0;
        }
    }

    protected void Back_CheckedChanged(object sender, EventArgs e)
    {
        if (Back.Checked)
        {
            this.Label1.BackColor = Color.Turquoise;
            
        }
        else
        {
            this.Label1.BackColor = Color.Red;
            
        }
        
    }

    protected void sendref_Click(object sender, EventArgs e)
    {
        
    }
}