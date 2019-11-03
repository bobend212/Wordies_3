namespace Wordies_3.Forms
{
    partial class ReadWrite
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLists = new System.Windows.Forms.Panel();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chbAlfOrder = new System.Windows.Forms.RadioButton();
            this.chbPrevDisable = new System.Windows.Forms.CheckBox();
            this.chbRandom = new System.Windows.Forms.RadioButton();
            this.chbOrderInsertion = new System.Windows.Forms.RadioButton();
            this.lSelectList = new System.Windows.Forms.Label();
            this.cbListsRW = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtAnswerWord = new System.Windows.Forms.TextBox();
            this.lAnswer = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.btnPreviousWord = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.lScoring = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.lQuestionWord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.panelLists.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(327, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelLists
            // 
            this.panelLists.BackColor = System.Drawing.Color.Khaki;
            this.panelLists.Controls.Add(this.gbOptions);
            this.panelLists.Controls.Add(this.lSelectList);
            this.panelLists.Controls.Add(this.cbListsRW);
            this.panelLists.Controls.Add(this.btnPlay);
            this.panelLists.Location = new System.Drawing.Point(10, 12);
            this.panelLists.Name = "panelLists";
            this.panelLists.Size = new System.Drawing.Size(311, 153);
            this.panelLists.TabIndex = 10;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chbAlfOrder);
            this.gbOptions.Controls.Add(this.chbPrevDisable);
            this.gbOptions.Controls.Add(this.chbRandom);
            this.gbOptions.Controls.Add(this.chbOrderInsertion);
            this.gbOptions.Location = new System.Drawing.Point(10, 57);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(199, 89);
            this.gbOptions.TabIndex = 11;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chbAlfOrder
            // 
            this.chbAlfOrder.AutoSize = true;
            this.chbAlfOrder.Location = new System.Drawing.Point(6, 60);
            this.chbAlfOrder.Name = "chbAlfOrder";
            this.chbAlfOrder.Size = new System.Drawing.Size(78, 17);
            this.chbAlfOrder.TabIndex = 25;
            this.chbAlfOrder.Text = "Alph. Order";
            this.chbAlfOrder.UseVisualStyleBackColor = true;
            // 
            // chbPrevDisable
            // 
            this.chbPrevDisable.AutoSize = true;
            this.chbPrevDisable.Location = new System.Drawing.Point(106, 14);
            this.chbPrevDisable.Name = "chbPrevDisable";
            this.chbPrevDisable.Size = new System.Drawing.Size(80, 17);
            this.chbPrevDisable.TabIndex = 1;
            this.chbPrevDisable.Text = "Prev. Word";
            this.chbPrevDisable.UseVisualStyleBackColor = true;
            this.chbPrevDisable.CheckedChanged += new System.EventHandler(this.chbPrevDisable_CheckedChanged);
            // 
            // chbRandom
            // 
            this.chbRandom.AutoSize = true;
            this.chbRandom.Location = new System.Drawing.Point(6, 37);
            this.chbRandom.Name = "chbRandom";
            this.chbRandom.Size = new System.Drawing.Size(94, 17);
            this.chbRandom.TabIndex = 24;
            this.chbRandom.Text = "Random Order";
            this.chbRandom.UseVisualStyleBackColor = true;
            // 
            // chbOrderInsertion
            // 
            this.chbOrderInsertion.AutoSize = true;
            this.chbOrderInsertion.Checked = true;
            this.chbOrderInsertion.Location = new System.Drawing.Point(6, 14);
            this.chbOrderInsertion.Name = "chbOrderInsertion";
            this.chbOrderInsertion.Size = new System.Drawing.Size(94, 17);
            this.chbOrderInsertion.TabIndex = 23;
            this.chbOrderInsertion.TabStop = true;
            this.chbOrderInsertion.Text = "Insertion Order";
            this.chbOrderInsertion.UseVisualStyleBackColor = true;
            // 
            // lSelectList
            // 
            this.lSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSelectList.Location = new System.Drawing.Point(6, 8);
            this.lSelectList.Name = "lSelectList";
            this.lSelectList.Size = new System.Drawing.Size(301, 19);
            this.lSelectList.TabIndex = 1;
            this.lSelectList.Text = "Select List";
            this.lSelectList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbListsRW
            // 
            this.cbListsRW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListsRW.FormattingEnabled = true;
            this.cbListsRW.Location = new System.Drawing.Point(6, 30);
            this.cbListsRW.Name = "cbListsRW";
            this.cbListsRW.Size = new System.Drawing.Size(301, 21);
            this.cbListsRW.TabIndex = 2;
            this.cbListsRW.SelectedValueChanged += new System.EventHandler(this.cbListsRW_SelectedValueChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlay.Location = new System.Drawing.Point(215, 76);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(92, 52);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtAnswerWord
            // 
            this.txtAnswerWord.Location = new System.Drawing.Point(12, 245);
            this.txtAnswerWord.Multiline = true;
            this.txtAnswerWord.Name = "txtAnswerWord";
            this.txtAnswerWord.Size = new System.Drawing.Size(338, 41);
            this.txtAnswerWord.TabIndex = 13;
            // 
            // lAnswer
            // 
            this.lAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAnswer.ForeColor = System.Drawing.Color.White;
            this.lAnswer.Location = new System.Drawing.Point(10, 219);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(340, 23);
            this.lAnswer.TabIndex = 14;
            this.lAnswer.Text = "Answer below";
            this.lAnswer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(106, 292);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(146, 44);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNextWord
            // 
            this.btnNextWord.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextWord.Location = new System.Drawing.Point(275, 292);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(75, 44);
            this.btnNextWord.TabIndex = 15;
            this.btnNextWord.Text = "->";
            this.btnNextWord.UseVisualStyleBackColor = true;
            this.btnNextWord.Click += new System.EventHandler(this.btnNextWord_Click);
            // 
            // btnPreviousWord
            // 
            this.btnPreviousWord.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreviousWord.Location = new System.Drawing.Point(10, 292);
            this.btnPreviousWord.Name = "btnPreviousWord";
            this.btnPreviousWord.Size = new System.Drawing.Size(75, 44);
            this.btnPreviousWord.TabIndex = 16;
            this.btnPreviousWord.Text = "<-";
            this.btnPreviousWord.UseVisualStyleBackColor = true;
            this.btnPreviousWord.Click += new System.EventHandler(this.btnPreviousWord_Click);
            // 
            // lResult
            // 
            this.lResult.BackColor = System.Drawing.Color.Black;
            this.lResult.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.ForeColor = System.Drawing.Color.Lime;
            this.lResult.Location = new System.Drawing.Point(11, 366);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(340, 53);
            this.lResult.TabIndex = 17;
            this.lResult.Text = "TRUE!";
            this.lResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbScore
            // 
            this.gbScore.BackColor = System.Drawing.Color.Transparent;
            this.gbScore.Controls.Add(this.lScoring);
            this.gbScore.Controls.Add(this.lScore);
            this.gbScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbScore.ForeColor = System.Drawing.Color.Yellow;
            this.gbScore.Location = new System.Drawing.Point(17, 422);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(330, 74);
            this.gbScore.TabIndex = 19;
            this.gbScore.TabStop = false;
            this.gbScore.Text = "SCORE";
            // 
            // lScoring
            // 
            this.lScoring.Location = new System.Drawing.Point(224, 16);
            this.lScoring.Name = "lScoring";
            this.lScoring.Size = new System.Drawing.Size(100, 46);
            this.lScoring.TabIndex = 1;
            this.lScoring.Text = "TRUE   +3\r\nFALSE  -1\r\nHINT   -2";
            this.lScoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScore
            // 
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lScore.ForeColor = System.Drawing.Color.White;
            this.lScore.Location = new System.Drawing.Point(7, 16);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(201, 46);
            this.lScore.TabIndex = 0;
            this.lScore.Tag = "";
            this.lScore.Text = "18";
            this.lScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lQuestionWord
            // 
            this.lQuestionWord.BackColor = System.Drawing.Color.Transparent;
            this.lQuestionWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lQuestionWord.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuestionWord.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lQuestionWord.Location = new System.Drawing.Point(10, 168);
            this.lQuestionWord.Name = "lQuestionWord";
            this.lQuestionWord.Size = new System.Drawing.Size(340, 51);
            this.lQuestionWord.TabIndex = 20;
            this.lQuestionWord.Text = "sample word";
            this.lQuestionWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lQuestionWord.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(282, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(140, 340);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(75, 23);
            this.btnHint.TabIndex = 22;
            this.btnHint.Text = "HINT";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Visible = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // ReadWrite
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(362, 615);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lQuestionWord);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.btnPreviousWord);
            this.Controls.Add(this.btnNextWord);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.txtAnswerWord);
            this.Controls.Add(this.panelLists);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReadWrite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadWrite";
            this.Load += new System.EventHandler(this.ReadWrite_Load);
            this.panelLists.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLists;
        private System.Windows.Forms.Label lSelectList;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TextBox txtAnswerWord;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.Button btnPreviousWord;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.Label lQuestionWord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chbPrevDisable;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lScoring;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.RadioButton chbOrderInsertion;
        private System.Windows.Forms.RadioButton chbRandom;
        private System.Windows.Forms.RadioButton chbAlfOrder;
        private System.Windows.Forms.ComboBox cbListsRW;
    }
}