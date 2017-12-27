using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClubAviato
{
    public partial class RentalPage : Form
    {
        public RentalPage()
        {
            InitializeComponent();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            Printer.BackColor = Color.Transparent;



            this.comboBoxMovieName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxUserCardName.DropDownStyle = ComboBoxStyle.DropDownList;
            DateTime localDate = DateTime.Now;
            textBoxDateOfRental.Text = Convert.ToString(localDate);

        }


        private void buttonInsertRental_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertRental, "Unesite novu Rezervaciju.");
        }

        private void buttonUpdateRental_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateRental, "Izmenite podatke o Rezervaciji.");
        }

        private void buttonRentalSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonRentalSearch, "Pretrazite Rezervaciju.");
        }


        private void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(b, 0, 0);
            
        }
        Bitmap b;

        private void Printer_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            b = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(b);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            Preview.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;

        private void comboBoxUserCardName_Leave(object sender, EventArgs e)
        {
            if (comboBoxUserCardName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }
        }

        private void comboBoxMovieName_Leave(object sender, EventArgs e)
        {
            if (comboBoxMovieName.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void textBoxDateOfRental_Leave(object sender, EventArgs e)
        {
            if (textBoxDateOfRental.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }

        private void buttonInsertRental_Click(object sender, EventArgs e)
        {
            if (comboBoxMovieName.Text != "" && comboBoxUserCardName.Text != "" && textBoxDateOfRental.Text != "")
            {
                //OVDE IDE KOD ZA INSERT


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonUpdateRental_Click(object sender, EventArgs e)
        {
            if (comboBoxMovieName.Text != "" && comboBoxUserCardName.Text != "" && textBoxDateOfRental.Text != "")
            {
                //OVDE IDE KOD ZA UPDATE


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonRentalSearch_Click(object sender, EventArgs e)
        {
            if (textBoxRentalSearch.Text != "")
            {
                //OVDE IDE KOD ZA PRETRAGU


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        
    }
}
