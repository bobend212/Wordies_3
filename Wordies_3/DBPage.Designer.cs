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
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.lWord1 = new System.Windows.Forms.Label();
            this.lTranslation1 = new System.Windows.Forms.Label();
            this.txtTranslation1 = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCloseDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDB
            // 
            this.dgvDB.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Location = new System.Drawing.Point(12, 81);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.Size = new System.Drawing.Size(674, 388);
            this.dgvDB.TabIndex = 0;
            // 
            // txtWord1
            // 
            this.txtWord1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWord1.Location = new System.Drawing.Point(12, 39);
            this.txtWord1.Multiline = true;
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(282, 28);
            this.txtWord1.TabIndex = 1;
            this.txtWord1.Text = "Sample word";
            // 
            // lWord1
            // 
            this.lWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWord1.Location = new System.Drawing.Point(12, 9);
            this.lWord1.Name = "lWord1";
            this.lWord1.Size = new System.Drawing.Size(72, 27);
            this.lWord1.TabIndex = 2;
            this.lWord1.Text = "Word";
            // 
            // lTranslation1
            // 
            this.lTranslation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTranslation1.Location = new System.Drawing.Point(295, 9);
            this.lTranslation1.Name = "lTranslation1";
            this.lTranslation1.Size = new System.Drawing.Size(135, 27);
            this.lTranslation1.TabIndex = 4;
            this.lTranslation1.Text = "Translation";
            // 
            // txtTranslation1
            // 
            this.txtTranslation1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTranslation1.Location = new System.Drawing.Point(300, 39);
            this.txtTranslation1.Multiline = true;
            this.txtTranslation1.Name = "txtTranslation1";
            this.txtTranslation1.Size = new System.Drawing.Size(282, 28);
            this.txtTranslation1.TabIndex = 5;
            this.txtTranslation1.Text = "Sample translation";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(588, 29);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(46, 46);
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = "Add+";
            this.btnAddWord.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(640, 29);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(46, 46);
            this.btnDeleteWord.TabIndex = 7;
            this.btnDeleteWord.Text = "DEL-";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(605, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "QUIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCloseDB
            // 
            this.btnCloseDB.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDB.ForeColor = System.Drawing.Color.White;
            this.btnCloseDB.Location = new System.Drawing.Point(518, 475);
            this.btnCloseDB.Name = "btnCloseDB";
            this.btnCloseDB.Size = new System.Drawing.Size(81, 33);
            this.btnCloseDB.TabIndex = 9;
            this.btnCloseDB.Text = "CLOSE";
            this.btnCloseDB.UseVisualStyleBackColor = false;
            this.btnCloseDB.Click += new System.EventHandler(this.btnCloseDB_Click);
            // 
            // DBPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 516);
            this.Controls.Add(this.btnCloseDB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtTranslation1);
            this.Controls.Add(this.lTranslation1);
            this.Controls.Add(this.lWord1);
            this.Controls.Add(this.txtWord1);
            this.Controls.Add(this.dgvDB);
            this.Name = "DBPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.TextBox txtWord1;
        private System.Windows.Forms.Label lWord1;
        private System.Windows.Forms.Label lTranslation1;
        private System.Windows.Forms.TextBox txtTranslation1;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCloseDB;
    }
}