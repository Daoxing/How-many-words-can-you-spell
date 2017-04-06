using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace How_many_words_can_you_spell
{
    class TableOfWord
    {
        //成员变量：
        public Label[] Letters=new Label[26];
        public String Word = "";
        public int Count = 0;
        public int[] position=new int[26];
        public TableOfLetters Partner = null;
        //成员函数：
        public TableOfWord() 
        {

            for (int i = 0; i < 26; i++)
            {
                position[i] = -1;
                Letters[i] = new Label();
                Letters[i].Text = "";
                Letters[i].MouseClick += new MouseEventHandler(TableOfWord_MouseClick);
                Letters[i].Size = new System.Drawing.Size(40, 40);
                if (i <= 5) Letters[i].Location = new System.Drawing.Point(15 + 40 * i, 30+240);
                else if (i <= 11) Letters[i].Location = new System.Drawing.Point(15 + 40 * (i - 6), 70 + 240);
                else if (i <= 17) Letters[i].Location = new System.Drawing.Point(15 + 40 * (i - 12), 110 + 240);
                else if (i <= 23) Letters[i].Location = new System.Drawing.Point(15 + 40 * (i - 18), 150 + 240);
                else Letters[i].Location = new System.Drawing.Point(15 + 40 * (i - 24), 190 + 240);
                Letters[i].Font = new System.Drawing.Font("Algerian", 24);
                Letters[i].Cursor = Cursors.Hand;
                Letters[i].BorderStyle = BorderStyle.FixedSingle;
                Letters[i].Enabled = true;
                Letters[i].Visible = true;
            }
                
        }
        void TableOfWord_MouseClick(Object o,EventArgs e) 
        {
            if(((Label)o).Text=="")return;
            int PositionInArrayPosition=0;
            for (; PositionInArrayPosition < 26; PositionInArrayPosition++) 
            {
                if (Letters[PositionInArrayPosition] == (Label)o) 
                {
                    MoveBackToTableOfLetters(Partner, PositionInArrayPosition, ((Label)o).Text);
                    ((Label)o).Text = "";                    
                    break;
                }
            }
            ArrangeTableOfWord(this);
        }
        private void ArrangeTableOfWord(TableOfWord TOW) 
        {
            String[] Word = new String[26];
            int[] SavePosition = new int[26];
            for (int i = 0; i < 26; i++) { Word[i] = ""; SavePosition[i] = -1; }
            string s = "";
            int n = 0;
            int np = 0;
            for (int i = 0; i < 26; i++) 
            {
                if (TOW.Letters[i].Text != "") { Word[n] = TOW.Letters[i].Text.ToString(); s += Word[n] + "\r\n"; n++; }
                if (position[i] != -1) { SavePosition[np] = position[i]; np++; }
            }
            
            for (int i = 0; i < 26 ; i++) 
            {
                if (Word[i] != "") { TOW.Letters[i].Text = Word[i].ToString(); position[i] = SavePosition[i]; }
                else { TOW.Letters[i].Text = ""; position[i] = -1; }
                
               
            }
           // MessageBox.Show(s.ToString() + "\r\n\r\n\r\n"+n);
        }
        public void GatherAllLetters() 
        {
            this.Word = "";
            for (int i = 0; i < 26; i++) 
            {
                if (this.Letters[i].Text.ToString() == "") break;
                else this.Word += this.Letters[i].Text.ToString();
            }
        }

        public void MoveBackToTableOfLetters(TableOfLetters TOL,int pos,String test) 
        {
            TOL.Letters[position[pos]].Text = test.ToString();
            position[pos] = -1;
            Count--;
        }

        public void ClearTable() 
        {
            for (int i = 0; i < 26; i++) 
            {
                this.Letters[i].Text = "";
                this.position[i] = -1;
                this.Word = "";
                this.Count = 0;
            }
        }
    }
}
