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

namespace VideoClubAviato
{
    public partial class ActorPage : Form
    {
        //POVEZIVANJE SA BUSINESS LAYER-OM ACTOR I MOVIE ROLE
        public BusinessActor businessActor = new BusinessActor();
        public BusinessMovieRole businessMovieRole = new BusinessMovieRole();

        public ActorPage()
        {
            InitializeComponent();

            FillActors();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            checkBoxActorOscar.BackColor = Color.Transparent;
            pictureBoxHelp.BackColor = Color.Transparent;
            label3.Text = "(Ukoliko je stiklirano, pretraga ce\nprikazati SAMO glumce sa Oskarima)";
            label3.BackColor = Color.Transparent;   

        }

        //SPOLJNA METODA KOJA ISPISUJE SVE PODATKE U LISTU IZ TABELE Actors IZ BAZE
        public void FillActors()
        {
            listBoxActors.Items.Clear();
            List<Actor> lista = businessActor.SelectAllActors();
            foreach (Actor pom in lista)
            {
                if (pom.GetSetActor_Name1 == "Nije" && pom.GetSetActor_Surname1 == "Uneto") { }
                else
                {
                    listBoxActors.Items.Add("Glumac: " + pom.GetSetActor_Name1 + " " + pom.GetSetActor_Surname1 + "  -- Datum Rodjenja: " + pom.GetSetActor_Date_Of_Birth1);
                }
            }
        }

        //SPOLJNA METODA KOJA CISTI SVA Text Box POLJA NAKON UNOSA I IZMENE PODATAKA PRILIKOM KLIKA NA ODGOVARAJUCU DUGMAD
        public void ClearData()
        {
            TextBoxHiddenIDActor.Text = "";
            textBoxActorName.Text = "";
            textBoxActorSurname.Text = "";
            textBoxActorDateOfBirth.Text = "";
            checkBoxActorOscar.Checked = false;
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

        //PRILIKOM KLIKA NA DUGME VRSI SE UNOS GLUMCA U BAZU !
        private void buttonInsertActor_Click(object sender, EventArgs e)
        {
            DateTime dt;

            if (Regex.IsMatch(textBoxActorName.Text, @"[a-zA-Z]") && Regex.IsMatch(textBoxActorSurname.Text, @"[a-zA-Z]") && DateTime.TryParse(textBoxActorDateOfBirth.Text, out dt))
            {

                /*PRVO PROVERAVA DA LI VEC POSTOJI GLUMAC SA TIM IMENOM, PREZIMENOM i DATUMOM RODJENJA,
                UKOLIKO POSTOJI ONDA IZBACUJE OBAVESTENJE I PRAZNI Text Box polja, I SAMIM TIM NE MOZE
                DA SE IZVRSI DALJE KOD, A UKOLIKO NE POSTOJI ONDA IZVRSAVA DALJE KOD*/
                List<Actor> lista = businessActor.SelectAllActors();
                foreach (Actor pom in lista)
                {
                    if ((pom.GetSetActor_Name1 == textBoxActorName.Text || pom.GetSetActor_Name1.ToLower() == textBoxActorName.Text || pom.GetSetActor_Name1.ToUpper() == textBoxActorName.Text)
                        && (pom.GetSetActor_Surname1 == textBoxActorSurname.Text || pom.GetSetActor_Surname1.ToLower() == textBoxActorSurname.Text || pom.GetSetActor_Surname1.ToUpper() == textBoxActorSurname.Text)
                        && pom.GetSetActor_Date_Of_Birth1 == Convert.ToDateTime(textBoxActorDateOfBirth.Text))
                    {
                        ClearData();
                        MessageBox.Show("Uneti glumac vec postoji u bazi!", "Obavestenje");
                    }
                }
                if (textBoxActorName.Text != "" && textBoxActorSurname.Text != "" && textBoxActorDateOfBirth.Text != "")
                {
                    Actor a = new Actor();
                    a.GetSetActor_Name1 = textBoxActorName.Text;
                    a.GetSetActor_Surname1 = textBoxActorSurname.Text;
                    a.GetSetActor_Date_Of_Birth1 = Convert.ToDateTime(textBoxActorDateOfBirth.Text); //.GetDateTimeFormats("");
                    a.GetSetActor_Oscar1 = checkBoxActorOscar.Checked;

                    businessActor.InsertActor(a);

                    FillActors();
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

        //PRILIKOM KLIKA NA DUGME VRSI SE AZURIRANJE GLUMCA U BAZI
        private void buttonUpdateActor_Click(object sender, EventArgs e)
        {
            DateTime dt;

            if (Regex.IsMatch(textBoxActorName.Text, @"[a-zA-Z]") && Regex.IsMatch(textBoxActorSurname.Text, @"[a-zA-Z]") && DateTime.TryParse(textBoxActorDateOfBirth.Text, out dt))
            {
                Actor a = new Actor();

                a.GetSetId_Actor1 = Convert.ToInt32(TextBoxHiddenIDActor.Text);
                a.GetSetActor_Name1 = textBoxActorName.Text;
                a.GetSetActor_Surname1 = textBoxActorSurname.Text;
                a.GetSetActor_Date_Of_Birth1 = Convert.ToDateTime(textBoxActorDateOfBirth.Text);
                a.GetSetActor_Oscar1 = checkBoxActorOscar.Checked;

                businessActor.UpdateActor(a);
                ClearData();
                FillActors();

            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");

            }
           
        }

        /*PRILIKOM KLIKA NA DUGME VRSI SE BRISANJE GLUMCA IZ BAZE A 
          ISTOVREMENO SE VRSI AZURIRANJE GLUMCA U TABELI ULOGE */
        private void buttonDeleteActor_Click(object sender, EventArgs e)
        {
            if (TextBoxHiddenIDActor.Text != "")
            {
                Actor a = new Actor();

                a.GetSetId_Actor1 = Convert.ToInt32(TextBoxHiddenIDActor.Text);

                MovieRole mr = new MovieRole();
                mr.GetSetId_Actor_Actors1 = Convert.ToInt32(TextBoxHiddenIDActor.Text);

                businessMovieRole.UpdateActorOnMovieRole(mr);
                businessActor.DeleteActor(a);

                ClearData();
                FillActors();
            }
            else
            {
                MessageBox.Show("Morate odabrati GLUMCA za brisanje!", "Obavestenje");
            }
        }

        // PRETRAGA GLUMACA U BAZI
        private void buttonActorSearch_Click(object sender, EventArgs e)
        {            
                listBoxActors.Items.Clear();
                string pom1 = textBoxActorSearch.Text;

                // PRETRAGA GLUMACA U BAZI  AKO IMA OSKARA
                if (checkBoxActorOscar.Checked)
                {
                    List<Actor> lista = businessActor.SearchActorsbyOscar(pom1);
                    foreach (Actor pom in lista)
                    {
                    if (pom.GetSetActor_Name1 == "Nije" && pom.GetSetActor_Surname1 == "Uneto") { }
                    else
                    {
                        listBoxActors.Items.Add("Glumac: " + pom.GetSetActor_Name1 + " " + pom.GetSetActor_Surname1 + "  -- Datum Rodjenja: " + pom.GetSetActor_Date_Of_Birth1);
                    }
                }
                }
                else
                {
                    // PRETRAGA GLUMACA U BAZI BEZ FILTRIRANJA OSKARA
                    List<Actor> lista = businessActor.SearchActors(pom1);
                    foreach (Actor pom in lista)
                    {
                    if (pom.GetSetActor_Name1 == "Nije" && pom.GetSetActor_Surname1 == "Uneto") { }
                    else
                    {
                        listBoxActors.Items.Add("Glumac: " + pom.GetSetActor_Name1 + " " + pom.GetSetActor_Surname1 + "  -- Datum Rodjenja: " + pom.GetSetActor_Date_Of_Birth1);
                    }
                }
                }
          
        }

        //PRILIKOM ODABIRA JEDNOG REDA U LISTI SVI PODACI SE POKAZUJU U TextBox POLJA ZA EVENTUALNO DALJE AZURIRANJE
        private void listBoxActors_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxActors.Text != "")
            {
                string pom;
                pom = listBoxActors.Text;

                List<Actor> lista = businessActor.SelectAllActors().Where(a => "Glumac: " + a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1 + "  -- Datum Rodjenja: " + a.GetSetActor_Date_Of_Birth1 == pom).ToList();
                Actor actor = lista.First();

                TextBoxHiddenIDActor.Text = Convert.ToString(actor.GetSetId_Actor1);

                textBoxActorName.Text = actor.GetSetActor_Name1;
                textBoxActorSurname.Text = actor.GetSetActor_Surname1;
                textBoxActorDateOfBirth.Text = Convert.ToString(actor.GetSetActor_Date_Of_Birth1);
                checkBoxActorOscar.Checked = actor.GetSetActor_Oscar1;
            }
            else
            {

                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");

            }
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            
                System.Diagnostics.Process.Start("Chrome", Uri.EscapeDataString("C:\\Users\\madon\\Desktop\\Projekat_SI_VideoClub - Sve Spojeno\\repos\\VideoClubAviato\\VideoClubAviato\\HELP HTML\\Actor.html"));
          
        }

        private void pictureBoxHelp_MouseHover(object sender, EventArgs e)
        {

            pictureBoxHelp.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxHelp, "Prikaz pomocne dokumentacije.");


        }
    }
}
