namespace Wordies_3.Forms
{
    partial class SummaryRW
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
            this.btnSaveAttemption = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lTime = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.txtPercentScore = new System.Windows.Forms.TextBox();
            this.lPercentScore = new System.Windows.Forms.Label();
            this.txtFails = new System.Windows.Forms.TextBox();
            this.lFails = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lScore = new System.Windows.Forms.Label();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.lAttempts = new System.Windows.Forms.Label();
            this.txtWordsQty = new System.Windows.Forms.TextBox();
            this.lWords = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.lListName = new System.Windows.Forms.Label();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveAttemption
            // 
            this.btnSaveAttemption.Location = new System.Drawing.Point(345, 260);
            this.btnSaveAttemption.Name = "btnSaveAttemption";
            this.btnSaveAttemption.Size = new System.Drawing.Size(119, 46);
            this.btnSaveAttemption.TabIndex = 0;
            this.btnSaveAttemption.Text = "Save Attemption";
            this.btnSaveAttemption.UseVisualStyleBackColor = true;
            this.btnSaveAttemption.Click += new System.EventHandler(this.btnSaveAttemption_Click);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.txtTime);
            this.gbSummary.Controls.Add(this.lTime);
            this.gbSummary.Controls.Add(this.txtDate);
            this.gbSummary.Controls.Add(this.lDate);
            this.gbSummary.Controls.Add(this.txtPercentScore);
            this.gbSummary.Controls.Add(this.lPercentScore);
            this.gbSummary.Controls.Add(this.txtFails);
            this.gbSummary.Controls.Add(this.lFails);
            this.gbSummary.Controls.Add(this.txtScore);
            this.gbSummary.Controls.Add(this.lScore);
            this.gbSummary.Controls.Add(this.txtAttempts);
            this.gbSummary.Controls.Add(this.lAttempts);
            this.gbSummary.Controls.Add(this.txtWordsQty);
            this.gbSummary.Controls.Add(this.lWords);
            this.gbSummary.Controls.Add(this.txtListName);
            this.gbSummary.Controls.Add(this.lListName);
            this.gbSummary.Location = new System.Drawing.Point(12, 12);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(452, 242);
            this.gbSummary.TabIndex = 1;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Summary";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(97, 206);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(337, 20);
            this.txtTime.TabIndex = 15;
            // 
            // lTime
            // 
            this.lTime.Location = new System.Drawing.Point(7, 209);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(84, 18);
            this.lTime.TabIndex = 14;
            this.lTime.Text = "Time";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(97, 179);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(337, 20);
            this.txtDate.TabIndex = 13;
            // 
            // lDate
            // 
            this.lDate.Location = new System.Drawing.Point(7, 182);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(84, 18);
            this.lDate.TabIndex = 12;
            this.lDate.Text = "Date";
            // 
            // txtPercentScore
            // 
            this.txtPercentScore.Location = new System.Drawing.Point(97, 152);
            this.txtPercentScore.Name = "txtPercentScore";
            this.txtPercentScore.ReadOnly = true;
            this.txtPercentScore.Size = new System.Drawing.Size(337, 20);
            this.txtPercentScore.TabIndex = 11;
            // 
            // lPercentScore
            // 
            this.lPercentScore.Location = new System.Drawing.Point(7, 155);
            this.lPercentScore.Name = "lPercentScore";
            this.lPercentScore.Size = new System.Drawing.Size(84, 18);
            this.lPercentScore.TabIndex = 10;
            this.lPercentScore.Text = "Percent Score:";
            // 
            // txtFails
            // 
            this.txtFails.Location = new System.Drawing.Point(97, 125);
            this.txtFails.Name = "txtFails";
            this.txtFails.ReadOnly = true;
            this.txtFails.Size = new System.Drawing.Size(337, 20);
            this.txtFails.TabIndex = 9;
            // 
            // lFails
            // 
            this.lFails.Location = new System.Drawing.Point(7, 128);
            this.lFails.Name = "lFails";
            this.lFails.Size = new System.Drawing.Size(84, 18);
            this.lFails.TabIndex = 8;
            this.lFails.Text = "Fails:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(97, 98);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(337, 20);
            this.txtScore.TabIndex = 7;
            // 
            // lScore
            // 
            this.lScore.Location = new System.Drawing.Point(7, 101);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(84, 18);
            this.lScore.TabIndex = 6;
            this.lScore.Text = "Score:";
            // 
            // txtAttempts
            // 
            this.txtAttempts.Location = new System.Drawing.Point(97, 71);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.ReadOnly = true;
            this.txtAttempts.Size = new System.Drawing.Size(337, 20);
            this.txtAttempts.TabIndex = 5;
            // 
            // lAttempts
            // 
            this.lAttempts.Location = new System.Drawing.Point(7, 74);
            this.lAttempts.Name = "lAttempts";
            this.lAttempts.Size = new System.Drawing.Size(84, 18);
            this.lAttempts.TabIndex = 4;
            this.lAttempts.Text = "Attempts:";
            // 
            // txtWordsQty
            // 
            this.txtWordsQty.Location = new System.Drawing.Point(97, 44);
            this.txtWordsQty.Name = "txtWordsQty";
            this.txtWordsQty.ReadOnly = true;
            this.txtWordsQty.Size = new System.Drawing.Size(337, 20);
            this.txtWordsQty.TabIndex = 3;
            // 
            // lWords
            // 
            this.lWords.Location = new System.Drawing.Point(7, 47);
            this.lWords.Name = "lWords";
            this.lWords.Size = new System.Drawing.Size(84, 18);
            this.lWords.TabIndex = 2;
            this.lWords.Text = "Words qty:";
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(97, 17);
            this.txtListName.Name = "txtListName";
            this.txtListName.ReadOnly = true;
            this.txtListName.Size = new System.Drawing.Size(337, 20);
            this.txtListName.TabIndex = 1;
            // 
            // lListName
            // 
            this.lListName.Location = new System.Drawing.Point(7, 20);
            this.lListName.Name = "lListName";
            this.lListName.Size = new System.Drawing.Size(84, 18);
            this.lListName.TabIndex = 0;
            this.lListName.Text = "List Name:";
            // 
            // SummaryRW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 313);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.btnSaveAttemption);
            this.Name = "SummaryRW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SummaryRW";
            this.Load += new System.EventHandler(this.SummaryRW_Load);
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAttemption;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.TextBox txtPercentScore;
        private System.Windows.Forms.Label lPercentScore;
        private System.Windows.Forms.TextBox txtFails;
        private System.Windows.Forms.Label lFails;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.Label lAttempts;
        private System.Windows.Forms.TextBox txtWordsQty;
        private System.Windows.Forms.Label lWords;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label lListName;
    }
}