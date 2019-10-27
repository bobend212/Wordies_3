using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordies_3.Forms
{
    public partial class LearnWay : Form
    {
        public LearnWay()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Start startPage = new Start();
            startPage.Show();
        }

        private void btnReadWrite_Click(object sender, EventArgs e)
        {
            ReadWrite readWrite = new ReadWrite();
            this.Close();
            readWrite.Show();
        }
    }
}
