using BusinessLayer;
using DataLayer.Models;
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
    public partial class MoviePage : Form
    {
        private BusinessMovie businessMovie = new BusinessMovie();


        public MoviePage()
        {
            InitializeComponent();

            label3.Text = "(Ukoliko je stiklirano, pretraga ce\nprikazati SAMO filmove sa Oskarima)";
            label3.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            checkBoxMovieOscar.BackColor = Color.Transparent;













        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        private void Movie_Load(object sender, EventArgs e)
        {

        }

        private void MouseHoverInsertMovie(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertMovie, "Unesite novi Film.");

        }

        private void MouseHoverUpdateMovie(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateMovie, "Izmenite podatke o Filmu.");

        }

        private void MouseHoverDeleteMovie(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteMovie, "Brisanje Filma.");

        }
        private void buttonMovieSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonMovieSearch, "Pretrazi Film.");
        }

        
        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;
        public int Variable4 = 1;
        public int Variable5 = 1;
        public int Variable6 = 1;
        public int Variable7 = 1;
        public int Variable8 = 1;
        public int Variable9 = 1;

        private void textBoxMovieName_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }
        }

        private void comboBoxGenre_Leave(object sender, EventArgs e)
        {
            if (comboBoxGenre.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void comboBoxDirectors_Leave(object sender, EventArgs e)
        {
            if (comboBoxDirectors.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }

        private void textBoxMovieYear_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieYear.Text != "")
            {
                if (Variable4 == 1)
                {
                    progressBar1.PerformStep();

                    Variable4++;
                }

            }
        }

        private void textBoxMovieDuration_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieDuration.Text != "")
            {
                if (Variable5 == 1)
                {
                    progressBar1.PerformStep();

                    Variable5++;
                }

            }
        }

        private void textBoxMovieIMDBRating_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieIMDBRating.Text != "")
            {
                if (Variable6 == 1)
                {
                    progressBar1.PerformStep();

                    Variable6++;
                }

            }
        }

        private void textBoxMovieStatus_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieStatus.Text != "")
            {
                if (Variable7 == 1)
                {
                    progressBar1.PerformStep();

                    Variable7++;
                }

            }
        }

        private void textBoxMovieAmount_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieAmount.Text != "")
            {
                if (Variable8 == 1)
                {
                    progressBar1.PerformStep();

                    Variable8++;
                }

            }
        }

        private void textBoxMovieRentalPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieRentalPrice.Text != "")
            {
                if (Variable9 == 1)
                {
                    progressBar1.PerformStep();

                    Variable9++;
                }

            }
        }
 
        

        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            if (textBoxMovieName.Text != "" && comboBoxGenre.Text != "" && comboBoxDirectors.Text != "" && textBoxMovieYear.Text != "" && textBoxMovieDuration.Text != "" && textBoxMovieIMDBRating.Text != "" && textBoxMovieStatus.Text != "" && textBoxMovieAmount.Text != "" && textBoxMovieRentalPrice.Text != "")
            {
                //OVDE IDE KOD ZA UPDATE


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            //OVDE IDE KOD ZA DELETE

        }

        private void buttonMovieSearch_Click(object sender, EventArgs e)
        {
            if (textBoxMovieSearch.Text != "")
            {
                //OVDE IDE KOD ZA PRETRAGU


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonInsertMovie_Click(object sender, EventArgs e)
        {
            if (textBoxMovieName.Text != "" && comboBoxGenre.Text != "" && comboBoxDirectors.Text != "" && textBoxMovieYear.Text != "" && textBoxMovieDuration.Text != "" && textBoxMovieIMDBRating.Text != "" && textBoxMovieStatus.Text != "" && textBoxMovieAmount.Text != "" && textBoxMovieRentalPrice.Text != "")
            {
                //OVDE IDE KOD INSERT


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

    }
}
