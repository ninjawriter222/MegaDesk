using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Poe1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllQuotes vaq = new ViewAllQuotes();
            vaq.Show();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchQuotes sq = new SearchQuotes();
            sq.Show();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuote aq = new AddQuote();
            aq.Show();
        }
    }
}
