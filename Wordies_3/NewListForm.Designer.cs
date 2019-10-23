namespace Wordies_3
{
    partial class NewListForm
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
            this.gbNewList = new System.Windows.Forms.GroupBox();
            this.btnCancelNewList = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.txtNewListAdd = new System.Windows.Forms.TextBox();
            this.lNewListName = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.txtNewListDescr = new System.Windows.Forms.RichTextBox();
            this.gbNewList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewList
            // 
            this.gbNewList.BackColor = System.Drawing.SystemColors.Info;
            this.gbNewList.Controls.Add(this.txtNewListDescr);
            this.gbNewList.Controls.Add(this.lDescription);
            this.gbNewList.Controls.Add(this.txtNewListAdd);
            this.gbNewList.Controls.Add(this.lNewListName);
            this.gbNewList.Location = new System.Drawing.Point(12, 12);
            this.gbNewList.Name = "gbNewList";
            this.gbNewList.Size = new System.Drawing.Size(299, 169);
            this.gbNewList.TabIndex = 0;
            this.gbNewList.TabStop = false;
            this.gbNewList.Text = "NEW LIST";
            // 
            // btnCancelNewList
            // 
            this.btnCancelNewList.Location = new System.Drawing.Point(12, 187);
            this.btnCancelNewList.Name = "btnCancelNewList";
            this.btnCancelNewList.Size = new System.Drawing.Size(58, 23);
            this.btnCancelNewList.TabIndex = 3;
            this.btnCancelNewList.Text = "CANCEL";
            this.btnCancelNewList.UseVisualStyleBackColor = true;
            this.btnCancelNewList.Click += new System.EventHandler(this.btnCancelNewList_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddList.Location = new System.Drawing.Point(236, 187);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 23);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "APPLY";
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // txtNewListAdd
            // 
            this.txtNewListAdd.Location = new System.Drawing.Point(48, 23);
            this.txtNewListAdd.Name = "txtNewListAdd";
            this.txtNewListAdd.Size = new System.Drawing.Size(245, 20);
            this.txtNewListAdd.TabIndex = 1;
            // 
            // lNewListName
            // 
            this.lNewListName.AutoSize = true;
            this.lNewListName.Location = new System.Drawing.Point(6, 26);
            this.lNewListName.Name = "lNewListName";
            this.lNewListName.Size = new System.Drawing.Size(36, 13);
            this.lNewListName.TabIndex = 0;
            this.lNewListName.Text = "name:";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(6, 57);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(36, 13);
            this.lDescription.TabIndex = 4;
            this.lDescription.Text = "descr:";
            // 
            // txtNewListDescr
            // 
            this.txtNewListDescr.Location = new System.Drawing.Point(49, 57);
            this.txtNewListDescr.Name = "txtNewListDescr";
            this.txtNewListDescr.Size = new System.Drawing.Size(244, 96);
            this.txtNewListDescr.TabIndex = 5;
            this.txtNewListDescr.Text = "";
            // 
            // NewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 218);
            this.Controls.Add(this.gbNewList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnCancelNewList);
            this.Name = "NewListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewListForm";
            this.gbNewList.ResumeLayout(false);
            this.gbNewList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewList;
        private System.Windows.Forms.TextBox txtNewListAdd;
        private System.Windows.Forms.Label lNewListName;
        private System.Windows.Forms.Button btnCancelNewList;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.RichTextBox txtNewListDescr;
        private System.Windows.Forms.Label lDescription;
    }
}