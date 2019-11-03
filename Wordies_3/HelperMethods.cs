using System.Linq;
using System.Windows.Forms;

namespace Wordies_3
{
    public static class HelperMethods
    {
        public static void PopulateComboBoxListsDB(ComboBox cb)
        {
            using (DBEntities db = new DBEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                cb.DataSource = db.Lists.ToList();
                cb.ValueMember = "Name";
            }
        }

        public static void Clear(TextBox txt1, TextBox txt2, TextBox txt3, Button b1, Button b2, Button b3, Word modelWord, List modelList)
        {
            txt1.Text = txt2.Text = txt3.Text = "";
            b1.Text = "ADD NEW";
            b2.Text = "ERASE";
            b3.Enabled = false;
            modelWord.ID = 0;
            modelList.IDList = 0;
        }
    }
}
