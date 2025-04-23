namespace Project_Tennis_2._0
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
            labelTennisScore = new Label();
            labelRanking = new Label();
            listViewRanking = new ListView();
            playerNameCollumn = new ColumnHeader();
            scoreCollumn = new ColumnHeader();
            labelClickonPlayerName = new Label();
            labelLatestGame = new Label();
            listViewLatestGame = new ListView();
            FirstPlayerCollumn = new ColumnHeader();
            secondPlayerCollumn = new ColumnHeader();
            winnerCollumn = new ColumnHeader();
            TotalScoreCollumn = new ColumnHeader();
            buttonAddNewGame = new Button();
            SuspendLayout();
            // 
            // labelTennisScore
            // 
            labelTennisScore.AutoSize = true;
            labelTennisScore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTennisScore.Location = new Point(273, 20);
            labelTennisScore.Name = "labelTennisScore";
            labelTennisScore.Size = new Size(229, 48);
            labelTennisScore.TabIndex = 0;
            labelTennisScore.Text = "Tennis Score";
            // 
            // labelRanking
            // 
            labelRanking.AutoSize = true;
            labelRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRanking.Location = new Point(76, 79);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(82, 25);
            labelRanking.TabIndex = 1;
            labelRanking.Text = "Ranking";
            // 
            // listViewRanking
            // 
            listViewRanking.BackColor = Color.Tomato;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { playerNameCollumn, scoreCollumn });
            listViewRanking.Location = new Point(76, 107);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(683, 146);
            listViewRanking.TabIndex = 2;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            // 
            // playerNameCollumn
            // 
            playerNameCollumn.Text = "Player name";
            playerNameCollumn.Width = 350;
            // 
            // scoreCollumn
            // 
            scoreCollumn.Text = "Score";
            scoreCollumn.Width = 300;
            // 
            // labelClickonPlayerName
            // 
            labelClickonPlayerName.AutoSize = true;
            labelClickonPlayerName.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            labelClickonPlayerName.Location = new Point(76, 256);
            labelClickonPlayerName.Name = "labelClickonPlayerName";
            labelClickonPlayerName.Size = new Size(474, 19);
            labelClickonPlayerName.TabIndex = 3;
            labelClickonPlayerName.Text = "*click on player's name to see more information about their matches  ";
            // 
            // labelLatestGame
            // 
            labelLatestGame.AutoSize = true;
            labelLatestGame.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLatestGame.Location = new Point(76, 311);
            labelLatestGame.Name = "labelLatestGame";
            labelLatestGame.Size = new Size(115, 25);
            labelLatestGame.TabIndex = 4;
            labelLatestGame.Text = "Latest game";
            // 
            // listViewLatestGame
            // 
            listViewLatestGame.BackColor = Color.Tomato;
            listViewLatestGame.Columns.AddRange(new ColumnHeader[] { FirstPlayerCollumn, secondPlayerCollumn, winnerCollumn, TotalScoreCollumn });
            listViewLatestGame.Location = new Point(76, 354);
            listViewLatestGame.Name = "listViewLatestGame";
            listViewLatestGame.Size = new Size(683, 163);
            listViewLatestGame.TabIndex = 5;
            listViewLatestGame.UseCompatibleStateImageBehavior = false;
            listViewLatestGame.View = View.Details;
            // 
            // FirstPlayerCollumn
            // 
            FirstPlayerCollumn.Text = "First player";
            FirstPlayerCollumn.Width = 200;
            // 
            // secondPlayerCollumn
            // 
            secondPlayerCollumn.Text = "Second player";
            secondPlayerCollumn.Width = 200;
            // 
            // winnerCollumn
            // 
            winnerCollumn.Text = "Winner";
            winnerCollumn.Width = 150;
            // 
            // TotalScoreCollumn
            // 
            TotalScoreCollumn.Text = "Score";
            TotalScoreCollumn.Width = 120;
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.BackColor = Color.FromArgb(64, 0, 64);
            buttonAddNewGame.ForeColor = SystemColors.ControlLightLight;
            buttonAddNewGame.Location = new Point(517, 278);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(226, 58);
            buttonAddNewGame.TabIndex = 6;
            buttonAddNewGame.Text = "Add New Game";
            buttonAddNewGame.UseVisualStyleBackColor = false;
            buttonAddNewGame.Click += buttonAddNewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(822, 551);
            Controls.Add(buttonAddNewGame);
            Controls.Add(listViewLatestGame);
            Controls.Add(labelLatestGame);
            Controls.Add(labelClickonPlayerName);
            Controls.Add(listViewRanking);
            Controls.Add(labelRanking);
            Controls.Add(labelTennisScore);
            Name = "Form1";
            Text = "Form1";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTennisScore;
        private Label labelRanking;
        private ListView listViewRanking;
        private ColumnHeader playerNameCollumn;
        private ColumnHeader scoreCollumn;
        private Label labelClickonPlayerName;
        private Label labelLatestGame;
        private ListView listViewLatestGame;
        private ColumnHeader FirstPlayerCollumn;
        private ColumnHeader secondPlayerCollumn;
        private ColumnHeader winnerCollumn;
        private ColumnHeader TotalScoreCollumn;
        private Button buttonAddNewGame;
    }
}
