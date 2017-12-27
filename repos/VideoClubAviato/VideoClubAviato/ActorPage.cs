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
    public partial class ActorPage : Form
    {
        public ActorPage()
        {
            InitializeComponent();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            checkBoxActorOscar.BackColor = Color.Transparent;
            label3.Text = "(Ukoliko je stiklirano, pretraga ce\nprikazati SAMO glumce sa Oskarima)";
            label3.BackColor = Color.Transparent;




        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        private void buttonActorSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonActorSearch, "Pretrazite Glumca.");
        }

        private void MouseHoverInsertActor(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertActor, "Unesite novog Glumca.");
        }

        private void MouseHoverUpdateActor(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateActor, "Izmenite podatke o Glumcu.");
        }

        private void MouseHoverDeleteActor(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteActor, "Brisanje Glumca.");
        }

       
        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;

        private void FocusLeaveActorName(object sender, EventArgs e)
        {
            if (textBoxActorName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }
        }

        private void FocusLeaveActorSurname(object sender, EventArgs e)
        {
            if (textBoxActorSurname.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void FocusLeaveActorDate(object sender, EventArgs e)
        {
            if (textBoxActorDateOfBirth.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }
        private void buttonInsertActor_Click(object sender, EventArgs e)
        {
            if (textBoxActorName.Text != "" && textBoxActorSurname.Text != "" && textBoxActorDateOfBirth.Text != "")
            {
                //OVDE IDE KOD ZA INSERT


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }
        private void buttonUpdateActor_Click(object sender, EventArgs e)
        {
            if (textBoxActorName.Text != "" && textBoxActorSurname.Text != "" && textBoxActorDateOfBirth.Text != "")
            {
                //OVDE IDE KOD ZA UPDATE


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
           
        }

        private void buttonDeleteActor_Click(object sender, EventArgs e)
        {
            //OVDE IDE KOD ZA DELETE
        }

        private void buttonActorSearch_Click(object sender, EventArgs e)
        {
            if (textBoxArctorSearch.Text != "")
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
