using System;
using System.Collections.Generic;
using System.Drawing;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Game : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    private string word;
    private string wrongGuess;
    private string goodGuess;
    char[] currentGuess;
    public Game(string word, string wrongGuess, string goodGuess, char[] currentGuess)
    {
        this.word = word;
        this.wrongGuess = wrongGuess;
        this.goodGuess = goodGuess;
        this.currentGuess = currentGuess;
    }
    public string getWord()
    {
        return this.word;
    }
    public void setWord(string word)
    {

        this.word = word;
    }
    public string getWrongGuess() { return this.wrongGuess; }
    public void setWrongGuess(string wrongGuess) { this.wrongGuess = wrongGuess; }
    public void setGoodGuess(string goodGuess) { this.goodGuess = goodGuess; }
    public void setCurrentGuess(char[] CurrentGuess)
    {
        for (int i = 0; i < CurrentGuess.Length; i++)
        {
            this.currentGuess[i] = CurrentGuess[i];
        }


    }
}