using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordies_3
{
    public partial class DBPage : Form
    {
        Word model = new Word();

        //string connStr = @"Data Source=DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog=Wordies 2.0 DB; Integrated Security=True;";

        public DBPage()
        {
            InitializeComponent();
            //LoadDB();
            PopulateDataGridViewDB();
        }

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
            Clear();
        }

        private void Clear()
        {
            txtWord1.Text = txtTranslation1.Text = "";
            btnAddWord.Text = "Save";
            btnDeleteWord.Enabled = false;
            model.ID = 0;
        }

        private void DBPage_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            model.Word1 = txtWord1.Text.Trim();
            model.Translation1 = txtTranslation1.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0) //insert new record
                    db.Words.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridViewDB();
            MessageBox.Show("Word added");
        }

        private void PopulateDataGridViewDB()
        {
            dgvDB.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvDB.DataSource = db.Words.ToList<Word>();
            }
            //    public void LoadDB()
            //{
            //    using(SqlConnection sqlConn = new SqlConnection(connStr))
            //    {
            //        sqlConn.Open();
            //        SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Word1, Translation1 FROM Words", sqlConn);
            //        DataTable dtbl = new DataTable();
            //        sqlDA.Fill(dtbl);

            //        dgvDB.DataSource = dtbl;
            //        dgvDB.Columns[0].HeaderText = "**Word**";
            //        dgvDB.Columns[1].HeaderText = "**Translation**";
            //        dgvDB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        dgvDB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    }
            //}
        }

        private void dgvDB_DoubleClick(object sender, EventArgs e)
        {
            if(dgvDB.CurrentRow.Index != 1)
            {
                model.ID = Convert.ToInt32(dgvDB.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.Words.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtWord1.Text = model.Word1;
                    txtTranslation1.Text = model.Translation1;
                }
                btnAddWord.Text = "Update";
                btnDeleteWord.Enabled = true;
            }
        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            using(DBEntities db = new DBEntities())
            {
                var entry = db.Entry(model);
                if (entry.State == EntityState.Detached)
                    db.Words.Attach(model);
                db.Words.Remove(model);
                db.SaveChanges();
                PopulateDataGridViewDB();
                Clear();
                MessageBox.Show("deleted!");
            }
        }
    }
}
