
namespace Assignment2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblErrorMessages = new System.Windows.Forms.Label();
            this.timerStartStop = new System.Windows.Forms.Timer(this.components);
            this.btnSaveWords = new System.Windows.Forms.Button();
            this.rtbSaveWords = new System.Windows.Forms.RichTextBox();
            this.gbxGameSettings = new System.Windows.Forms.GroupBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblTimesUp = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRandomWord = new System.Windows.Forms.TextBox();
            this.gbxGameOver = new System.Windows.Forms.GroupBox();
            this.lblRandomWord = new System.Windows.Forms.Label();
            this.gbxGameStarted = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPuzzleGame = new System.Windows.Forms.Label();
            this.gbxGameMenu = new System.Windows.Forms.GroupBox();
            this.gbxScoreTime = new System.Windows.Forms.GroupBox();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblScorePoints = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.gbxGameSettings.SuspendLayout();
            this.gbxGameOver.SuspendLayout();
            this.gbxGameStarted.SuspendLayout();
            this.gbxGameMenu.SuspendLayout();
            this.gbxScoreTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorMessages
            // 
            this.lblErrorMessages.AutoSize = true;
            this.lblErrorMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessages.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessages.Location = new System.Drawing.Point(149, 377);
            this.lblErrorMessages.Name = "lblErrorMessages";
            this.lblErrorMessages.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMessages.TabIndex = 14;
            // 
            // timerStartStop
            // 
            this.timerStartStop.Interval = 1000;
            this.timerStartStop.Tick += new System.EventHandler(this.timerStartStop_Tick);
            // 
            // btnSaveWords
            // 
            this.btnSaveWords.Location = new System.Drawing.Point(6, 236);
            this.btnSaveWords.Name = "btnSaveWords";
            this.btnSaveWords.Size = new System.Drawing.Size(171, 23);
            this.btnSaveWords.TabIndex = 1;
            this.btnSaveWords.Text = "Save Button Words";
            this.btnSaveWords.UseVisualStyleBackColor = true;
            this.btnSaveWords.Click += new System.EventHandler(this.btnSaveWords_Click);
            // 
            // rtbSaveWords
            // 
            this.rtbSaveWords.Location = new System.Drawing.Point(6, 19);
            this.rtbSaveWords.Name = "rtbSaveWords";
            this.rtbSaveWords.Size = new System.Drawing.Size(246, 211);
            this.rtbSaveWords.TabIndex = 0;
            this.rtbSaveWords.Text = "";
            // 
            // gbxGameSettings
            // 
            this.gbxGameSettings.Controls.Add(this.btnSaveWords);
            this.gbxGameSettings.Controls.Add(this.rtbSaveWords);
            this.gbxGameSettings.Location = new System.Drawing.Point(298, 89);
            this.gbxGameSettings.Name = "gbxGameSettings";
            this.gbxGameSettings.Size = new System.Drawing.Size(258, 285);
            this.gbxGameSettings.TabIndex = 10;
            this.gbxGameSettings.TabStop = false;
            this.gbxGameSettings.Text = "Game Settings";
            this.gbxGameSettings.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(19, 205);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(216, 23);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(19, 159);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(216, 23);
            this.btnReturnToMenu.TabIndex = 2;
            this.btnReturnToMenu.Text = "Return to Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.Location = new System.Drawing.Point(65, 101);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(123, 20);
            this.lblYourScore.TabIndex = 1;
            this.lblYourScore.Text = "Your Score was: 0";
            // 
            // lblTimesUp
            // 
            this.lblTimesUp.AutoSize = true;
            this.lblTimesUp.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesUp.Location = new System.Drawing.Point(94, 53);
            this.lblTimesUp.Name = "lblTimesUp";
            this.lblTimesUp.Size = new System.Drawing.Size(72, 20);
            this.lblTimesUp.TabIndex = 0;
            this.lblTimesUp.Text = "Times Up!";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(89, 166);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRandomWord
            // 
            this.txtRandomWord.Location = new System.Drawing.Point(35, 109);
            this.txtRandomWord.Name = "txtRandomWord";
            this.txtRandomWord.Size = new System.Drawing.Size(179, 20);
            this.txtRandomWord.TabIndex = 1;
            // 
            // gbxGameOver
            // 
            this.gbxGameOver.Controls.Add(this.btnPlayAgain);
            this.gbxGameOver.Controls.Add(this.btnReturnToMenu);
            this.gbxGameOver.Controls.Add(this.lblYourScore);
            this.gbxGameOver.Controls.Add(this.lblTimesUp);
            this.gbxGameOver.Location = new System.Drawing.Point(575, 6);
            this.gbxGameOver.Name = "gbxGameOver";
            this.gbxGameOver.Size = new System.Drawing.Size(265, 256);
            this.gbxGameOver.TabIndex = 12;
            this.gbxGameOver.TabStop = false;
            this.gbxGameOver.Text = "Game Over!";
            this.gbxGameOver.Visible = false;
            // 
            // lblRandomWord
            // 
            this.lblRandomWord.AutoSize = true;
            this.lblRandomWord.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomWord.Location = new System.Drawing.Point(64, 48);
            this.lblRandomWord.Name = "lblRandomWord";
            this.lblRandomWord.Size = new System.Drawing.Size(100, 20);
            this.lblRandomWord.TabIndex = 0;
            this.lblRandomWord.Text = "Random Word";
            // 
            // gbxGameStarted
            // 
            this.gbxGameStarted.Controls.Add(this.btnSubmit);
            this.gbxGameStarted.Controls.Add(this.txtRandomWord);
            this.gbxGameStarted.Controls.Add(this.lblRandomWord);
            this.gbxGameStarted.Location = new System.Drawing.Point(575, 270);
            this.gbxGameStarted.Name = "gbxGameStarted";
            this.gbxGameStarted.Size = new System.Drawing.Size(251, 211);
            this.gbxGameStarted.TabIndex = 11;
            this.gbxGameStarted.TabStop = false;
            this.gbxGameStarted.Text = "Game Started!";
            this.gbxGameStarted.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHelp.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(65, 195);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(123, 48);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSettings.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(65, 134);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(123, 47);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(65, 77);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 47);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblPuzzleGame
            // 
            this.lblPuzzleGame.AutoSize = true;
            this.lblPuzzleGame.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuzzleGame.Location = new System.Drawing.Point(83, 33);
            this.lblPuzzleGame.Name = "lblPuzzleGame";
            this.lblPuzzleGame.Size = new System.Drawing.Size(89, 20);
            this.lblPuzzleGame.TabIndex = 0;
            this.lblPuzzleGame.Text = "Puzzle Game";
            // 
            // gbxGameMenu
            // 
            this.gbxGameMenu.Controls.Add(this.btnHelp);
            this.gbxGameMenu.Controls.Add(this.btnSettings);
            this.gbxGameMenu.Controls.Add(this.btnPlay);
            this.gbxGameMenu.Controls.Add(this.lblPuzzleGame);
            this.gbxGameMenu.Location = new System.Drawing.Point(24, 89);
            this.gbxGameMenu.Name = "gbxGameMenu";
            this.gbxGameMenu.Size = new System.Drawing.Size(258, 285);
            this.gbxGameMenu.TabIndex = 9;
            this.gbxGameMenu.TabStop = false;
            this.gbxGameMenu.Text = "Game Menu";
            // 
            // gbxScoreTime
            // 
            this.gbxScoreTime.Controls.Add(this.lblTimeLeft);
            this.gbxScoreTime.Controls.Add(this.lblScorePoints);
            this.gbxScoreTime.Location = new System.Drawing.Point(275, 6);
            this.gbxScoreTime.Name = "gbxScoreTime";
            this.gbxScoreTime.Size = new System.Drawing.Size(200, 68);
            this.gbxScoreTime.TabIndex = 8;
            this.gbxScoreTime.TabStop = false;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(8, 16);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(150, 20);
            this.lblTimeLeft.TabIndex = 0;
            this.lblTimeLeft.Text = "Time Left: 60 seconds";
            // 
            // lblScorePoints
            // 
            this.lblScorePoints.AutoSize = true;
            this.lblScorePoints.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePoints.Location = new System.Drawing.Point(37, 36);
            this.lblScorePoints.Name = "lblScorePoints";
            this.lblScorePoints.Size = new System.Drawing.Size(106, 20);
            this.lblScorePoints.TabIndex = 1;
            this.lblScorePoints.Text = "Score: 0 Points";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(269, 353);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMessage.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 493);
            this.Controls.Add(this.lblErrorMessages);
            this.Controls.Add(this.gbxGameSettings);
            this.Controls.Add(this.gbxGameOver);
            this.Controls.Add(this.gbxGameStarted);
            this.Controls.Add(this.gbxGameMenu);
            this.Controls.Add(this.gbxScoreTime);
            this.Controls.Add(this.lblErrorMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxGameSettings.ResumeLayout(false);
            this.gbxGameOver.ResumeLayout(false);
            this.gbxGameOver.PerformLayout();
            this.gbxGameStarted.ResumeLayout(false);
            this.gbxGameStarted.PerformLayout();
            this.gbxGameMenu.ResumeLayout(false);
            this.gbxGameMenu.PerformLayout();
            this.gbxScoreTime.ResumeLayout(false);
            this.gbxScoreTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMessages;
        private System.Windows.Forms.Timer timerStartStop;
        private System.Windows.Forms.Button btnSaveWords;
        private System.Windows.Forms.RichTextBox rtbSaveWords;
        private System.Windows.Forms.GroupBox gbxGameSettings;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblTimesUp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRandomWord;
        private System.Windows.Forms.GroupBox gbxGameOver;
        private System.Windows.Forms.Label lblRandomWord;
        private System.Windows.Forms.GroupBox gbxGameStarted;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblPuzzleGame;
        private System.Windows.Forms.GroupBox gbxGameMenu;
        private System.Windows.Forms.GroupBox gbxScoreTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblScorePoints;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

