using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordies_3.Forms
{
    public partial class ReadWrite : Form
    {
        DBPage dBPage = new DBPage();
        int position = 0;
        int score = 0;
        int hintCnt = 1;

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
            Random rnd = new Random();

            count = db.Words.Count(x => obj.IDList == x.IDList);
            db.Configuration.ProxyCreationEnabled = false;


            if (chbAlfOrder.Checked == true)
            {
                query = db.Words
                    .Where(x => obj.IDList == x.IDList)
                    .OrderBy(x => x.Word1)
                    .Skip(position)
                    .FirstOrDefault();

            }
            else if(chbOrderInsertion.Checked == true)
            {
                query = db.Words
                    .Where(x => obj.IDList == x.IDList)
                    .OrderBy(x => x.ID)
                    .Skip(position)
                    .FirstOrDefault();
            }
            else if(chbRandom.Checked == true)
            {
                position = rnd.Next(0, count);
                query = db.Words
                   .Where(x => obj.IDList == x.IDList)
                   .OrderBy(x => x.ID)
                   .Skip(position)
                   .FirstOrDefault();
            }
            else
            {
                query = db.Words
                    .Where(x => obj.IDList == x.IDList)
                    .OrderBy(x => x.ID)
                    .Skip(position)
                    .FirstOrDefault();
            }
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            position = 0;
            hintCnt = 1;
            score = 0;
            lScore.Text = score.ToString();

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
            NextWord();
        }

        private void NextWord()
        {
            position++;
            hintCnt = 1;
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
            PreviousWord();
        }

        private void PreviousWord()
        {
            position--;
            hintCnt = 1;

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
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            List obj = cbListsRW.SelectedItem as List;

            using (DBEntities db = new DBEntities())
            {
                int count;
                Word query;
                DisplWord(obj, db, out count, out query);

                if (txtAnswerWord.Text == query.Translation1.ToString() 
                    || (txtAnswerWord.Text == query.Translation2.ToString() && !string.IsNullOrWhiteSpace(txtAnswerWord.Text)))
                {
                    lResult.ForeColor = Color.LightGreen;
                    lResult.Text = "TRUE!";
                    txtAnswerWord.Clear();
                    score += 2;
                    lScore.Text = score.ToString();
                    NextWord();
                }
                else
                {
                    score -= 1;
                    lScore.Text = score.ToString();
                    lResult.ForeColor = Color.Red;
                    lResult.Text = "FALSE!";
                }
            }
        }

        private void chbAlfOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAlfOrder.Checked == true)
            {
                chbOrderInsertion.Checked = false;
            }
            else
            {
                chbOrderInsertion.Checked = true;
            }

        }

        private void chbPrevDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPrevDisable.Checked == true)
            {
                btnPreviousWord.Enabled = false;
                btnPreviousWord.Visible = false;
            }
            else
            {
                btnPreviousWord.Enabled = true;
                btnPreviousWord.Visible = true;
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            List obj = cbListsRW.SelectedItem as List;
            if (obj != null)
            {
                using (DBEntities db = new DBEntities())
                {
                    int count;
                    Word query;
                    DisplWord(obj, db, out count, out query);


                    //var query = db.Words
                    //    .Where(x => obj.IDList == x.IDList)
                    //    .OrderBy(x => x.ID)
                    //    .Skip(position)
                    //    .FirstOrDefault();

                    txtAnswerWord.Text = query.Translation1.Substring(0, hintCnt);
                    hintCnt++;
                }
            }
            score -= 2;
            lScore.Text = score.ToString();

        }
    }
}


// poprawic funkcjnalnosci random, prevword itd.. chodzi o scoring aby dobrze dzialal
