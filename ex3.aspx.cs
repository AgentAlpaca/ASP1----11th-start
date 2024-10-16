using System;
using System.Activities.Expressions;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ex3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Image1.Visible = false;
        this.Image2.Visible = false;
        this.Image3.Visible = false;

        switch (this.RadioButtonList1.SelectedValue)
        {
            case "1":this.Image1.Visible=true; 
                break;
            case "2":this.Image2.Visible=true; 
                break;
            case "3":this.Image3.Visible=true;
                break;
            
        }
    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Image1.Visible = true;
       
    }





    protected void CheckBoxList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        foreach (ListItem item in this.CheckBoxList1.Items)
        {
            if (item.Selected == true)
            {
                switch (item.Value) {
                    case "1": this.Image1.Visible = true; break;
                    case "2": this.Image2.Visible = true;
                        break;
                    case "3": this.Image3.Visible = true;
                        break;

                }
            }
            else {
                switch (item.Value)
                {
                    case "1": this.Image1.Visible = false; break;
                    case "2":
                        this.Image2.Visible = false;
                        break;
                    case "3":
                        this.Image3.Visible = false;
                        break;
                }
            }
        }
    }
}
    
