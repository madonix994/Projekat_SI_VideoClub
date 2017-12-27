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
    public partial class MovieRolePage : Form
    {
        public MovieRolePage()
        {
            InitializeComponent();


            this.comboBoxActor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMovie.DropDownStyle = ComboBoxStyle.DropDownList;
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


        private void buttonInsertMovieRole_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertMovieRole, "Unesite novu Ulogu.");
        }

        private void buttonUpdateMovieRole_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateMovieRole, "Izmenite podatke o Ulozi.");
        }

        private void buttonDeleteMovieRole_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteMovieRole, "Brisanje Uloge.");
        }

        private void buttonMovieRoleSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteMovieRole, "Pretrazi Ulogu.");
        }

        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;
        public int Variable4 = 1;

        private void textBoxMovieRoleName_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieRoleName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }
        }

        private void textBoxMovieRoleDescription_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieRoleDescription.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }


        private void comboBoxMovie_Leave(object sender, EventArgs e)
        {
            if (comboBoxMovie.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }

        private void comboBoxActor_Leave(object sender, EventArgs e)
        {
            if (comboBoxActor.Text != "")
            {
                if (Variable4 == 1)
                {
                    progressBar1.PerformStep();

                    Variable4++;
                }

            }
        }
        private void buttonInsertMovieRole_Click(object sender, EventArgs e)
        {
            if (textBoxMovieRoleName.Text != "" && textBoxMovieRoleDescription.Text != "" && comboBoxMovie.Text != "" && comboBoxActor.Text != "")
            {
                //OVDE IDE KOD INSERT


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }
        private void buttonUpdateMovieRole_Click(object sender, EventArgs e)
        {
            if (textBoxMovieRoleName.Text != "" && textBoxMovieRoleDescription.Text != "" && comboBoxMovie.Text != "" && comboBoxActor.Text != "")
            {
                //OVDE IDE KOD UPDATE


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        private void buttonDeleteMovieRole_Click(object sender, EventArgs e)
        {
            //OVDE IDE KOD DELETE
        }


        private void buttonMovieRoleSearch_Click(object sender, EventArgs e)
        {
            if (textBoxMovieRoleSearch.Text != "")
            {
                //OVDE IDE KOD PRETRAGU


            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }

            
        }

       
    }
}
