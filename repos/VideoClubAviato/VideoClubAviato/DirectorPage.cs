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
    public partial class DirectorPage : Form
    {
        public DirectorPage()
        {
            InitializeComponent();


            checkBoxDirectorOscar.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            label1.Text = "(Ukoliko je stiklirano, pretraga ce\nprikazati SAMO rezisere sa Oskarima)";
            label1.BackColor = Color.Transparent;







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        private void MouseHoverInsertDirector(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertDirector, "Unesite novog Rezisera.");
        }

        private void MouseHoverUpdateDirector(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateDirector, "Izmenite podatke o Reziseru.");

        }

        private void MouseHoverDeleteDirector(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteDirector, "Brisanje Rezisera.");

        }
        private void buttonDirectorSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDirectorSearch, "Pretrazi Rezisera.");
        }


        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;
        private void FocusLeaveDirectorName(object sender, EventArgs e)
        {
            if (textBoxDirectorName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }
        }

        private void textBoxDirectorSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxDirectorSurname.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void textBoxDirectorDateOfBirth_Leave(object sender, EventArgs e)
        {
            if (textBoxDirectorDateOfBirth.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }

        private void buttonDirectorSearch_Click(object sender, EventArgs e)
        {
            if (textBoxDirectorSearch.Text != "")
            {
                //OVDE IDE KOD ZA PRETRAGU


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }

        }


        private void buttonInsertDirector_Click(object sender, EventArgs e)
        {
            if (textBoxDirectorName.Text != "" && textBoxDirectorSurname.Text != "" && textBoxDirectorDateOfBirth.Text != "")
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
            if (textBoxDirectorName.Text != "" && textBoxDirectorSurname.Text != "" && textBoxDirectorDateOfBirth.Text != "")
            {
                //OVDE IDE KOD ZA UPDATE


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonDeleteDirector_Click(object sender, EventArgs e)
        {
            //OVDE IDE KOD ZA DELETE
        }
    }
}
