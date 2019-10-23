using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordies_3
{
    public partial class NewListForm : Form
    {

        List modelList = new List();
        DBPage dBPage = new DBPage();

        public NewListForm()
        {
            InitializeComponent();
        }

        private void btnCancelNewList_Click(object sender, EventArgs e)
        {
            this.Close();
            dBPage.Show();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            AddNewList();
        }

        private void AddNewList()
        {
            if (!string.IsNullOrWhiteSpace(txtNewListAdd.Text))
            {
                modelList.Name = txtNewListAdd.Text.Trim();
                modelList.Description = txtNewListDescr.Text.Trim();
                using (DBEntities db = new DBEntities())
                {
                    db.Lists.Add(modelList);
                    db.SaveChanges();
                }
                MessageBox.Show("LIST (" + txtNewListAdd.Text + ") CREATED", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                dBPage.Show();
            }
            else
            {
                MessageBox.Show("no value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
