using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hangman : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.Panel2.Visible = false;
        // this.Panel2.Visible = true;
        // foreach (Control c in Panel2.Controls)
        // {
        //   if (c is Button)
        //        ((Button)c).Enabled = true;
        // }
       
        TableRow row=new TableRow();

        if (!IsPostBack) {
         InitGame();


        }
        //  this.lblLetter.Text = Session["SavedWord"].ToString();

       
    }
    
        private void ShowWord()
    {
        string word = Session["SavedWord"].ToString();
        this.TableChars.Rows.Clear();
        TableRow row=new TableRow();
        this.TableChars.Rows.Add(row);
        for(int i = 0; i < word.Length; i++)
        {
            this.TableChars.Width = word.Length * 100;
            TableCell newCell = new TableCell();
            newCell.Visible = true;
            newCell.Width = 200;
            newCell.Height = 50;
            newCell.BackColor = Color.Plum;
            newCell.BorderColor = Color.Red;
            newCell.BorderStyle = BorderStyle.Double;
            newCell.HorizontalAlign = HorizontalAlign.Center;
            newCell.Text = word[i].ToString();
            this.TableChars.Rows[0].Cells.AddAt(0,newCell);

        }
    }
    public string Words()
    {
        string[] words = new string[]
{
    "apple", "grape", "chair", "table", "house", "water", "stone", "brick", "clock", "glass",
    "plant", "beach", "ocean", "brush", "grass", "paint", "river", "flame", "storm", "night",
    "light", "color", "earth", "music", "photo", "dream", "fruit", "sound", "world", "plane",
    "child", "space", "peace", "laugh", "sleep", "smile", "dance", "fresh", "drink", "sugar",
    "salad", "story", "movie", "smart", "video", "funny", "happy", "cloud", "short", "books",
    "words", "great", "apple", "earth", "money", "clean", "truth", "faith", "quick", "flair"
};
        Random random = new Random();
        return words[random.Next(words.Length)];

    }
    public void InitGame()
    {
        if (Session["SavedWord"] == null)
        {
            string word = Words();
            Session["SavedWord"] = word;
          
        }
        ShowWord();
      

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
        this.A.BackColor = System.Drawing.Color.Red;
        this.Label1.Text=this.A.Text;
    }

    protected void B_Click(object sender, EventArgs e)
    {
      this.B.Enabled = false;
      this.B.BackColor = System.Drawing.Color.Red;
        this.Label1.Text=this.B.Text;
    }


    protected void C_Click(object sender, EventArgs e)
    {
       this.C.Enabled = false;
      this.C.BackColor = System.Drawing.Color.Red;
        this.Label1.Text=this.C.Text;
    }
  
     protected void E_Click(object sender, EventArgs e)
    { 
        this.E.Enabled = false;
this.E.BackColor = System.Drawing.Color.Red;
        this.Label1.Text= this.E.Text;
    }

    protected void G_Click(object sender, EventArgs e)
    {
        this.G.Enabled = false;
        this.G.BackColor= System.Drawing.Color.Red;
        this.Label1.Text= this.G.Text;

    }

    protected void D_Click(object sender, EventArgs e)
    {
       this.D.Enabled = false;
        this.D.BackColor= System.Drawing.Color.Red;
        this.Label1.Text=this.D.Text;
    }
    protected void Z_Click1(object sender, EventArgs e)
    {
        this.Z.Enabled = false;
        this.Z.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.Z.Text;
    }

    protected void X_Click1(object sender, EventArgs e)
    {
        this.X.Enabled = false;
        this.X.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.X.Text;
    }


    protected void V_Click(object sender, EventArgs e)
    {
        this.V.Enabled = false;
        this.V.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.V.Text;
    }

    protected void N_Click(object sender, EventArgs e)
    {
        this.N.Enabled = false;
        this.N.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.N.Text;
    }

    protected void M_Click(object sender, EventArgs e)
    {
        this.M.Enabled = false;
        this.M.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.M.Text;
    }

    protected void S_Click(object sender, EventArgs e)
    {
        this.S.Enabled = false;
        this.S.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.S.Text;
    }

    protected void F_Click(object sender, EventArgs e)
    {
        this.F.Enabled = false;
        this.F.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.F.Text;
    }

    protected void H_Click(object sender, EventArgs e)
    {
        this.H.Enabled = false;
        this.H.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.H.Text;
    }

    protected void J_Click(object sender, EventArgs e)
    {
        this.J.Enabled = false;
        this.J.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.J.Text;
    }

    protected void K_Click(object sender, EventArgs e)
    {
        this.K.Enabled = false;
        this.K.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.K.Text;
    }

    protected void L_Click(object sender, EventArgs e)
    {
        this.L.Enabled = false;
        this.L.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.L.Text;
    }

    protected void Q_Click(object sender, EventArgs e)
    {
        this.Q.Enabled = false;
        this.Q.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.Q.Text;
    }

    protected void W_Click(object sender, EventArgs e)
    {
        this.W.Enabled = false;
        this.W.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.W.Text;
    }

    protected void R_Click(object sender, EventArgs e)
    {
        this.R.Enabled = false;
        this.R.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.R.Text;
    }

    protected void T_Click(object sender, EventArgs e)
    {
        this.T.Enabled = false;
        this.T.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.T.Text;
    }

    protected void Y_Click(object sender, EventArgs e)
    {
        this.Y.Enabled = false;
        this.Y.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.Y.Text;
    }

    protected void U_Click(object sender, EventArgs e)
    {
        this.U.Enabled = false;
        this.U.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.U.Text;
    }

    protected void I_Click(object sender, EventArgs e)
    {
        this.I.Enabled = false;
        this.I.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.I.Text;
    }

    protected void O_Click(object sender, EventArgs e)
    {
        this.O.Enabled = false;
        this.O.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.O.Text;
    }

    protected void P_Click(object sender, EventArgs e)
    {
        this.P.Enabled = false;
        this.P.BackColor = System.Drawing.Color.Red;
        this.Label1.Text = this.P.Text;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        Session.Clear();
        Response.Redirect(Request.RawUrl);
        InitGame();
           
        
    }

    protected void Hide_Click(object sender, EventArgs e)
    {
        this.Panel2.Visible = false;
    }

    protected void Enable_Click(object sender, EventArgs e)
    {
        this.Panel2.Enabled = true;
    }

    protected void Show_Click(object sender, EventArgs e)
    {
        this.Panel2.Visible= true;
    }

    protected void Disable_Click(object sender, EventArgs e)
    {
        this.Panel2.Enabled= false;
    }
}