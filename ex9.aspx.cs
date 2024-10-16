using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ex9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        Label2.Text = "";
        this.dropyear.SelectedValue=DateTime.Now.Year.ToString();
        this.dropmonth.SelectedValue=DateTime.Now.Month.ToString();
        
        if (!Page.IsPostBack){
            this.addBirthYears();
            this.Calendar1.VisibleDate = new DateTime(2024, 9, 1);
        }
        else
        {
            this.Label1.Text = "";
        }
         

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "You picked the date " + Calendar1.SelectedDate;
    }
    private void addBirthYears()
    {
        
        int endyear = DateTime.Now.Year - 120;
        for(int year=DateTime.Now.Year; year > endyear; year--)
        {
           ListItem item = new ListItem();
            item.Text = year.ToString();
            item.Value=year.ToString();
           this.dropyear.Items.Add(year.ToString());
            
        }
        this.dropyear.SelectedValue=DateTime.Now.Year.ToString();
        
    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        
        
        
        if(e.Day.Date.Day == 30 && e.Day.Date.Month == 3)
        {
            Label mylabel=new Label();
            mylabel.Text = "<br> birthday";
            e.Cell.Controls.Add(mylabel);
            mylabel.ForeColor = Color.Ivory;
        }
       
        if (e.Day.Date.DayOfWeek == DayOfWeek.Saturday)
        {
            e.Cell.ForeColor = Color.Red;
            e.Cell.Font.Bold = true;


        }
        if (e.Day.Date < DateTime.Now)
        {
            e.Day.IsSelectable = false;
            e.Cell.ForeColor = Color.Silver;
        }
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Day_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void dropday_SelectedIndexChanged(object sender, EventArgs e)
    {
        //this.Label2.Text = this.dropday.SelectedValue + "/" + this.dropmonth.SelectedValue + "/" + this.dropyear.SelectedValue;

    }

    protected void dropmonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.dropyear.SelectedIndex > 0)
        {
            int endday = 31;
            this.dropday.Items.Clear();
            int birthyear = int.Parse(this.dropyear.SelectedValue);
            endday = DateTime.DaysInMonth(birthyear, int.Parse(this.dropmonth.SelectedValue));
            for (int day = 1; day <= endday; day++)
            {
                ListItem ite = new ListItem();
                ite.Text = day.ToString();
                ite.Value = day.ToString();
                dropday.Items.Insert(day, ite);
            }
          
        }
        else
        {
            this.Label1.Text = "";
        }
    }
}