namespace Wordies_3
{
    partial class DBPage
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
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.lWord1 = new System.Windows.Forms.Label();
            this.lTranslation1 = new System.Windows.Forms.Label();
            this.txtTranslation1 = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCloseDB = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelWords = new System.Windows.Forms.Panel();
            this.lAlternativeTranslation = new System.Windows.Forms.Label();
            this.txtTranslation2 = new System.Windows.Forms.TextBox();
            this.cbLists = new System.Windows.Forms.ComboBox();
            this.lSelectList = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.lWordsCounter = new System.Windows.Forms.Label();
            this.panelLists = new System.Windows.Forms.Panel();
            this.txtAddList = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.panelWords.SuspendLayout();
            this.panelLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDB
            // 
            this.dgvDB.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Word,
            this.Translation,
            this.Translation2});
            this.dgvDB.Location = new System.Drawing.Point(329, 12);
            this.dgvDB.MultiSelect = false;
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDB.Size = new System.Drawing.Size(625, 423);
            this.dgvDB.TabIndex = 4;
            this.dgvDB.DoubleClick += new System.EventHandler(this.dgvDB_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Word
            // 
            this.Word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Word.DataPropertyName = "Word1";
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Translation
            // 
            this.Translation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Translation.DataPropertyName = "Translation1";
            this.Translation.HeaderText = "Translation";
            this.Translation.Name = "Translation";
            this.Translation.ReadOnly = true;
            // 
            // Translation2
            // 
            this.Translation2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Translation2.DataPropertyName = "Translation2";
            this.Translation2.HeaderText = "Translation2";
            this.Translation2.Name = "Translation2";
            this.Translation2.ReadOnly = true;
            // 
            // txtWord1
            // 
            this.txtWord1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWord1.Location = new System.Drawing.Point(16, 40);
            this.txtWord1.Multiline = true;
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(282, 28);
            this.txtWord1.TabIndex = 1;
            this.txtWord1.Text = "Sample word";
            // 
            // lWord1
            // 
            this.lWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWord1.Location = new System.Drawing.Point(16, 10);
            this.lWord1.Name = "lWord1";
            this.lWord1.Size = new System.Drawing.Size(72, 27);
            this.lWord1.TabIndex = 0;
            this.lWord1.Text = "Word";
            // 
            // lTranslation1
            // 
            this.lTranslation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTranslation1.Location = new System.Drawing.Point(16, 71);
            this.lTranslation1.Name = "lTranslation1";
            this.lTranslation1.Size = new System.Drawing.Size(135, 27);
            this.lTranslation1.TabIndex = 2;
            this.lTranslation1.Text = "Translation";
            // 
            // txtTranslation1
            // 
            this.txtTranslation1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTranslation1.Location = new System.Drawing.Point(16, 101);
            this.txtTranslation1.Multiline = true;
            this.txtTranslation1.Name = "txtTranslation1";
            this.txtTranslation1.Size = new System.Drawing.Size(282, 28);
            this.txtTranslation1.TabIndex = 3;
            this.txtTranslation1.Text = "Sample translation";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(30, 196);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(82, 46);
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = "ADD NEW";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(169, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "QUIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCloseDB
            // 
            this.btnCloseDB.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDB.ForeColor = System.Drawing.Color.White;
            this.btnCloseDB.Location = new System.Drawing.Point(82, 402);
            this.btnCloseDB.Name = "btnCloseDB";
            this.btnCloseDB.Size = new System.Drawing.Size(81, 33);
            this.btnCloseDB.TabIndex = 5;
            this.btnCloseDB.Text = "CLOSE";
            this.btnCloseDB.UseVisualStyleBackColor = false;
            this.btnCloseDB.Click += new System.EventHandler(this.btnCloseDB_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(118, 196);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(82, 46);
            this.btnDeleteWord.TabIndex = 7;
            this.btnDeleteWord.Text = "REMOVE";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "ERASE";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelWords
            // 
            this.panelWords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelWords.Controls.Add(this.lAlternativeTranslation);
            this.panelWords.Controls.Add(this.txtTranslation2);
            this.panelWords.Controls.Add(this.txtWord1);
            this.panelWords.Controls.Add(this.btnCancel);
            this.panelWords.Controls.Add(this.lWord1);
            this.panelWords.Controls.Add(this.btnDeleteWord);
            this.panelWords.Controls.Add(this.lTranslation1);
            this.panelWords.Controls.Add(this.txtTranslation1);
            this.panelWords.Controls.Add(this.btnAddWord);
            this.panelWords.Location = new System.Drawing.Point(12, 12);
            this.panelWords.Name = "panelWords";
            this.panelWords.Size = new System.Drawing.Size(311, 258);
            this.panelWords.TabIndex = 0;
            // 
            // lAlternativeTranslation
            // 
            this.lAlternativeTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAlternativeTranslation.Location = new System.Drawing.Point(16, 132);
            this.lAlternativeTranslation.Name = "lAlternativeTranslation";
            this.lAlternativeTranslation.Size = new System.Drawing.Size(282, 27);
            this.lAlternativeTranslation.TabIndex = 4;
            this.lAlternativeTranslation.Text = "Alternative Translation";
            // 
            // txtTranslation2
            // 
            this.txtTranslation2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTranslation2.Location = new System.Drawing.Point(16, 162);
            this.txtTranslation2.Multiline = true;
            this.txtTranslation2.Name = "txtTranslation2";
            this.txtTranslation2.Size = new System.Drawing.Size(282, 28);
            this.txtTranslation2.TabIndex = 5;
            this.txtTranslation2.Text = "Sample alt. translation";
            // 
            // cbLists
            // 
            this.cbLists.FormattingEnabled = true;
            this.cbLists.Location = new System.Drawing.Point(6, 30);
            this.cbLists.Name = "cbLists";
            this.cbLists.Size = new System.Drawing.Size(301, 21);
            this.cbLists.TabIndex = 2;
            this.cbLists.SelectionChangeCommitted += new System.EventHandler(this.cbLists_SelectionChangeCommitted);
            // 
            // lSelectList
            // 
            this.lSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSelectList.Location = new System.Drawing.Point(3, 8);
            this.lSelectList.Name = "lSelectList";
            this.lSelectList.Size = new System.Drawing.Size(127, 19);
            this.lSelectList.TabIndex = 1;
            this.lSelectList.Text = "Select List";
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(5, 57);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(65, 44);
            this.btnAddList.TabIndex = 3;
            this.btnAddList.Text = "New List";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Location = new System.Drawing.Point(75, 57);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(65, 44);
            this.btnRemoveList.TabIndex = 7;
            this.btnRemoveList.Text = "Remove List";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            // 
            // lWordsCounter
            // 
            this.lWordsCounter.AutoSize = true;
            this.lWordsCounter.Location = new System.Drawing.Point(257, 12);
            this.lWordsCounter.Name = "lWordsCounter";
            this.lWordsCounter.Size = new System.Drawing.Size(50, 13);
            this.lWordsCounter.TabIndex = 8;
            this.lWordsCounter.Text = "Words: 0";
            // 
            // panelLists
            // 
            this.panelLists.BackColor = System.Drawing.Color.Khaki;
            this.panelLists.Controls.Add(this.txtAddList);
            this.panelLists.Controls.Add(this.lSelectList);
            this.panelLists.Controls.Add(this.lWordsCounter);
            this.panelLists.Controls.Add(this.cbLists);
            this.panelLists.Controls.Add(this.btnRemoveList);
            this.panelLists.Controls.Add(this.btnAddList);
            this.panelLists.Location = new System.Drawing.Point(12, 276);
            this.panelLists.Name = "panelLists";
            this.panelLists.Size = new System.Drawing.Size(311, 120);
            this.panelLists.TabIndex = 9;
            // 
            // txtAddList
            // 
            this.txtAddList.Location = new System.Drawing.Point(146, 57);
            this.txtAddList.Name = "txtAddList";
            this.txtAddList.Size = new System.Drawing.Size(161, 20);
            this.txtAddList.TabIndex = 9;
            this.txtAddList.Text = "Sample";
            this.txtAddList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddList.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DBPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 443);
            this.Controls.Add(this.panelLists);
            this.Controls.Add(this.panelWords);
            this.Controls.Add(this.btnCloseDB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvDB);
            this.Name = "DBPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBPage";
            this.Load += new System.EventHandler(this.DBPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.panelWords.ResumeLayout(false);
            this.panelWords.PerformLayout();
            this.panelLists.ResumeLayout(false);
            this.panelLists.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.TextBox txtWord1;
        private System.Windows.Forms.Label lWord1;
        private System.Windows.Forms.Label lTranslation1;
        private System.Windows.Forms.TextBox txtTranslation1;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCloseDB;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelWords;
        private System.Windows.Forms.ComboBox cbLists;
        private System.Windows.Forms.Label lSelectList;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation2;
        private System.Windows.Forms.Label lAlternativeTranslation;
        private System.Windows.Forms.TextBox txtTranslation2;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.Label lWordsCounter;
        private System.Windows.Forms.Panel panelLists;
        private System.Windows.Forms.TextBox txtAddList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}