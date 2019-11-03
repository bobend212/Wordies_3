using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Wordies_3
{
    public partial class DBPage : Form
    {
        Word modelWord = new Word();
        List modelList = new List();

        public DBPage()
        {
            InitializeComponent();
        }

        #region Close_Exit_Erase_Buttons

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseDB_Click(object sender, EventArgs e)
        {
            Start startPage = new Start();
            this.Close();
            startPage.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HelperMethods.Clear(txtWord1, txtTranslation1, txtTranslation2, btnAddWord, btnCancel, btnDeleteWord, modelWord, modelList);
        }
        
        //private void Clear()
        //{
        //    txtWord1.Text = txtTranslation1.Text = txtTranslation2.Text = "";
        //    btnAddWord.Text = "ADD NEW";
        //    btnCancel.Text = "ERASE";
        //    btnDeleteWord.Enabled = false;
        //    modelWord.ID = 0;
        //    modelList.IDList = 0;
        //}

        #endregion

        private void DBPage_Load(object sender, EventArgs e)
        {
            //PopulateNewListComboBox();
            HelperMethods.Clear(txtWord1, txtTranslation1, txtTranslation2, btnAddWord, btnCancel, btnDeleteWord, modelWord, modelList);
            HelperMethods.PopulateComboBoxListsDB(cbLists);
            PopulateDataGridViewDB();
        }

        //public void PopulateNewListComboBox()
        //{
        //    using (DBEntities db = new DBEntities())
        //    {
        //        db.Configuration.ProxyCreationEnabled = false;
        //        cbLists.DataSource = db.Lists.ToList();
        //        cbLists.ValueMember = "Name";
        //        //cbLists.DisplayMember = "ListOne";
        //    }
        //    Populate.Clear(txtWord1, txtTranslation1, txtTranslation2, btnAddWord, btnCancel, btnDeleteWord, modelWord, modelList);
        //}

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWord1.Text) || string.IsNullOrWhiteSpace(txtTranslation1.Text))
            {
                MessageBox.Show("please fill all", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddWordToDB();
            }
        }

        private void AddWordToDB()
        {
            List obj = cbLists.SelectedItem as List;
            modelWord.Word1 = txtWord1.Text.Trim();
            modelWord.Translation1 = txtTranslation1.Text.Trim();
            modelWord.Translation2 = txtTranslation2.Text.Trim();
            modelWord.IDList = obj.IDList;
            using (DBEntities db = new DBEntities())
            {
                if (modelWord.ID == 0) //insert new record
                    db.Words.Add(modelWord);
                else //update
                    db.Entry(modelWord).State = EntityState.Modified;
                db.SaveChanges();
            }
            HelperMethods.Clear(txtWord1, txtTranslation1, txtTranslation2, btnAddWord, btnCancel, btnDeleteWord, modelWord, modelList);
            PopulateDataGridViewDB();
            txtWord1.Focus();
        }

        private void PopulateDataGridViewDB()
        {
            dgvDB.AutoGenerateColumns = false;
            List obj = cbLists.SelectedItem as List;

            if (obj != null)
            {
                try
                {
                    using (DBEntities db = new DBEntities())
                    {
                        db.Configuration.ProxyCreationEnabled = false;
                        var query = from o in db.Words
                                    where o.IDList == obj.IDList
                                    select o;

                        dgvDB.DataSource = query.ToList();
                        WordsCounter(query);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MessageXXXX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDB_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickOnDGV();
        }

        private void DoubleClickOnDGV()
        {
            if (dgvDB.Rows.Count == 0)
            {
                MessageBox.Show("This list is empty! Add some wordies :)");
            }
            else
            {
                modelWord.ID = Convert.ToInt32(dgvDB.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    modelWord = db.Words.Where(x => x.ID == modelWord.ID).FirstOrDefault();
                    txtWord1.Text = modelWord.Word1;
                    txtTranslation1.Text = modelWord.Translation1;
                    txtTranslation2.Text = modelWord.Translation2;
                }
                btnAddWord.Text = "UPDATE";
                btnCancel.Text = "CANCEL";
                btnDeleteWord.Enabled = true;
            }
        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            DeleteWord();
        }

        private void DeleteWord()
        {
            try
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(modelWord);
                    if (entry.State == EntityState.Detached)
                        db.Words.Attach(modelWord);
                    db.Words.Remove(modelWord);
                    db.SaveChanges();
                    PopulateDataGridViewDB();
                    HelperMethods.Clear(txtWord1, txtTranslation1, txtTranslation2, btnAddWord, btnCancel, btnDeleteWord, modelWord, modelList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLists_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List obj = cbLists.SelectedItem as List;
            if(obj != null)
            {
                try
                {
                    using(DBEntities db = new DBEntities())
                    {
                        db.Configuration.ProxyCreationEnabled = false;
                        var wordCnt = from o in db.Words
                                    where o.IDList == obj.IDList
                                    select o;
                        dgvDB.DataSource = wordCnt.ToList();

                        WordsCounter(wordCnt);
                        
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WordsCounter(IQueryable<Word> query)
        {
            int wordCounter = query.Count(x => x.ID > 0);
            if (wordCounter == 0)
                lWordsCounter.Text = "This List is empty.";
            else
                lWordsCounter.Text = "This List contain: " + wordCounter + " words.";

            txtListDescr.Text = wordCounter.ToString(); //tutaj zrobic tak aby wyswietlalo description dla listy. <--------------
        }

        private void btnManageList_Click(object sender, EventArgs e)
        {
            NewListForm newListForm = new NewListForm();
            this.Close();
            newListForm.Show();
        }
    }
}
