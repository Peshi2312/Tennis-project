namespace Project_Tennis_2._0
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPlayerName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraws = new Label();
            listViewVictories = new ListView();
            CompetitorVictories = new ColumnHeader();
            ScoreVictories = new ColumnHeader();
            listViewLosses = new ListView();
            CompetitorLosses = new ColumnHeader();
            ScoreLosses = new ColumnHeader();
            listViewDraw = new ListView();
            CompetitorDraw = new ColumnHeader();
            ScoreDraw = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 25F);
            labelPlayerName.ForeColor = SystemColors.ButtonHighlight;
            labelPlayerName.Location = new Point(267, 19);
            labelPlayerName.Name = "label1";
            labelPlayerName.Size = new Size(235, 67);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "R.Federer";
            // 
            // label2
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI", 15F);
            labelVictories.ForeColor = SystemColors.ButtonHighlight;
            labelVictories.Location = new Point(671, 125);
            labelVictories.Name = "label2";
            labelVictories.Size = new Size(86, 41);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Draw";
            // 
            // label3
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI", 15F);
            labelLosses.ForeColor = SystemColors.ButtonHighlight;
            labelLosses.Location = new Point(397, 125);
            labelLosses.Name = "label3";
            labelLosses.Size = new Size(105, 41);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // label4
            // 
            labelDraws.AutoSize = true;
            labelDraws.Font = new Font("Segoe UI", 15F);
            labelDraws.ForeColor = SystemColors.ButtonHighlight;
            labelDraws.Location = new Point(49, 125);
            labelDraws.Name = "label4";
            labelDraws.Size = new Size(132, 41);
            labelDraws.TabIndex = 3;
            labelDraws.Text = "Victories";
            // 
            // listView1
            // 
            listViewVictories.BackColor = Color.Salmon;
            listViewVictories.Columns.AddRange(new ColumnHeader[] { CompetitorVictories, ScoreVictories });
            listViewVictories.Location = new Point(12, 187);
            listViewVictories.Name = "listView1";
            listViewVictories.Size = new Size(248, 178);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // Competitor
            // 
            CompetitorVictories.Text = "Competitor";
            CompetitorVictories.Width = 150;
            // 
            // Score
            // 
            ScoreVictories.Text = "Score";
            ScoreVictories.Width = 90;
            // 
            // listView2
            // 
            listViewLosses.BackColor = Color.Salmon;
            listViewLosses.Columns.AddRange(new ColumnHeader[] { CompetitorLosses, ScoreLosses });
            listViewLosses.Location = new Point(290, 187);
            listViewLosses.Name = "listView2";
            listViewLosses.Size = new Size(248, 178);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // columnHeader1
            // 
            CompetitorLosses.Text = "Competitor";
            CompetitorLosses.Width = 150;
            // 
            // columnHeader2
            // 
            ScoreLosses.Text = "Score";
            ScoreLosses.Width = 90;
            // 
            // listView3
            // 
            listViewDraw.BackColor = Color.Salmon;
            listViewDraw.Columns.AddRange(new ColumnHeader[] { CompetitorDraw, ScoreDraw });
            listViewDraw.Location = new Point(582, 187);
            listViewDraw.Name = "listView3";
            listViewDraw.Size = new Size(248, 178);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // columnHeader3
            // 
            CompetitorDraw.Text = "Competitor";
            CompetitorDraw.Width = 150;
            // 
            // columnHeader4
            // 
            ScoreDraw.Text = "Score";
            ScoreDraw.Width = 90;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(842, 508);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraws);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraws;
        private ListView listViewVictories;
        private ColumnHeader CompetitorVictories;
        private ColumnHeader ScoreVictories;
        private ListView listViewLosses;
        private ColumnHeader CompetitorLosses;
        private ColumnHeader ScoreLosses;
        private ListView listViewDraw;
        private ColumnHeader CompetitorDraw;
        private ColumnHeader ScoreDraw;
    }
}