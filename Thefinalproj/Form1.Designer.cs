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
            this.SuspendLayout();
            // 
            // LBTable
            // 
            this.LBTable.FormattingEnabled = true;
            this.LBTable.ItemHeight = 15;
            this.LBTable.Location = new System.Drawing.Point(45, 87);
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
            this.BTNTeam.Text = "Team";
            this.BTNTeam.UseVisualStyleBackColor = true;
            // 
            // BTNFixtures
            // 
            this.BTNFixtures.Location = new System.Drawing.Point(207, 58);
            this.BTNFixtures.Name = "BTNFixtures";
            this.BTNFixtures.Size = new System.Drawing.Size(75, 23);
            this.BTNFixtures.TabIndex = 3;
            this.BTNFixtures.Text = "Fixtures";
            this.BTNFixtures.UseVisualStyleBackColor = true;
            // 
            // BTNQuiz
            // 
            this.BTNQuiz.Location = new System.Drawing.Point(288, 58);
            this.BTNQuiz.Name = "BTNQuiz";
            this.BTNQuiz.Size = new System.Drawing.Size(75, 23);
            this.BTNQuiz.TabIndex = 4;
            this.BTNQuiz.Text = "Quiz";
            this.BTNQuiz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNQuiz);
            this.Controls.Add(this.BTNFixtures);
            this.Controls.Add(this.BTNTeam);
            this.Controls.Add(this.BTNTable);
            this.Controls.Add(this.LBTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LBTable;
        private Button BTNTable;
        private Button BTNTeam;
        private Button BTNFixtures;
        private Button BTNQuiz;
    }
}