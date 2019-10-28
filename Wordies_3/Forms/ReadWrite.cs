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

        int position = 0;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            position = 0;
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
                            .Skip(position)
                            .FirstOrDefault();

                        //position++;
                        if (position <= count)
                            lQuestionWord.Text = query.Word1 + count.ToString();
                        else
                        {
                            MessageBox.Show("koniec listy");
                            position = count;
                        }
                        //position++;
                        //int xx = query.Word1.Count();
                        //MessageBox.Show("NEXT: " + next.ToString());


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtAnswerWord.Text = position.ToString();
        }

        
        

        private void btnNextWord_Click(object sender, EventArgs e)
        {
            position++;

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
                                .Skip(position)
                                .FirstOrDefault();


                        if (position > count - 1)
                        {
                            MessageBox.Show("koniec listy PRZOD");
                            position = count - 1;
                        }
                        else
                        {
                            lQuestionWord.Text = query.Word1 + count.ToString();
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
            txtAnswerWord.Text = position.ToString();
        }

        private void btnPreviousWord_Click(object sender, EventArgs e)
        {
                            position--;

            //MessageBox.Show("PREV: " + next.ToString());
            List obj = cbListsRW.SelectedItem as List;
            if (obj != null)
            {
                try
                {
                    using (DBEntities db = new DBEntities())
                    {
                        //if (position >= 1)
                        

                        


                        if (position < 0)
                        {
                            position = 0;
                            MessageBox.Show("koniec listy TYL");
                        }
                        else
                        {
                            var count = db.Words.Count(x => obj.IDList == x.IDList);
                            db.Configuration.ProxyCreationEnabled = false;
                            var query = db.Words
                                .Where(x => obj.IDList == x.IDList)
                                .OrderBy(x => x.ID)
                                .Skip(position)
                                .FirstOrDefault();
                            lQuestionWord.Text = query.Word1 + count.ToString();
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
            txtAnswerWord.Text = position.ToString();

        }
    }
}
