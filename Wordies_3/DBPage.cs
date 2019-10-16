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
    public partial class DBPage : Form
    {
        public DBPage()
        {
            InitializeComponent();
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
    }
}
