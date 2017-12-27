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
    public partial class UserCardPage : Form
    {
        public UserCardPage()
        {
            InitializeComponent();



            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        private void buttonUserCardSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUserCardSearch, "Pretrazi Korisnika.");
        }

        private void buttonInsertUserCard_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertUserCard, "Unesite novog Korisnika.");
        }

        private void buttonUpdateUserCard_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateUserCard, "Izmenite podatke o Korisniku.");
        }

        private void buttonDeleteUserCard_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteUserCard, "Brisanje Korisnika.");
        }

        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;
        public int Variable4 = 1;
        private void FocusLeaveName(object sender, EventArgs e)
        {
                        
            if (textBoxUserCardName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }
             
            }

        }

        private void FocusLeaveSurname(object sender, EventArgs e)
        {
            if (textBoxUserCardSurname.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void FocusLeaveAddress(object sender, EventArgs e)
        {
            if (textBoxUserCardAddress.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }

        private void FocusLeavePhone(object sender, EventArgs e)
        {
            if (textBoxUserCardPhoneNumber.Text != "")
            {
                if (Variable4 == 1)
                {
                    progressBar1.PerformStep();

                    Variable4++;
                }

            }
        }

        private void buttonInsertUserCard_Click(object sender, EventArgs e)
        {
            if (textBoxUserCardName.Text != "" && textBoxUserCardSurname.Text != "" && textBoxUserCardAddress.Text != "" && textBoxUserCardPhoneNumber.Text != "")
            {
                //OVDE IDE KOD INSERT


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonUpdateUserCard_Click(object sender, EventArgs e)
        {
            if (textBoxUserCardName.Text != "" && textBoxUserCardSurname.Text != "" && textBoxUserCardAddress.Text != "" && textBoxUserCardPhoneNumber.Text != "")
            {
                //OVDE IDE KOD UPDATE


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonDeleteUserCard_Click(object sender, EventArgs e)
        {
            //OVDE IDE KOD DELETE
        }

        private void buttonUserCardSearch_Click(object sender, EventArgs e)
        {
            if (textBoxUserCardSearch.Text != "")
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
