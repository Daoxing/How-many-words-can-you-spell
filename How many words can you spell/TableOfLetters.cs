using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace How_many_words_can_you_spell
{
    class TableOfLetters
    {
        //成员变量：
        public Label[] Letters = new Label[26];
        public Char A = 'A';
        public TableOfWord Partner = null;
        //成员函数：
        public TableOfLetters()
        {
            Random ran = new Random();        
            //为每一个label标签的text放入一个字母
            for (int i = 0; i < 26; i++)
            {
                Letters[i] = new Label();
                //The letter should be random,but so far I do not have any solution,so it is hang.
                Letters[i].Text = ((char)(A + ran.Next(0, 25))).ToString();
                Letters[i].MouseClick += new MouseEventHandler(TableOfLetters_MouseClick);
                Letters[i].Size=new System.Drawing.Size(40,40);
                if(i<=5)Letters[i].Location = new System.Drawing.Point(15 + 40 * i, 30);
                else if(i<=11) Letters[i].Location = new System.Drawing.Point(15 + 40 * (i-6), 70);
                else if (i <= 17) Letters[i].Location = new System.Drawing.Point(15 + 40 * (i - 12), 110);
                else if (i <= 23) Letters[i].Location = new System.Drawing.Point(15 + 40 * (i - 18), 150);
                else Letters[i].Location = new System.Drawing.Point(15 + 40 * (i - 24), 190);
                Letters[i].Font = new System.Drawing.Font("Algerian",24);
                Letters[i].Cursor =Cursors.Hand;
                Letters[i].BorderStyle = BorderStyle.FixedSingle;
                Letters[i].Enabled = true;
                Letters[i].Visible = true;
            }
           
        }
        void TableOfLetters_MouseClick(Object o, EventArgs e)
        {
            if(((Label)o).Text=="")return;
            for (int i = 0; i < 26; i++) 
            {
                if (((Label)o) == Letters[i]) 
                {
                    MoveToTableOfWord(Partner,i, ((Label)o).Text.ToString());
                    ((Label)o).Text = "";
                }
            }
        }

        public void MoveToTableOfWord(TableOfWord TOL, int pos, String test)
        {
            TOL.Letters[TOL.Count].Text = test.ToString();
            TOL.position[TOL.Count] = pos;
            TOL.Count++;
            
        }

        public void ClearTable() 
        {
            //this function is going to recreate all letters
            Random ran = new Random();
            for (int i = 0; i < 26; i++) Letters[i].Text = ((char)(A + ran.Next(0, 25))).ToString();
        }
    }
}
