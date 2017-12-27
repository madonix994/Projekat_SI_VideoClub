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
        //POVEZIVANJE SA BUSINESS LAYER-OM MOVIE I MOVIE ROLE
        private BusinessMovie businessMovie = new BusinessMovie();
        private BusinessMovieRole businessMovieRole = new BusinessMovieRole();
        public BusinessGenre businessGenre = new BusinessGenre();
        public BusinessDirector businessDirector = new BusinessDirector();

        public MoviePage()
        {
            InitializeComponent();

            FillComboBoxGenres();

            FillComboBoxDirectors();

            FillMovies();

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

        //SPOLJNA METODA KOJA POPUNJAVA SVE PODATKE U COMBO BOX(Genres) IZ TABELE Genres IZ BAZE
        public void FillComboBoxGenres()
        {
            comboBoxGenre.Items.Clear();
            List<Genre> listapom = businessGenre.SelectAllGenres();

            foreach (Genre pom in listapom)
            {            
                    comboBoxGenre.Items.Add(pom.GetSetGenre_Name1);
                        
            }
        }

        //SPOLJNA METODA KOJA POPUNJAVA SVE PODATKE U COMBO BOX(Directors) IZ TABELE Directors IZ BAZE
        public void FillComboBoxDirectors()
        {
            comboBoxDirectors.Items.Clear();
            List<Director> listapom = businessDirector.SelectAllDirectors();

            foreach (Director pom in listapom)
            {              
                    comboBoxDirectors.Items.Add(pom.GetSetDirector_Name1 + " " + pom.GetSetDirector_Surname1);

            }
        }

        //SPOLJNA METODA KOJA ISPISUJE SVE PODATKE U LISTU IZ TABELE Movies IZ BAZE
        public void FillMovies()
        {
            listBoxMovies.Items.Clear();
            List<Movie_Genre_Director_MovieRole_Actor> lista = businessMovie.SelectAllMoviesAllClasses();
            foreach (Movie_Genre_Director_MovieRole_Actor pom in lista)
            {
                listBoxMovies.Items.Add(pom.GetSetId_Movie1 + ". " + pom.GetSetMovie_Name1 + " " + pom.GetSetMovie_Year1 + "  --  " + Convert.ToDouble(pom.GetSetMovie_Duration1) + "  --  " + pom.GetSetMovie_Status1 + "  --  " + pom.GetSetMovie_Amount1 + "  --  " + pom.GetSetMovie_Rental_Price1 + "  --  " + pom.GetSetGenre_Name1 + "  --  " + pom.GetSetDirector_Name1 + "  --  " + pom.GetSetDirector_Surname1);
            }
        }

        //SPOLJNA METODA KOJA CISTI SVA Text Box POLJA NAKON UNOSA I IZMENE PODATAKA PRILIKOM KLIKA NA ODGOVARAJUCU DUGMAD
        public void ClearData()
        {
            comboBoxDirectors.Text = "";
            comboBoxGenre.Text = "";
            textBoxMovieName.Text = "";
            textBoxMovieYear.Text = "";
            textBoxMovieDuration.Text = "";
            checkBoxMovieOscar.Checked = false;
            textBoxMovieIMDBRating.Text = "";
            textBoxMovieStatus.Text = "";
            textBoxMovieAmount.Text = "";
            textBoxMovieRentalPrice.Text = "";
            TextBoxHiddenIDGenre.Text = "";
            TextBoxHiddenIDDirector.Text = "";
            TextBoxHiddenIDMovie.Text = "";
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

        //PRILIKOM KLIKA NA DUGME VRSI SE AZURIRANJE FILMA U BAZI
        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            if (textBoxMovieName.Text != "" && comboBoxGenre.Text != "" && comboBoxDirectors.Text != "" && textBoxMovieYear.Text != "" && textBoxMovieDuration.Text != "" && textBoxMovieIMDBRating.Text != "" && textBoxMovieStatus.Text != "" && textBoxMovieAmount.Text != "" && textBoxMovieRentalPrice.Text != "")
            {
                Movie m = new Movie();

                m.GetSetId_Movie1 = Convert.ToInt32(TextBoxHiddenIDMovie.Text);
                m.GetSetMovie_Name1 = textBoxMovieName.Text;
                m.GetSetMovie_Year1 = Convert.ToInt32(textBoxMovieYear.Text);
                m.GetSetMovie_Duration1 = Convert.ToDouble(textBoxMovieDuration.Text);
                m.GetSetMovie_Oskar1 = checkBoxMovieOscar.Checked;
                m.GetSetMovie_IMDB_Rating1 = Convert.ToDouble(textBoxMovieIMDBRating.Text);
                m.GetSetMovie_Status1 = textBoxMovieStatus.Text;
                m.GetSetMovie_Amount1 = Convert.ToInt32(textBoxMovieAmount.Text);
                m.GetSetMovie_Rental_Price1 = Convert.ToDouble(textBoxMovieRentalPrice.Text);

                FillComboBoxGenres();
                FillComboBoxDirectors();

                m.GetSetId_Genre_Genres1 = Convert.ToInt32(TextBoxHiddenIDGenre.Text); //ID zanra iz textBox-a!!!
                m.GetSetId_Director_Directors1 = Convert.ToInt32(TextBoxHiddenIDDirector.Text);//ID rezisera iz textBox-a!!!

                businessMovie.UpdateMovie(m);
                ClearData();
                FillMovies();

            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        /*PRILIKOM KLIKA NA DUGME VRSI SE BRISANJE FILMA IZ BAZE A 
          ISTOVREMENO SE VRSI BRISANJE ULOGE U TABELI FILMOVI  (potrebno radi lancane reakcije nesto kao triger)*/
        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            if (TextBoxHiddenIDMovie.Text != "")
            {
                Movie m = new Movie();

                m.GetSetId_Movie1 = Convert.ToInt32(TextBoxHiddenIDMovie.Text);

                FillComboBoxGenres();
                FillComboBoxDirectors();

                businessMovieRole.DeleteMovieRoleOnMovies(m);
                businessMovie.DeleteMovie(m);

                ClearData();
                FillMovies();
            }
            else
            {
                MessageBox.Show("Morate odabrati FILM za brisanje!", "Obavestenje");
            }

        }

        // PRETRAGA FILMOVA U BAZI
        private void buttonMovieSearch_Click(object sender, EventArgs e)
        {
            listBoxMovies.Items.Clear();
            Movie m = new Movie();
            string pom1 = textBoxMovieSearch.Text;

            // PRETRAGA FILMOVA U BAZI  AKO FILM IMA OSKARA
            if (checkBoxMovieOscar.Checked == true)
            {
                List<Movie_Genre_Director_MovieRole_Actor> lista = businessMovie.SearchMovieOscar(pom1);
                foreach (Movie_Genre_Director_MovieRole_Actor pom in lista)
                {
                    listBoxMovies.Items.Add(pom.GetSetId_Movie1 + ". " + pom.GetSetMovie_Name1 + " " + pom.GetSetMovie_Year1 + "  --  " + Convert.ToDouble(pom.GetSetMovie_Duration1) + "  --  " + pom.GetSetMovie_Status1 + "  --  " + pom.GetSetMovie_Amount1 + "  --  " + pom.GetSetMovie_Rental_Price1 + "  --  " + pom.GetSetGenre_Name1 + "  --  " + pom.GetSetDirector_Name1 + "  --  " + pom.GetSetDirector_Surname1);
                }
            }
            else
            {                    // PRETRAGA FILMOVA U BAZI BEZ FILTRIRANJA OSKARA

                List<Movie_Genre_Director_MovieRole_Actor> lista = businessMovie.SearchMovie(pom1);
                foreach (Movie_Genre_Director_MovieRole_Actor pom in lista)
                {
                    listBoxMovies.Items.Add(pom.GetSetId_Movie1 + ". " + pom.GetSetMovie_Name1 + " " + pom.GetSetMovie_Year1 + "  --  " + Convert.ToDouble(pom.GetSetMovie_Duration1) + "  --  " + pom.GetSetMovie_Status1 + "  --  " + pom.GetSetMovie_Amount1 + "  --  " + pom.GetSetMovie_Rental_Price1 + "  --  " + pom.GetSetGenre_Name1 + "  --  " + pom.GetSetDirector_Name1 + "  --  " + pom.GetSetDirector_Surname1);
                }
            }
        }

        /*METODA ZA UNOS FILMA A TAKODJE PRILIKOM UNOSA FILMA ISTOVREMENO VRSI UNOS ULOGE ZA TAJ FILM U TABELI ULOGE,
        GDE SETUJE IME ULOGE NA "Nije Uneto" i POVEZUJE SA GLUMCEM "Nije Uneto" 
        (potrebno radi lancane reakcije nesto kao triger) */    
        private void buttonInsertMovie_Click(object sender, EventArgs e)
        {
            if (textBoxMovieName.Text != "" && comboBoxGenre.Text != "" && comboBoxDirectors.Text != "" && textBoxMovieYear.Text != "" && textBoxMovieDuration.Text != "" && textBoxMovieIMDBRating.Text != "" && textBoxMovieStatus.Text != "" && textBoxMovieAmount.Text != "" && textBoxMovieRentalPrice.Text != "")
            {

                Movie m = new Movie();

                m.GetSetMovie_Name1 = textBoxMovieName.Text;
                m.GetSetMovie_Year1 = Convert.ToInt32(textBoxMovieYear.Text);
                m.GetSetMovie_Duration1 = Convert.ToDouble(textBoxMovieDuration.Text);
                m.GetSetMovie_Oskar1 = checkBoxMovieOscar.Checked;
                m.GetSetMovie_IMDB_Rating1 = Convert.ToDouble(textBoxMovieIMDBRating.Text);
                m.GetSetMovie_Status1 = textBoxMovieStatus.Text;
                m.GetSetMovie_Amount1 = Convert.ToInt32(textBoxMovieAmount.Text);
                m.GetSetMovie_Rental_Price1 = Convert.ToDouble(textBoxMovieRentalPrice.Text);

                m.GetSetId_Genre_Genres1 = Convert.ToInt32(TextBoxHiddenIDGenre.Text); //ID zanra iz textBox-a!!!
                m.GetSetId_Director_Directors1 = Convert.ToInt32(TextBoxHiddenIDDirector.Text);//ID rezisera iz textBox-a!!!

                businessMovie.InsertMovie(m);

                List<Movie_Genre_Director> lista = businessMovie.SelectAllMovies();
                Movie_Genre_Director movie = lista.Last();

                MovieRole mr = new MovieRole();
                mr.GetSetRole_Name1 = "Nije Uneto";
                mr.GetSetRole_Description1 = "Nije Uneto";
                mr.GetSetId_Actor_Actors1 = Convert.ToInt32("2003");
                mr.GetSetId_Movie_Movies1 = movie.GetSetId_Movie1;
                businessMovieRole.InsertMovieRole(mr);

                ClearData();

                FillMovies();

            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        //PRILIKOM ODABIRA JEDNOG REDA U LISTI SVI PODACI SE POKAZUJU U TextBox POLJA ZA EVENTUALNO DALJE AZURIRANJE
        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMovies.Text != "")
            {
                string pom;
                pom = listBoxMovies.Text;

                List<Movie_Genre_Director_MovieRole_Actor> lista = businessMovie.SelectAllMoviesAllClasses().Where(m => m.GetSetId_Movie1 + ". " + m.GetSetMovie_Name1 + " " + m.GetSetMovie_Year1 + "  --  " + Convert.ToDouble(m.GetSetMovie_Duration1) + "  --  " + m.GetSetMovie_Status1 + "  --  " + m.GetSetMovie_Amount1 + "  --  " + m.GetSetMovie_Rental_Price1 + "  --  " + m.GetSetGenre_Name1 + "  --  " + m.GetSetDirector_Name1 + "  --  " + m.GetSetDirector_Surname1 == pom).ToList();

                Movie_Genre_Director_MovieRole_Actor movie = lista.First();

                TextBoxHiddenIDMovie.Text = Convert.ToString(movie.GetSetId_Movie1);

                textBoxMovieName.Text = movie.GetSetMovie_Name1;
                textBoxMovieYear.Text = Convert.ToString(movie.GetSetMovie_Year1);
                textBoxMovieDuration.Text = Convert.ToString(movie.GetSetMovie_Duration1);
                checkBoxMovieOscar.Checked = movie.GetSetMovie_Oskar1;
                textBoxMovieIMDBRating.Text = Convert.ToString(movie.GetSetMovie_IMDB_Rating1);
                textBoxMovieStatus.Text = movie.GetSetMovie_Status1;
                textBoxMovieAmount.Text = Convert.ToString(movie.GetSetMovie_Amount1);
                textBoxMovieRentalPrice.Text = Convert.ToString(movie.GetSetMovie_Rental_Price1);
                comboBoxDirectors.Text = movie.GetSetDirector_Name1 + " " + movie.GetSetDirector_Surname1;
                comboBoxGenre.Text = movie.GetSetGenre_Name1;
                TextBoxHiddenIDDirector.Text = Convert.ToString(movie.GetSetId_Director_Directors1);
                TextBoxHiddenIDGenre.Text = Convert.ToString(movie.GetSetId_Genre_Genres1);
            }
            else
            {
                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");

            }
        }

        //PRILIKOM KLIKA NA IME ZANRA U Combo Box Genre NJEGOV ID SE SALJE U SKRIVENO POLJE 
        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GenreName;
            GenreName = comboBoxGenre.Text;

            List<Genre> lista = businessGenre.SelectAllGenres().Where(m => m.GetSetGenre_Name1 == GenreName).ToList();

            Genre mgd = lista.First();
            TextBoxHiddenIDGenre.Text = Convert.ToString(mgd.GetSetId_Genre1);
        }

        //PRILIKOM KLIKA NA IME REZISERA U Combo Box Director NJEGOV ID SE SALJE U SKRIVENO POLJE 
        private void comboBoxDirectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DirectorNameAndSurname;
            DirectorNameAndSurname = comboBoxDirectors.Text;

            List<Director> lista = businessDirector.SelectAllDirectors().Where(m => m.GetSetDirector_Name1 + " " + m.GetSetDirector_Surname1 == DirectorNameAndSurname).ToList();

            Director mgd = lista.First();
            TextBoxHiddenIDDirector.Text = Convert.ToString(mgd.GetSetId_Director1);
        }
    }
}
