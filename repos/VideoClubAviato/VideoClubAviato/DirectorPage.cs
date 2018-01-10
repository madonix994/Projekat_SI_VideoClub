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
using System.Text.RegularExpressions;
using DataLayer;

namespace VideoClubAviato
{
    public partial class DirectorPage : Form
    {
        //POVEZIVANJE SA BUSINESS LAYER-OM ACTOR I MOVIE ROLE
        private BusinessDirector businessDirector;

        private BusinessMovie businessMovie;



        public DirectorPage()
        {
            InitializeComponent();

            IMovieRepository movieRepository = new MovieRepository();
            this.businessMovie = new BusinessMovie(movieRepository);

            IDirectorRepository directorRepository = new DirectorRepository();
            this.businessDirector = new BusinessDirector(directorRepository);

            FillDirectors();

            checkBoxDirectorOscar.BackColor = Color.Transparent;
            pictureBoxHelp.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            label1.Text = "(Ukoliko je stiklirano, pretraga ce\nprikazati SAMO rezisere sa Oskarima)";
            label1.BackColor = Color.Transparent;
            
        }

        //SPOLJNA METODA KOJA ISPISUJE SVE PODATKE U LISTU IZ TABELE Directors IZ BAZE
        public void FillDirectors()
        {
            listBoxDirectors.Items.Clear();
            List<Director> lista = businessDirector.SelectAllDirectors();
            foreach (Director pom in lista)
            {
                if (pom.GetSetDirector_Name1 == "Nije" && pom.GetSetDirector_Surname1 == "Uneto")
                {

                }

                else
                {
                    listBoxDirectors.Items.Add("Reziser: " + pom.GetSetDirector_Name1 + " " + pom.GetSetDirector_Surname1 + "  -- Datum Rodjenja: " + pom.GetSetDirector_Date_Of_Birth1);
                }

            }

        }

        //SPOLJNA METODA KOJA CISTI SVA Text Box POLJA NAKON UNOSA I IZMENE PODATAKA PRILIKOM KLIKA NA ODGOVARAJUCU DUGMAD
        public void ClearData()
        {
            textBoxDirectorName.Text = "";
            textBoxDirectorSurname.Text = "";
            textBoxDirectorDateOfBirth.Text = "";
            checkBoxDirectorOscar.Checked = false;
            TextBoxHiddenIDDirector.Text = "";
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

        //DUGME ZA PRETRAGU REZISERA
        private void buttonDirectorSearch_Click(object sender, EventArgs e)
        {
            listBoxDirectors.Items.Clear();
            Director d = new Director();
            string pom1 = textBoxDirectorSearch.Text;

            if (checkBoxDirectorOscar.Checked)
            {
                List<Director> lista = businessDirector.SearchDirectorByOscar(pom1);
                foreach (Director pom in lista)
                {

                    if (pom.GetSetDirector_Name1 == "Nije" && pom.GetSetDirector_Surname1 == "Uneto") { }
                    else
                    {
                        listBoxDirectors.Items.Add("Reziser: " + pom.GetSetDirector_Name1 + " " + pom.GetSetDirector_Surname1 + "  -- Datum Rodjenja: " + pom.GetSetDirector_Date_Of_Birth1);
                    }
                    ClearData();
                    checkBoxDirectorOscar.Checked = true;
                }
            }
            else
            {
                List<Director> lista = businessDirector.SearchDirector(pom1);
                foreach (Director pom in lista)
                {
                    if (pom.GetSetDirector_Name1 == "Nije" && pom.GetSetDirector_Surname1 == "Uneto") { }
                    else
                    {
                        listBoxDirectors.Items.Add("Reziser: " + pom.GetSetDirector_Name1 + " " + pom.GetSetDirector_Surname1 + "  -- Datum Rodjenja: " + pom.GetSetDirector_Date_Of_Birth1);
                    }
                    ClearData();
                  
                }
            }

        }

        //PRILIKOM KLIKA NA DUGME VRSI SE UNOS REZISERA U BAZU !
        private void buttonInsertDirector_Click(object sender, EventArgs e)
        {
            DateTime dt;
            if (Regex.IsMatch(textBoxDirectorName.Text, @"[a-zA-Z]") && Regex.IsMatch(textBoxDirectorSurname.Text, @"[a-zA-Z]") && DateTime.TryParse(textBoxDirectorDateOfBirth.Text, out dt))
            {
                /*PRVO PROVERAVA DA LI VEC POSTOJI REZISER SA TIM IMENOM, PREZIMENOM i DATUMOM RODJENJA,
                UKOLIKO POSTOJI ONDA IZBACUJE OBAVESTENJE I PRAZNI Text Box polja, I SAMIM TIM NE MOZE
                DA SE IZVRSI DALJE KOD, A UKOLIKO NE POSTOJI ONDA IZVRSAVA DALJE KOD*/

                List<Director> lista = businessDirector.SelectAllDirectors();
                foreach (Director pom in lista)
                {
                    if ((pom.GetSetDirector_Name1 == textBoxDirectorName.Text || pom.GetSetDirector_Name1.ToLower() == textBoxDirectorName.Text || pom.GetSetDirector_Name1.ToUpper() == textBoxDirectorName.Text)
                           && (pom.GetSetDirector_Surname1 == textBoxDirectorSurname.Text || pom.GetSetDirector_Surname1.ToLower() == textBoxDirectorSurname.Text || pom.GetSetDirector_Surname1.ToUpper() == textBoxDirectorSurname.Text)
                           && pom.GetSetDirector_Date_Of_Birth1 == Convert.ToDateTime(textBoxDirectorDateOfBirth.Text))
                    {
                        ClearData();
                        MessageBox.Show("Uneti reziser vec postoji u bazi!", "Obavestenje");
                    }
                }
                if (textBoxDirectorName.Text != "" && textBoxDirectorSurname.Text != "" && textBoxDirectorDateOfBirth.Text != "")
                {

                    Director d = new Director();
                d.GetSetDirector_Name1 = textBoxDirectorName.Text;
                d.GetSetDirector_Surname1 = textBoxDirectorSurname.Text;
                d.GetSetDirector_Date_Of_Birth1 = Convert.ToDateTime(textBoxDirectorDateOfBirth.Text); //.GetDateTimeFormats("");
                d.GetSetDirector_Oscar1 = checkBoxDirectorOscar.Checked;

                businessDirector.InsertDirector(d);
                FillDirectors();
                    }
                else
                {

                    MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");

                }
            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");

            }
        }

        //PRILIKOM KLIKA NA DUGME VRSI SE AZURIRANJE FILMA U BAZI
        private void buttonUpdateDirector_Click(object sender, EventArgs e)
        {
            DateTime dt;
            if (Regex.IsMatch(textBoxDirectorName.Text, @"[a-zA-Z]") && Regex.IsMatch(textBoxDirectorSurname.Text, @"[a-zA-Z]") && DateTime.TryParse(textBoxDirectorDateOfBirth.Text, out dt))
            {
                Director d = new Director();

                d.GetSetId_Director1 = Convert.ToInt32(TextBoxHiddenIDDirector.Text);
                d.GetSetDirector_Name1 = textBoxDirectorName.Text;
                d.GetSetDirector_Surname1 = textBoxDirectorSurname.Text;
                d.GetSetDirector_Date_Of_Birth1 = Convert.ToDateTime(textBoxDirectorDateOfBirth.Text);
                d.GetSetDirector_Oscar1 = checkBoxDirectorOscar.Checked;

                businessDirector.UpdateDirector(d);
                ClearData();
                FillDirectors();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");
            }
        }


        /*SPOLJNA METODA ZA TABELU FILMOVI --> AZURIRANJE REZISERA U FILMU KOJE SE OBAVLJA NAKON
         * BRISANJA JEDNOG SPECIFICNOG REZISERA*/

        public void UpdateDirectorOnMovie()
        {
            Movie m = new Movie();

            m.GetSetId_Director_Directors1 = Convert.ToInt32(TextBoxHiddenIDDirector.Text); //ID zanra iz textBox-a!!!

            businessMovie.UpdateDirectorOnMovie(m);

        }

        //DUGME ZA BRISANJE REZISERA IZ BAZE
        private void buttonDeleteDirector_Click(object sender, EventArgs e)
        {
            if (TextBoxHiddenIDDirector.Text != "")
            {
                Director d = new Director();

                d.GetSetId_Director1 = Convert.ToInt32(TextBoxHiddenIDDirector.Text);


                UpdateDirectorOnMovie();
                businessDirector.DeleteDirector(d);

                ClearData();
                FillDirectors();
            }
            else
            {
                MessageBox.Show("Morate odabrati REZISERA za brisanje!", "Obavestenje");
            }
        }

        //PRILIKOM ODABIRA JEDNOG REDA U LISTI SVI PODACI SE POKAZUJU U TextBox POLJA ZA EVENTUALNO DALJE AZURIRANJE
        private void listBoxDirectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDirectors.Text != "")
            {
                string pom;
                pom = listBoxDirectors.Text;

                List<Director> lista = businessDirector.SelectAllDirectors().Where(d => "Reziser: " + d.GetSetDirector_Name1 + " " + d.GetSetDirector_Surname1 + "  -- Datum Rodjenja: " + d.GetSetDirector_Date_Of_Birth1 == pom).ToList();

                Director director = lista.First();

                TextBoxHiddenIDDirector.Text = Convert.ToString(director.GetSetId_Director1);

                textBoxDirectorName.Text = director.GetSetDirector_Name1;
                textBoxDirectorSurname.Text = director.GetSetDirector_Surname1;
                textBoxDirectorDateOfBirth.Text = Convert.ToString(director.GetSetDirector_Date_Of_Birth1);
                checkBoxDirectorOscar.Checked = director.GetSetDirector_Oscar1;
            }
            else
            {
                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");
            }
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", Uri.EscapeDataString("C:\\Users\\madon\\Documents\\Projekat_SI_VideoClub\\repos\\VideoClubAviato\\VideoClubAviato\\HELP HTML\\Director.html"));

        }

        private void pictureBoxHelp_MouseHover(object sender, EventArgs e)
        {
            pictureBoxHelp.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxHelp, "Prikaz pomocne dokumentacije.");
        }
    }
}
