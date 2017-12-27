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
    public partial class GenrePage : Form
    {
        public GenrePage()
        {
            InitializeComponent();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;









        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        private void MouseHoverInsertGenre(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertGenre, "Unesite novi Zanr.");

        }

        private void MouseHoverUpdateGenre(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateDirector, "Izmenite podatke o Zanru.");

        }

        private void MouseHoverDeleteGenre(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteGenre, "Brisanje Zanra.");

        }
        private void buttonGenreSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonGenreSearch, "Pretrazi Zanr.");

        }

        private void buttonGenreSave_Click(object sender, EventArgs e)
        {
            if (textBoxGenreName.Text != "")
            {
                //OVDE IDE KOD DJUSKOOO


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        public int Variable = 1;
        private void textBoxGenreName_Leave(object sender, EventArgs e)
        {
            if (textBoxGenreName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }

        }

        private void buttonInsertGenre_Click(object sender, EventArgs e)
        {
            if (textBoxGenreName.Text != "")
            {
                //OVDE IDE KOD ZA INSERT


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }




        }

        private void buttonUpdateDirector_Click(object sender, EventArgs e)
        {
            if (textBoxGenreName.Text != "")
            {
                //OVDE IDE KOD ZA UPDATE


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonDeleteGenre_Click(object sender, EventArgs e)
        {
            //OVDE IDE KOD ZA DELETE

        }

        private void buttonGenreSearch_Click(object sender, EventArgs e)
        {
            //OVDE IDE KOD ZA PRETRAGU

        }
    }
}
