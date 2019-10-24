using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Wordies_3
{
    public partial class NewListForm : Form
    {

        List modelList = new List();
        Word wordList = new Word();
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
                    if (modelList.IDList == 0) //insert new record
                        db.Lists.Add(modelList);
                    else //update
                        db.Entry(modelList).State = EntityState.Modified;
                    db.SaveChanges();
                }
                txtNewListAdd.Text = txtNewListDescr.Text = "";
                txtNewListAdd.Focus();
                PopulateDGViewLists();
                btnRemoveList.Visible = false;
                btnAddList.Text = "APPLY";
                modelList.IDList = 0;
            }
            else
            {
                MessageBox.Show("no value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void NewListForm_Load(object sender, EventArgs e)
        {
            PopulateDGViewLists();

        }

        private void PopulateDGViewLists()
        {
            dgvLists.AutoGenerateColumns = false;
            try
            {
                using (DBEntities db = new DBEntities())
                {
                    db.Configuration.ProxyCreationEnabled = false;
                    var query = from o in db.Lists
                                select o;

                    dgvLists.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MessageXXXX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            DeleteList();
        }

        private void DeleteList()
        {
            try
            {
                using (DBEntities db = new DBEntities())
                {
                    db.Database.ExecuteSqlCommand("DELETE FROM Words WHERE IDList =" + modelList.IDList);
                    var entry = db.Entry(modelList);
                    if (entry.State == EntityState.Detached)
                        db.Lists.Attach(modelList);
                    db.Lists.Remove(modelList);
                    db.SaveChanges();
                    PopulateDGViewLists();
                    btnRemoveList.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLists_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickOnDGVLists();
        }

        private void DoubleClickOnDGVLists()
        {
            if (dgvLists.Rows.Count == 0)
            {
                MessageBox.Show("This list is empty! Add some wordies :)");
            }
            else
            {
                modelList.IDList = Convert.ToInt32(dgvLists.CurrentRow.Cells["IDList"].Value);
                using (DBEntities db = new DBEntities())
                {
                    modelList = db.Lists.Where(x => x.IDList == modelList.IDList).FirstOrDefault();
                    txtNewListAdd.Text = modelList.Name;
                    txtNewListDescr.Text = modelList.Description;
                }
                btnRemoveList.Visible = true;
                btnAddList.Text = "UPDATE";
            }
        }
    }
}
