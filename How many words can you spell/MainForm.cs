using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace How_many_words_can_you_spell
{
    public partial class MainForm : Form
    {
        TableOfWord TOW = new TableOfWord();
        TableOfLetters TOL= new TableOfLetters();
        int CountOfLetter = 0;
        ArrayList WordsRecord = new ArrayList();
        String Path = "WordLists/";
        public MainForm()
        {
            
            InitializeComponent();
            for (int i = 0; i < 26; i++)
            {
                this.Controls.Add(TOL.Letters[i]);
                this.Controls.Add(TOW.Letters[i]); 
            }
            TOL.Partner = TOW;
            TOW.Partner = TOL;            
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                TOW.GatherAllLetters();
                if(TOW.Word=="")return;
                
                for (int i = 0; i < WordsRecord.Count; i++)
                    if (WordsRecord[i].ToString() == TOW.Word.ToString().ToLower())
                    {
                        string s = WordsRecord.IndexOf(i).ToString() + "       " + WordsRecord[i];
                        MessageBox.Show("You cannot use this word again!");
                        //TOW.Word = "";
                        return;
                    }
                String RealString = Path.ToString() + TOW.Letters[0].Text.ToString() + " Words.csv";
                StreamReader objReader = new StreamReader(RealString);
                String sline = objReader.ReadLine();
                while (sline != null)
                {
                    if (sline != null && sline.ToString() == TOW.Word.ToLower().ToString())
                    {
                        CountOfLetter+=sline.Count();
                        WordsRecord.Add(sline.ToString());
                        
                        Score.Text = "Score:Words(" + WordsRecord.Count + ").Letters:(" + CountOfLetter + ")!";
                        TOW.ClearTable(); TOL.ClearTable();
                        MessageBox.Show("you made right answer!!!");
                        return;
                    }
                    sline = objReader.ReadLine();
                }
                string EndMessage = "\r\nYour Score is " + "Score:Words(" + WordsRecord.Count + ").Letters:(" + CountOfLetter + ")!";
                MessageBox.Show("The answer is wrong and game over!!!" + EndMessage); 
                TOW.ClearTable(); 
                TOL.ClearTable();
                Application.Exit();
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual; //A
            this.Location = new Point(0, 0);
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        }

        
    }
}
