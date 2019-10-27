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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLists = new System.Windows.Forms.Panel();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lSelectList = new System.Windows.Forms.Label();
            this.cbListsRW = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAnswerWord = new System.Windows.Forms.TextBox();
            this.lAnswer = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.btnPreviousWord = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.pbProgressRW = new System.Windows.Forms.ProgressBar();
            this.gbProgressRW = new System.Windows.Forms.GroupBox();
            this.lQuestionWord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLists.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbProgressRW.SuspendLayout();
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
            this.gbOptions.Controls.Add(this.radioButton3);
            this.gbOptions.Controls.Add(this.radioButton1);
            this.gbOptions.Controls.Add(this.radioButton2);
            this.gbOptions.Location = new System.Drawing.Point(10, 57);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(116, 89);
            this.gbOptions.TabIndex = 11;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            this.cbListsRW.SelectionChangeCommitted += new System.EventHandler(this.cbListsRW_SelectionChangeCommitted);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(142, 85);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(146, 44);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.lResult.BackColor = System.Drawing.Color.Transparent;
            this.lResult.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.ForeColor = System.Drawing.Color.Lime;
            this.lResult.Location = new System.Drawing.Point(10, 339);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(340, 53);
            this.lResult.TabIndex = 17;
            this.lResult.Text = "TRUE!";
            this.lResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProgressRW
            // 
            this.pbProgressRW.Location = new System.Drawing.Point(7, 19);
            this.pbProgressRW.Name = "pbProgressRW";
            this.pbProgressRW.Size = new System.Drawing.Size(325, 23);
            this.pbProgressRW.TabIndex = 18;
            this.pbProgressRW.Value = 25;
            // 
            // gbProgressRW
            // 
            this.gbProgressRW.BackColor = System.Drawing.Color.Transparent;
            this.gbProgressRW.Controls.Add(this.pbProgressRW);
            this.gbProgressRW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProgressRW.ForeColor = System.Drawing.Color.Yellow;
            this.gbProgressRW.Location = new System.Drawing.Point(10, 395);
            this.gbProgressRW.Name = "gbProgressRW";
            this.gbProgressRW.Size = new System.Drawing.Size(338, 55);
            this.gbProgressRW.TabIndex = 19;
            this.gbProgressRW.TabStop = false;
            this.gbProgressRW.Text = "PROGRESS";
            // 
            // lQuestionWord
            // 
            this.lQuestionWord.BackColor = System.Drawing.Color.Transparent;
            this.lQuestionWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lQuestionWord.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuestionWord.ForeColor = System.Drawing.Color.Lime;
            this.lQuestionWord.Location = new System.Drawing.Point(10, 168);
            this.lQuestionWord.Name = "lQuestionWord";
            this.lQuestionWord.Size = new System.Drawing.Size(340, 51);
            this.lQuestionWord.TabIndex = 20;
            this.lQuestionWord.Text = "sample word";
            this.lQuestionWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ReadWrite
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(362, 615);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lQuestionWord);
            this.Controls.Add(this.gbProgressRW);
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
            this.gbProgressRW.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLists;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lSelectList;
        private System.Windows.Forms.ComboBox cbListsRW;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAnswerWord;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.Button btnPreviousWord;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.ProgressBar pbProgressRW;
        private System.Windows.Forms.GroupBox gbProgressRW;
        private System.Windows.Forms.Label lQuestionWord;
        private System.Windows.Forms.Button btnClose;
    }
}