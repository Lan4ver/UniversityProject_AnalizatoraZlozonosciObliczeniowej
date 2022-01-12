using System.Collections.Generic;
using System.Windows.Forms;

namespace Projekt2_Podorozhnyi50402
{
    public partial class FiszkaKsiozki : Form
    {
        private List<Book> mPBomPoks;
        private Sortowanie mPSortowanie;

        public FiszkaKsiozki()
        {
            InitializeComponent();
            mPSortowanie = new Sortowanie();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            mPBomPoks = new List<Book>()
            {
                new Book { mPAuthor = "Antoine de Saint-Exupéry", mPSignature = "228AE", mPTitle = "Mały Książę", mPYear = 1947 },
                new Book { mPAuthor = "Fiodor Dostojewski", mPSignature = "1337AE", mPTitle = "Zbrodnia i kara", mPYear = 1867 },
                new Book { mPAuthor = "Dantego Alighieri", mPSignature = "1BIBA2BOBA", mPTitle = "Boska komedia", mPYear = 1472 },
                new Book { mPAuthor = "Platon", mPSignature = "1ZOKA2BOKA", mPTitle = "Res Publica", mPYear = -370  },
                new Book { mPAuthor = "Boka Podorozhny", mPSignature = "1337228AYE", mPTitle = "Nisko o wysokim", mPYear = 2019 },
                new Book { mPAuthor = "Zoka Podorozhny", mPSignature = "22813378AYE", mPTitle = "Minecrft to nasze życie", mPYear = 2020 }
            };

            ShowBooks();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (mPBomPoks == null)
                return;

            mPBomPoks = mPSortowanie.mPQuickSortStr(mPBomPoks);
            ShowBooks();
        }

        private void ShowBooks()
        {
            dataGridView1.Rows.Clear();
            mPBomPoks.ForEach(x =>
            {
                dataGridView1.Rows.Add(x.mPTitle, x.mPSignature, x.mPAuthor, x.mPYear);
            });
        }
    }
}
