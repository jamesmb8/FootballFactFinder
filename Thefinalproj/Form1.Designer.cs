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
            this.LBLFirstName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.LBLastName = new System.Windows.Forms.Label();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.LBGamesPlayed = new System.Windows.Forms.Label();
            this.TBFullName = new System.Windows.Forms.TextBox();
            this.TBGamesPlayed = new System.Windows.Forms.TextBox();
            this.TBGoals = new System.Windows.Forms.TextBox();
            this.TBAssists = new System.Windows.Forms.TextBox();
            this.TBYellowCards = new System.Windows.Forms.TextBox();
            this.TBRedCards = new System.Windows.Forms.TextBox();
            this.LBGoals = new System.Windows.Forms.Label();
            this.LBAssists = new System.Windows.Forms.Label();
            this.LBYellowCard = new System.Windows.Forms.Label();
            this.LBRedCards = new System.Windows.Forms.Label();
            this.BTNClear = new System.Windows.Forms.Button();
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
            // LBLFirstName
            // 
            this.LBLFirstName.AutoSize = true;
            this.LBLFirstName.Location = new System.Drawing.Point(45, 31);
            this.LBLFirstName.Name = "LBLFirstName";
            this.LBLFirstName.Size = new System.Drawing.Size(62, 15);
            this.LBLFirstName.TabIndex = 5;
            this.LBLFirstName.Text = "First name";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(126, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 6;
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(112, 26);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(100, 23);
            this.TBFirstName.TabIndex = 7;
            // 
            // LBLastName
            // 
            this.LBLastName.AutoSize = true;
            this.LBLastName.Location = new System.Drawing.Point(235, 31);
            this.LBLastName.Name = "LBLastName";
            this.LBLastName.Size = new System.Drawing.Size(63, 15);
            this.LBLastName.TabIndex = 8;
            this.LBLastName.Text = "Last Name";
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(304, 24);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(100, 23);
            this.TBLastName.TabIndex = 9;
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(426, 24);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(75, 23);
            this.BTNSearch.TabIndex = 10;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // LBGamesPlayed
            // 
            this.LBGamesPlayed.AutoSize = true;
            this.LBGamesPlayed.Location = new System.Drawing.Point(502, 152);
            this.LBGamesPlayed.Name = "LBGamesPlayed";
            this.LBGamesPlayed.Size = new System.Drawing.Size(81, 15);
            this.LBGamesPlayed.TabIndex = 11;
            this.LBGamesPlayed.Text = "Games Played";
            // 
            // TBFullName
            // 
            this.TBFullName.Location = new System.Drawing.Point(493, 101);
            this.TBFullName.Name = "TBFullName";
            this.TBFullName.Size = new System.Drawing.Size(221, 23);
            this.TBFullName.TabIndex = 12;
            // 
            // TBGamesPlayed
            // 
            this.TBGamesPlayed.Location = new System.Drawing.Point(627, 152);
            this.TBGamesPlayed.Name = "TBGamesPlayed";
            this.TBGamesPlayed.Size = new System.Drawing.Size(100, 23);
            this.TBGamesPlayed.TabIndex = 13;
            // 
            // TBGoals
            // 
            this.TBGoals.Location = new System.Drawing.Point(627, 224);
            this.TBGoals.Name = "TBGoals";
            this.TBGoals.Size = new System.Drawing.Size(100, 23);
            this.TBGoals.TabIndex = 14;
            // 
            // TBAssists
            // 
            this.TBAssists.Location = new System.Drawing.Point(627, 289);
            this.TBAssists.Name = "TBAssists";
            this.TBAssists.Size = new System.Drawing.Size(100, 23);
            this.TBAssists.TabIndex = 15;
            // 
            // TBYellowCards
            // 
            this.TBYellowCards.Location = new System.Drawing.Point(627, 353);
            this.TBYellowCards.Name = "TBYellowCards";
            this.TBYellowCards.Size = new System.Drawing.Size(100, 23);
            this.TBYellowCards.TabIndex = 16;
            // 
            // TBRedCards
            // 
            this.TBRedCards.Location = new System.Drawing.Point(627, 431);
            this.TBRedCards.Name = "TBRedCards";
            this.TBRedCards.Size = new System.Drawing.Size(100, 23);
            this.TBRedCards.TabIndex = 17;
            // 
            // LBGoals
            // 
            this.LBGoals.AutoSize = true;
            this.LBGoals.Location = new System.Drawing.Point(502, 227);
            this.LBGoals.Name = "LBGoals";
            this.LBGoals.Size = new System.Drawing.Size(36, 15);
            this.LBGoals.TabIndex = 18;
            this.LBGoals.Text = "Goals";
            // 
            // LBAssists
            // 
            this.LBAssists.AutoSize = true;
            this.LBAssists.Location = new System.Drawing.Point(502, 297);
            this.LBAssists.Name = "LBAssists";
            this.LBAssists.Size = new System.Drawing.Size(42, 15);
            this.LBAssists.TabIndex = 19;
            this.LBAssists.Text = "Assists";
            // 
            // LBYellowCard
            // 
            this.LBYellowCard.AutoSize = true;
            this.LBYellowCard.Location = new System.Drawing.Point(502, 361);
            this.LBYellowCard.Name = "LBYellowCard";
            this.LBYellowCard.Size = new System.Drawing.Size(74, 15);
            this.LBYellowCard.TabIndex = 20;
            this.LBYellowCard.Text = "Yellow Cards";
            // 
            // LBRedCards
            // 
            this.LBRedCards.AutoSize = true;
            this.LBRedCards.Location = new System.Drawing.Point(502, 434);
            this.LBRedCards.Name = "LBRedCards";
            this.LBRedCards.Size = new System.Drawing.Size(60, 15);
            this.LBRedCards.TabIndex = 21;
            this.LBRedCards.Text = "Red Cards";
            // 
            // BTNClear
            // 
            this.BTNClear.Location = new System.Drawing.Point(537, 25);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(75, 23);
            this.BTNClear.TabIndex = 22;
            this.BTNClear.Text = "Clear";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.BTNClear);
            this.Controls.Add(this.LBRedCards);
            this.Controls.Add(this.LBYellowCard);
            this.Controls.Add(this.LBAssists);
            this.Controls.Add(this.LBGoals);
            this.Controls.Add(this.TBRedCards);
            this.Controls.Add(this.TBYellowCards);
            this.Controls.Add(this.TBAssists);
            this.Controls.Add(this.TBGoals);
            this.Controls.Add(this.TBGamesPlayed);
            this.Controls.Add(this.TBFullName);
            this.Controls.Add(this.LBGamesPlayed);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.LBLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LBLFirstName);
            this.Controls.Add(this.LBTable);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LBTable;
        private Label LBLFirstName;
        private LinkLabel linkLabel1;
        private TextBox TBFirstName;
        private Label LBLastName;
        private TextBox TBLastName;
        private Button BTNSearch;
       
        
        private Label LBLLastName;
        
        
        private ListBox LBTable2;
        
        private TextBox textBox3;
        private TextBox textBox4;
        
       
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button BTNQuiz2;
        private Label LBGamesPlayed;
        private TextBox TBFullName;
        private TextBox TBGamesPlayed;
        private TextBox TBGoals;
        private TextBox TBAssists;
        private TextBox TBYellowCards;
        private TextBox TBRedCards;
        private Label LBGoals;
        private Label LBAssists;
        private Label LBYellowCard;
        private Label LBRedCards;
        private Button BTNClear;
    }
}