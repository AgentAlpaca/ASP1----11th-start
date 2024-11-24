using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insert1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        animalservice shop= new animalservice();
        shop.addAnimals(this.TextBox1.Text, this.TextBox2.Text, int.Parse(this.TextBox3.Text ), TextBox4.Text);
    }
}