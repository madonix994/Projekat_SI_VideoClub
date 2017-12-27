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
    public partial class MovieRolePage : Form
    {
        //POVEZIVANJE SA BUSINESS LAYER-OM MOVIE I ACTOR
        public BusinessMovieRole businessMovieRole = new BusinessMovieRole();
        public BusinessMovie businessMovie = new BusinessMovie();
        public BusinessActor businessActor = new BusinessActor();


        public MovieRolePage()
        {
            InitializeComponent();

            FillComboBoxMovies();
            FillComboBoxActors();

            FillMovieRoles();

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

        // SPOLJASNJA METODA ZA POPUNJAVANJE COMBOBOX-a SA FILMOVIMA PRILIKOM UCITAVANJA!
        public void FillComboBoxMovies()
        {
            comboBoxMovie.Items.Clear();
            List<Movie> listapom = businessMovie.SelectAllMoviesIdAndName();

            foreach (Movie pom in listapom)
            {
                comboBoxMovie.Items.Add(pom.GetSetMovie_Name1);
            }
        }

        // SPOLJASNJA METODA ZA POPUNJAVANJE COMBOBOX-a SA GLUMCIMA PRILIKOM UCITAVANJA!
        public void FillComboBoxActors()
        {
            comboBoxActor.Items.Clear();
            List<Actor> listapom = businessActor.SelectAllActors();

            foreach (Actor pom in listapom)
            {
                    comboBoxActor.Items.Add(pom.GetSetActor_Name1 + " " + pom.GetSetActor_Surname1);
               
            }
        }


        //SPOLJNA METODA KOJA ISPISUJE SVE PODATKE U LISTU IZ TABELE MovieRoles IZ BAZE
        public void FillMovieRoles()
        {

            listBoxMovieRoles.Items.Clear();

            List<MovieRole_Actor_Movie> listapom = businessMovieRole.SelectAllMovieRoles();

            foreach (MovieRole_Actor_Movie pom in listapom)
            {
                listBoxMovieRoles.Items.Add(pom.GetSetId_Role1 + ". " + pom.GetSetRole_Name1 + " -- " + pom.GetSetActor_Name1 + " " + pom.GetSetActor_Surname1 + " -- " + pom.GetSetMovie_Name1 + " -- " + " -- " + pom.GetSetRole_Description1);
            }
        }

        //SPOLJNA METODA KOJA CISTI SVA Text Box POLJA NAKON UNOSA I IZMENE PODATAKA PRILIKOM KLIKA NA ODGOVARAJUCU DUGMAD
        public void ClearData()
        {
            textBoxMovieRoleName.Text = "";
            textBoxMovieRoleDescription.Text = "";
            comboBoxMovie.Text = "";
            comboBoxActor.Text = "";
            TextBoxHiddenIDActor.Text = "";
            TextBoxHiddenIDMovie.Text = "";
            TextBoxHiddenIDMovieRole.Text = "";
            
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

        /*METODA ZA UNOS ULOGE */
        private void buttonInsertMovieRole_Click(object sender, EventArgs e)
        {
            if (textBoxMovieRoleName.Text != "" && textBoxMovieRoleDescription.Text != "" && comboBoxMovie.Text != "" && comboBoxActor.Text != "")
            {
                List<MovieRole_Actor_Movie> listapom = businessMovieRole.SelectAllMovieRoles();

                /*PRVO PROVERAVA DA LI VEC POSTOJI ULOGA SA TIM IMENOM i GLUMCEM ZA TAJ ODREDJENI FILM,
                UKOLIKO POSTOJI ONDA IZBACUJE OBAVESTENJE I PRAZNI Text Box polja, I SAMIM TIM NE MOZE
                DA SE IZVRSI DALJE KOD, A UKOLIKO NE POSTOJI ONDA IZVRSAVA DALJE KOD*/

                foreach (MovieRole_Actor_Movie pom in listapom)
                {
                    if ((pom.GetSetRole_Name1 == textBoxMovieRoleName.Text || pom.GetSetRole_Name1.ToLower() == textBoxMovieRoleName.Text || pom.GetSetRole_Name1.ToUpper() == textBoxMovieRoleName.Text)
                        && pom.GetSetId_Actor_Actors1 == Convert.ToInt32(TextBoxHiddenIDActor.Text)
                        && pom.GetSetId_Movie_Movies1 == Convert.ToInt32(TextBoxHiddenIDMovie.Text))
                    {
                        ClearData();
                        MessageBox.Show("Uneta uloga vec postoji u bazi!", "Obavestenje");
                    }
                }
                if (textBoxMovieRoleName.Text != "" && textBoxMovieRoleDescription.Text != "" && comboBoxMovie.Text != "" && comboBoxActor.Text != "")
                {
                    MovieRole mr = new MovieRole();

                mr.GetSetRole_Name1 = textBoxMovieRoleName.Text;
                mr.GetSetRole_Description1 = textBoxMovieRoleDescription.Text;
                mr.GetSetId_Movie_Movies1 = Convert.ToInt32(TextBoxHiddenIDMovie.Text);
                mr.GetSetId_Actor_Actors1 = Convert.ToInt32(TextBoxHiddenIDActor.Text);

                businessMovieRole.InsertMovieRole(mr);

                ClearData();

                FillMovieRoles();
                }
                else
                {
                    MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");
                }
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");
            }
        }

        //DUGME ZA IZMENU ULOGE
        private void buttonUpdateMovieRole_Click(object sender, EventArgs e)
        {
            if (textBoxMovieRoleName.Text != "" && textBoxMovieRoleDescription.Text != "" && comboBoxMovie.Text != "" && comboBoxActor.Text != "")
            {
                MovieRole mr = new MovieRole();

                mr.GetSetId_Role1 = Convert.ToInt32(TextBoxHiddenIDMovieRole.Text);


                mr.GetSetRole_Name1 = textBoxMovieRoleName.Text;
                mr.GetSetRole_Description1 = textBoxMovieRoleDescription.Text;

                FillComboBoxMovies();
                FillComboBoxActors();

                mr.GetSetId_Movie_Movies1 = Convert.ToInt32(TextBoxHiddenIDMovie.Text); //ID filma iz textBox-a!!!
                mr.GetSetId_Actor_Actors1 = Convert.ToInt32(TextBoxHiddenIDActor.Text);//ID glumca iz textBox-a!!!

                businessMovieRole.UpdateMovieRole(mr);
                ClearData();
                FillMovieRoles();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");
            }
        }

        //DUGME ZA BRISANJE ULOGE
        private void buttonDeleteMovieRole_Click(object sender, EventArgs e)
        {
            if (TextBoxHiddenIDMovie.Text != "")
            {
                MovieRole mr = new MovieRole();

                mr.GetSetId_Role1 = Convert.ToInt32(TextBoxHiddenIDMovieRole.Text);

                businessMovieRole.DeleteMovieRole(mr);

                mr.GetSetRole_Name1 = "Nije Uneto";
                mr.GetSetRole_Description1 = "Nije Uneto";
                mr.GetSetId_Actor_Actors1 = Convert.ToInt32("1002");
                mr.GetSetId_Movie_Movies1 = Convert.ToInt32(TextBoxHiddenIDMovie.Text);
                businessMovieRole.InsertMovieRole(mr);

                ClearData();
                FillMovieRoles();
            }
            else
            {
                MessageBox.Show("Morate odabrati ULOGU za brisanje!", "Obavestenje");
            }
        }

        // PRETRAGA ULOGA U BAZI
        private void buttonMovieRoleSearch_Click(object sender, EventArgs e)
        {
            
            listBoxMovieRoles.Items.Clear();
            MovieRole mr = new MovieRole();
            string pom1 = textBoxMovieRoleSearch.Text;

            List<MovieRole_Actor_Movie> lista = businessMovieRole.SearchMovieRole(pom1);
            foreach (MovieRole_Actor_Movie pom in lista)
            {
                listBoxMovieRoles.Items.Add(pom.GetSetId_Role1 + ". " + pom.GetSetRole_Name1 + " -- " + pom.GetSetActor_Name1 + " " + pom.GetSetActor_Surname1 + " -- " + pom.GetSetMovie_Name1 + " -- " + " -- " + pom.GetSetRole_Description1);
            }
            
        }


        //PRILIKOM ODABIRA JEDNOG REDA U LISTI SVI PODACI SE POKAZUJU U TextBox POLJA ZA EVENTUALNO DALJE AZURIRANJE
        private void listBoxMovieRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMovieRoles.Text != "")
            {
                string pom;
                pom = listBoxMovieRoles.Text;

                List<MovieRole_Actor_Movie> lista = businessMovieRole.SelectAllMovieRoles().Where(mr => mr.GetSetId_Role1 + ". " + mr.GetSetRole_Name1 + " -- " + mr.GetSetActor_Name1 + " " + mr.GetSetActor_Surname1 + " -- " + mr.GetSetMovie_Name1 + " -- " + " -- " + mr.GetSetRole_Description1 == pom).ToList();

                MovieRole_Actor_Movie movieRole = lista.First();


                TextBoxHiddenIDMovieRole.Text = Convert.ToString(movieRole.GetSetId_Role1);
                TextBoxHiddenIDMovie.Text = Convert.ToString(movieRole.GetSetId_Movie_Movies1);
                TextBoxHiddenIDActor.Text = Convert.ToString(movieRole.GetSetId_Actor_Actors1);

                textBoxMovieRoleName.Text = movieRole.GetSetRole_Name1;
                textBoxMovieRoleDescription.Text = movieRole.GetSetRole_Description1;
                

                comboBoxActor.Text = movieRole.GetSetActor_Name1 + " " + movieRole.GetSetActor_Surname1;
                comboBoxMovie.Text = movieRole.GetSetMovie_Name1;
            }
            else
            {
                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");
            }
        }

        //PRILIKOM KLIKA NA IME ZANRA U Combo Box Movie NJEGOV ID SE SALJE U SKRIVENO POLJE 
        private void comboBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MovieName;
            MovieName = comboBoxMovie.Text;

            List<Movie_Genre_Director> lista = businessMovie.SelectAllMovies().Where(m => m.GetSetMovie_Name1 == MovieName).ToList();

            Movie_Genre_Director mo = lista.First();
            TextBoxHiddenIDMovie.Text = Convert.ToString(mo.GetSetId_Movie1);
        }

        //PRILIKOM KLIKA NA IME ZANRA U Combo Box Actor NJEGOV ID SE SALJE U SKRIVENO POLJE 
        private void comboBoxActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ActorNameAndSurname;
            ActorNameAndSurname = comboBoxActor.Text;

            List<Actor> lista = businessActor.SelectAllActors().Where(a => a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1 == ActorNameAndSurname).ToList();

            Actor ac = lista.First();
            TextBoxHiddenIDActor.Text = Convert.ToString(ac.GetSetId_Actor1);
        }




    }
}
