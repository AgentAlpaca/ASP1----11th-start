using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class select1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        animalservice zoo = new animalservice();
        DataSet ds = zoo.getAnimals();
        this.GridVie.DataSource = ds;
        this.GridVie.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        animalservice zoo = new animalservice();
        DataSet ds = zoo.getAnimals();
        this.GridVie.DataSource = ds;
        this.GridVie.DataBind();
    }
}