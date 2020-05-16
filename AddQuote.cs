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
    public partial class AddQuote : Form
    {
        public const double MIN_WIDTH = 24;
        public const double MAX_WIDTH = 96;
        public const double MAX_DEPTH = 48;
        public const double MIN_DEPTH = 12;

        public AddQuote()
        {
            InitializeComponent();
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            string stringDate = currentDate.ToString("MM/dd/yyyy");

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
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

        private void AddQuote_Load_1(object sender, EventArgs e)
        {
            
        }

        private void CalcWidth_TextChanged(object sender, EventArgs e)
        {
            bool Valid = false;
            int Number;
            while (Valid == false)
            {
                string Input = Convert.ToString(CheckWidth());
                if (int.TryParse(Input, out Number))
                {
                    Valid = true;
                }
                else
                {
                    MessageBox.Show("Not an integer, please try again.");
                }
            }
        }
        public double CheckWidth()
        {
            double width = Convert.ToDouble(calcWidth.Text);
            if (width * 12 > MAX_WIDTH || width * 12 < MIN_WIDTH)
            {
                throw new System.InvalidOperationException("The Desk Width must be between 4 and 8 feet");
            }
            else
            {
                Desk gswidth = new Desk();
                gswidth.Width = (width * 12);
                return width;
            }
        }
        
        private void CalcWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr !=13)
            {
                e.Handled = true;
                MessageBox.Show("Please, enter only numbers, no letters");
            }
        }

        private void CalcDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 13)
            {
                MessageBox.Show("Please, enter only numbers, no letters");
            }
        }

        private void CalcDepth_TextChanged(object sender, EventArgs e)
        {
            bool Valid = false;
            int Number;
            while (Valid == false)
            {
                string Input = Convert.ToString(CheckDepth());
                if (int.TryParse(Input, out Number))
                {
                    Valid = true;
                }
                else
                {
                    MessageBox.Show("Not an integer, please try again.");
                }
            }
        }
        public double CheckDepth()
        {
            double depth = Convert.ToDouble(calcDepth.Text);
            if (depth * 12  > MAX_WIDTH || depth * 12 < MIN_WIDTH)
            {
                throw new System.InvalidOperationException("The Desk Width must be between 4 and 8 feet");
            }
            else
            {
                Desk gsdepth = new Desk();
                gsdepth.Depth = (depth * 12);
                return depth;
            }
        }

        private void SACAnswer_Click(object sender, EventArgs e)
        {
            Desk sac = new Desk();
            Label mylabel = new Label();
            string Answer;
            double Width = sac.Width;
            double Depth = sac.Depth;
            Answer = Convert.ToString((Width * 12) * (Depth * 12));

            mylabel.Text = Answer;
        }

        private void SACAnswer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculateTSA_Click(object sender, EventArgs e)
        {
            double Answer = CheckWidth() * 12 * CheckDepth() * 12;
            string SAnswer = Convert.ToString(Answer);
            SACAnswer.Text = SAnswer;
            TSA.Text = SAnswer;
        }

        private void numOfDrawers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desk nod = new Desk();
            nod.NumOfDrawers = Convert.ToInt32(numOfDrawers.Text);
            int DrawerPrice = nod.NumOfDrawers * 50;
            priceOfDrawers.Text = Convert.ToString(DrawerPrice);
        }

        private void totalPrice_Click(object sender, EventArgs e)
        {
           
        }

        private void TSA_Click(object sender, EventArgs e)
        {

        }

        private void materialSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Material = materialSelection.Text;
            int MaterialPrice = 0;
            
            if (Material == "Oak")
            {
                MaterialPrice = 200;
            }
            else if (Material == "Laminate")
            {
                MaterialPrice = 100;
            }
            else if (Material == "Pine")
            {
                MaterialPrice = 50;
            }
            else if (Material == "Rosewood")
            {
                MaterialPrice = 300;
            }
            else
            {
                MaterialPrice = 125;
            }
            Desk mp = new Desk();
            mp.MaterialPrice = MaterialPrice;
            priceOfMaterials.Text = Convert.ToString(MaterialPrice);
        }

        private void priceOfDrawers_Click(object sender, EventArgs e)
        {

        }

        private void priceOfDrawers_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void priceOfMaterials_Click(object sender, EventArgs e)
        {

        }

        private void materialSelection_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void rushOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int RO = Convert.ToInt32(rushOrder.Text);
            int SoD = Convert.ToInt32(TSA.Text);

            if (RO == 0)
            {
                rushOrderPrice.Text = "0";
            }
            else if (RO == 3 && SoD < 1000)
            {
                rushOrderPrice.Text = "60";
            }
            else if (RO == 3 && SoD > 1000 && SoD < 2000)
            {
                rushOrderPrice.Text = "70";
            }
            else if (RO == 3 && SoD > 2000)
            {
                rushOrderPrice.Text = "80";
            }
            else if (RO == 5 && SoD < 1000)
            {
                rushOrderPrice.Text = "40";
            }
            else if (RO == 5 && SoD > 1000 && SoD < 2000)
            {
                rushOrderPrice.Text = "50";
            }
            else if (RO == 5 && SoD > 2000)
            {
                rushOrderPrice.Text = "60";
            }
            else if (RO == 7 && SoD < 1000)
            {
                rushOrderPrice.Text = "30";
            }
            else if (RO == 7 && SoD > 1000 && SoD < 2000)
            {
                rushOrderPrice.Text = "35";
            }
            else if (RO == 7 && SoD > 2000)
            {
                rushOrderPrice.Text = "40";
            }
        }

        private void findTotalPrice_Click(object sender, EventArgs e)
        {
            Desk FTP = new Desk();
            FTP.Size=Convert.ToInt32(TSA.Text);
            int BasePrice = 200;
            double MaterialPrice = Convert.ToDouble(priceOfMaterials.Text);
            double AreaPrice; 
            int PriceOfDrawers = Convert.ToInt32(priceOfDrawers.Text);
            int DesktopSurfaceArea = Convert.ToInt32(TSA.Text);
            int AdditionalRushCost = Convert.ToInt32(rushOrderPrice.Text);

            if (DesktopSurfaceArea > 1000)
            {
                AreaPrice = DesktopSurfaceArea - 1000;
            }
            else
            {
                AreaPrice = 0;
            }

            double TotalPrice = BasePrice + AreaPrice + PriceOfDrawers + MaterialPrice + AdditionalRushCost;
            totalPrice.Text = Convert.ToString(TotalPrice);
        }
    }
}
