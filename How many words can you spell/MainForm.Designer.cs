namespace How_many_words_can_you_spell
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Letters = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Letters
            // 
            this.Letters.AutoSize = true;
            this.Letters.Cursor = System.Windows.Forms.Cursors.Default;
            this.Letters.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letters.Location = new System.Drawing.Point(16, 12);
            this.Letters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Letters.Name = "Letters";
            this.Letters.Size = new System.Drawing.Size(70, 22);
            this.Letters.TabIndex = 0;
            this.Letters.Text = "Letters:";
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Word.Location = new System.Drawing.Point(16, 303);
            this.Word.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(59, 22);
            this.Word.TabIndex = 1;
            this.Word.Text = "Word:";
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.Location = new System.Drawing.Point(188, 736);
            this.Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(100, 31);
            this.Check.TabIndex = 2;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(119, 801);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(232, 23);
            this.Score.TabIndex = 3;
            this.Score.Text = "Score:Words( ).Letters( )!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 856);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Letters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "How many words can you spell？";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Letters;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label Score;
    }
}

