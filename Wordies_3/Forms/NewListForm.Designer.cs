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
            this.txtNewListDescr = new System.Windows.Forms.RichTextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.txtNewListAdd = new System.Windows.Forms.TextBox();
            this.lNewListName = new System.Windows.Forms.Label();
            this.btnCancelNewList = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.dgvLists = new System.Windows.Forms.DataGridView();
            this.IDList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lLists = new System.Windows.Forms.Label();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.btnEraseListEdit = new System.Windows.Forms.Button();
            this.gbNewList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).BeginInit();
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
            // txtNewListDescr
            // 
            this.txtNewListDescr.Location = new System.Drawing.Point(49, 57);
            this.txtNewListDescr.Name = "txtNewListDescr";
            this.txtNewListDescr.Size = new System.Drawing.Size(244, 96);
            this.txtNewListDescr.TabIndex = 5;
            this.txtNewListDescr.Text = "";
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
            // dgvLists
            // 
            this.dgvLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDList,
            this.ListName,
            this.Descr});
            this.dgvLists.Location = new System.Drawing.Point(318, 35);
            this.dgvLists.Name = "dgvLists";
            this.dgvLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLists.Size = new System.Drawing.Size(451, 270);
            this.dgvLists.TabIndex = 4;
            this.dgvLists.DoubleClick += new System.EventHandler(this.dgvLists_DoubleClick);
            // 
            // IDList
            // 
            this.IDList.DataPropertyName = "IDList";
            this.IDList.HeaderText = "IDList";
            this.IDList.Name = "IDList";
            this.IDList.Visible = false;
            // 
            // ListName
            // 
            this.ListName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ListName.DataPropertyName = "Name";
            this.ListName.HeaderText = "ListName";
            this.ListName.Name = "ListName";
            // 
            // Descr
            // 
            this.Descr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descr.DataPropertyName = "Description";
            this.Descr.HeaderText = "Descr";
            this.Descr.Name = "Descr";
            // 
            // lLists
            // 
            this.lLists.AutoSize = true;
            this.lLists.Location = new System.Drawing.Point(374, 12);
            this.lLists.Name = "lLists";
            this.lLists.Size = new System.Drawing.Size(126, 13);
            this.lLists.TabIndex = 6;
            this.lLists.Text = "Your lists with vocabulary";
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveList.Location = new System.Drawing.Point(155, 187);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveList.TabIndex = 7;
            this.btnRemoveList.Text = "Remove";
            this.btnRemoveList.UseVisualStyleBackColor = false;
            this.btnRemoveList.Visible = false;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // btnEraseListEdit
            // 
            this.btnEraseListEdit.BackColor = System.Drawing.Color.Chocolate;
            this.btnEraseListEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEraseListEdit.Location = new System.Drawing.Point(76, 187);
            this.btnEraseListEdit.Name = "btnEraseListEdit";
            this.btnEraseListEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEraseListEdit.TabIndex = 8;
            this.btnEraseListEdit.Text = "Erase";
            this.btnEraseListEdit.UseVisualStyleBackColor = false;
            this.btnEraseListEdit.Click += new System.EventHandler(this.btnEraseListEdit_Click);
            // 
            // NewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 314);
            this.Controls.Add(this.btnEraseListEdit);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.lLists);
            this.Controls.Add(this.dgvLists);
            this.Controls.Add(this.gbNewList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnCancelNewList);
            this.Name = "NewListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewListForm";
            this.Load += new System.EventHandler(this.NewListForm_Load);
            this.gbNewList.ResumeLayout(false);
            this.gbNewList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewList;
        private System.Windows.Forms.TextBox txtNewListAdd;
        private System.Windows.Forms.Label lNewListName;
        private System.Windows.Forms.Button btnCancelNewList;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.RichTextBox txtNewListDescr;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.DataGridView dgvLists;
        private System.Windows.Forms.Label lLists;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.Button btnEraseListEdit;
    }
}