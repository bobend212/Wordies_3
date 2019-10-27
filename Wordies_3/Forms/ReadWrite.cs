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
    public partial class ReadWrite : Form
    {
        DBPage dBPage = new DBPage();

        public ReadWrite()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReadWrite_Load(object sender, EventArgs e)
        {
            HelperMethods.PopulateComboBoxListsDB(cbListsRW);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LearnWay learnWay = new LearnWay();
            learnWay.Show();
        }



        private void cbListsRW_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //List obj = cbListsRW.SelectedItem as List;
            //if (obj != null)
            //{
            //    try
            //    {
            //        using (DBEntities db = new DBEntities())
            //        {
            //            db.Configuration.ProxyCreationEnabled = false;
            //            var query = db.Words.Where(x => obj.IDList == x.IDList).FirstOrDefault();
            //            lQuestionWord.Text = query.Word1;

            //            var count = db.Words.Count(x => obj.IDList == x.IDList);
            //            MessageBox.Show(count.ToString());
                        
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        int next = 1;
        

        private void btnNextWord_Click(object sender, EventArgs e)
        {

            List obj = cbListsRW.SelectedItem as List;
            if (obj != null)
            {
                try
                {
                    using (DBEntities db = new DBEntities())
                    {
                        var count = db.Words.Count(x => obj.IDList == x.IDList);

                            db.Configuration.ProxyCreationEnabled = false;
                            var query = db.Words
                                .Where(x => obj.IDList == x.IDList)
                                .OrderBy(x => x.ID)
                                .Skip(next)
                                .FirstOrDefault();

                            next++;
                        if (next <= count)
                            lQuestionWord.Text = query.Word1 + count.ToString();
                        else
                        {
                            MessageBox.Show("koniec listy");
                            next = count;
                        }

                        //int xx = query.Word1.Count();
                        //MessageBox.Show("NEXT: " + next.ToString());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtAnswerWord.Text = next.ToString();
        }

        private void btnPreviousWord_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("PREV: " + next.ToString());
            List obj = cbListsRW.SelectedItem as List;
            if (obj != null)
            {
                try
                {
                    next--;
                    using (DBEntities db = new DBEntities())
                    {
                        var count = db.Words.Count(x => obj.IDList == x.IDList);

                        db.Configuration.ProxyCreationEnabled = false;
                        var query = db.Words
                            .Where(x => obj.IDList == x.IDList)
                            .OrderBy(x => x.ID)
                            .Skip(next-1)
                            .FirstOrDefault();

                        
                        if (next <= count)
                        {
                            lQuestionWord.Text = query.Word1 + count.ToString();
                        }
                        else
                        {
                            MessageBox.Show("koniec listy");
                            next = 1;
                        }

                        //int xx = query.Word1.Count();
                        //MessageBox.Show(start.ToString());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtAnswerWord.Text = next.ToString();

        }
    }
}
