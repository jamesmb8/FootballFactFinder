namespace Thefinalproj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBTable = new System.Windows.Forms.ListBox();
            this.BTNTable = new System.Windows.Forms.Button();
            this.BTNTeam = new System.Windows.Forms.Button();
            this.BTNFixtures = new System.Windows.Forms.Button();
            this.BTNQuiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LBTable
            // 
            this.LBTable.FormattingEnabled = true;
            this.LBTable.ItemHeight = 15;
            this.LBTable.Location = new System.Drawing.Point(45, 101);
            this.LBTable.Name = "LBTable";
            this.LBTable.Size = new System.Drawing.Size(318, 319);
            this.LBTable.TabIndex = 0;
            // 
            // BTNTable
            // 
            this.BTNTable.Location = new System.Drawing.Point(45, 58);
            this.BTNTable.Name = "BTNTable";
            this.BTNTable.Size = new System.Drawing.Size(75, 23);
            this.BTNTable.TabIndex = 1;
            this.BTNTable.Text = "Table";
            this.BTNTable.UseVisualStyleBackColor = true;
            // 
            // BTNTeam
            // 
            this.BTNTeam.Location = new System.Drawing.Point(126, 58);
            this.BTNTeam.Name = "BTNTeam";
            this.BTNTeam.Size = new System.Drawing.Size(75, 23);
            this.BTNTeam.TabIndex = 2;
            this.BTNTeam.UseVisualStyleBackColor = true;
            // 
            // BTNFixtures
            // 
            this.BTNFixtures.Location = new System.Drawing.Point(207, 58);
            this.BTNFixtures.Name = "BTNFixtures";
            this.BTNFixtures.Size = new System.Drawing.Size(75, 23);
            this.BTNFixtures.TabIndex = 3;
            this.BTNFixtures.UseVisualStyleBackColor = true;
            // 
            // BTNQuiz
            // 
            this.BTNQuiz.Location = new System.Drawing.Point(686, 27);
            this.BTNQuiz.Name = "BTNQuiz";
            this.BTNQuiz.Size = new System.Drawing.Size(75, 23);
            this.BTNQuiz.TabIndex = 4;
            this.BTNQuiz.Text = "Quiz";
            this.BTNQuiz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(126, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(552, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNQuiz);
            this.Controls.Add(this.BTNFixtures);
            this.Controls.Add(this.BTNTeam);
            this.Controls.Add(this.BTNTable);
            this.Controls.Add(this.LBTable);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LBTable;
        private Button BTNTable;
        private Button BTNTeam;
        private Button BTNFixtures;
        private Button BTNQuiz;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Panel panel1;
        private Label LBLFirstName;
        private Button BTNSearch;
        private Label LBLLastName;
        private TextBox TBFirstName;
        private TextBox TBLastName;
        private ListBox LBTable2;
        private Label LBLGamesPlayed;
        private Label LBLGoals;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox TBFullName;
        private Label LBLAssists;
        private Label LBLYellowCards;
        private Label LBLRedCards;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button BTNQuiz2;
    }
}