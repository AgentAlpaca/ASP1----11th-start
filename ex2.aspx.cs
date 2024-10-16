using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ex2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        int num1=int.Parse(this.n1.Text);
        int num2 = int.Parse(this.n2.Text);
        this.result.Text=(num1+num2).ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int num1 = int.Parse(this.n1.Text);
        int num2 = int.Parse(this.n2.Text);
        this.result.Text = (num1 - num2).ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int num1 = int.Parse(this.n1.Text);
        int num2 = int.Parse(this.n2.Text);
        this.result.Text = (num1 * num2).ToString();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        int num1 = int.Parse(this.n1.Text);
        int num2 = int.Parse(this.n2.Text);
        if (num2 != 0)
        {
            this.result.Text = (num1 / num2).ToString();
        }
        else
        { this.result.Text = "Not possible"; }
    }
}