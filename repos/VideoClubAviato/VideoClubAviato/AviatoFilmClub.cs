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
    public partial class AviatoFilmClub : Form
    {
        public AviatoFilmClub()
        {
            InitializeComponent();

            pictureBox3.BackColor = Color.Transparent;
            

            textBoxUsername.Text = "Korisnicko ime";
            textBoxPassword.Text = "Lozinka";

        }

        private BusinessEmployee businessEmployee = new BusinessEmployee();

        public int brojpokusaja = 1;

        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            

           Employee pom = this.businessEmployee.Login();

            if (brojpokusaja <= 5)
            {
                if (pom.GetSetEmployee_Username1 == textBoxUsername.Text && pom.GetSetEmployee_Password1 == textBoxPassword.Text)
                {

                    this.Hide();

                    MainPage mainPage = new MainPage();

                    mainPage.ShowDialog();

                }
                else
                {
                    
                    MessageBox.Show("Uneli ste pogresne podatke!\nImate jos " + (5 - brojpokusaja) + " pokusaja.", "Obavestenje");
                    brojpokusaja++;

                }
            }
            else
            {
                this.Close();
            }
        }

        private new void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonLogin.PerformClick(); 
            }
        }
            
        private void InFocusUsername(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.LightGreen;

            if (textBoxUsername.Text == "Korisnicko ime")
            {
                textBoxUsername.Text = "";
            }


        }

        private void OutFocusUsername(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;

            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Korisnicko ime";
            }

        }


        private void InFocusPassword(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.LightGreen;
            textBoxPassword.PasswordChar = '*';

            if (textBoxPassword.Text == "Lozinka")
            {
                textBoxPassword.Text = "";
                
            }


        }

        private void OutFocusPassword(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
            

            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Lozinka";
                
            }

        }

        private void MouseHoverUsername(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(textBoxUsername, "Unesite Korisnicko ime.");
        }

        private void MouseHoverPassword(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(textBoxPassword, "Unesite Lozinku.");
        }

        private void MouseHoverLogin(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonLogin, "Prijavite se.");
        }

        
    }
}
