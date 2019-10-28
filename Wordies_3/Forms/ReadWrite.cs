using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Wordies_3.Forms
{
    public partial class ReadWrite : Form
    {
        DBPage dBPage = new DBPage();
        int position = 0;

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

        private void DisplWord(List obj, DBEntities db, out int count, out Word query)
        {
            count = db.Words.Count(x => obj.IDList == x.IDList);
            db.Configuration.ProxyCreationEnabled = false;
            query = db.Words
                .Where(x => obj.IDList == x.IDList)
                .OrderBy(x => x.ID)
                .Skip(position)
                .FirstOrDefault();
        }

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
                        int count;
                        Word query;
                        DisplWord(obj, db, out count, out query);

                        if (position <= count)
                            lQuestionWord.Text = query.Word1;
                        else
                        {
                            MessageBox.Show("koniec listy");
                            position = count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                        int count;
                        Word query;
                        DisplWord(obj, db, out count, out query);

                        if (position > count - 1)
                        {
                            MessageBox.Show("koniec listy PRZOD");
                            position = count - 1;
                        }
                        else
                        {
                            lQuestionWord.Text = query.Word1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPreviousWord_Click(object sender, EventArgs e)
        {
            position--;

            List obj = cbListsRW.SelectedItem as List;
            if (obj != null)
            {
                try
                {
                    using (DBEntities db = new DBEntities())
                    {
                        if (position < 0)
                        {
                            position = 0;
                            MessageBox.Show("koniec listy TYL");
                        }
                        else
                        {
                            int count;
                            Word query;
                            DisplWord(obj, db, out count, out query);
                            lQuestionWord.Text = query.Word1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messageff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            List obj = cbListsRW.SelectedItem as List;

            using (DBEntities db = new DBEntities())
            {
                var query = db.Words
                    .Where(x => obj.IDList == x.IDList)
                    .OrderBy(x => x.ID)
                    .Skip(position)
                    .FirstOrDefault();

                //tu wyrzuca error gdy w txtboxAnswer jest empty

                if (txtAnswerWord.Text == query.Translation1.ToString() || txtAnswerWord.Text == query.Translation2.ToString())
                {
                    lResult.Text = "TRUE!";
                }
                else
                {
                    lResult.Text = "FALSE!";
                }
            }


        }
    }
}
