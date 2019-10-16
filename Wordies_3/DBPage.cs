using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        string connStr = @"Data Source=DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog=Wordies 2.0 DB; Integrated Security=True;";

        public DBPage()
        {
            InitializeComponent();
            LoadDB();
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

        public void LoadDB()
        {
            using(SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Word1, Translation1 FROM Words", sqlConn);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dgvDB.DataSource = dtbl;
                dgvDB.Columns[0].HeaderText = "**Word**";
                dgvDB.Columns[1].HeaderText = "**Translation**";
                dgvDB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
