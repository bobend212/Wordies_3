using System;
using System.Linq;
using System.Windows.Forms;

namespace Wordies_3.Forms
{
    public partial class SummaryRW : Form
    {
        private ReadWrite readWrite;
        string _RWListName;
        int _wordCounter, _attempts;
        int _score, _fails;
        Word modelWord = new Word();

        public SummaryRW(string RWListName, int wordCounter, int attempts, int score, int fails)
        {
            _RWListName = RWListName;
            _wordCounter = wordCounter;
            _attempts = attempts;
            _score = score;
            _fails = fails;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAttemption_Click(object sender, EventArgs e)
        {

        }

        private void SummaryRW_Load(object sender, EventArgs e)
        {
            txtListName.Text = _RWListName;
            txtWordsQty.Text = _wordCounter.ToString();
            txtAttempts.Text = _attempts.ToString();
            txtScore.Text = _score.ToString();
            txtFails.Text = _fails.ToString();

            FindListId(_RWListName);
        }

        public void FindListId(string listName)
        {
            using (DBEntities db = new DBEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                var query = db.Lists
                    .Where(x => x.Name == listName);

                query.Select(x => x.IDList);
                    
                MessageBox.Show(query.ToString());
            }
        }

    }
}
