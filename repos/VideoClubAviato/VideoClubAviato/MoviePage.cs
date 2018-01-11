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
    public partial class MoviePage : Form
    {
        //POVEZIVANJE SA BUSINESS LAYER-OM MOVIE I MOVIE ROLE
        private BusinessMovie businessMovie;
        


        private BusinessMovieRole businessMovieRole;
        
        private BusinessGenre businessGenre;


        private BusinessDirector businessDirector;


        public MoviePage()
        {
            InitializeComponent();

            IMovieRoleRepository movieRoleRepository = new MovieRoleRepository();
            this.businessMovieRole = new BusinessMovieRole(movieRoleRepository);


            IMovieRepository movieRepository = new MovieRepository();
            this.businessMovie = new BusinessMovie(movieRepository);


            IDirectorRepository directorRepository = new DirectorRepository();
            this.businessDirector = new BusinessDirector(directorRepository);

            IGenreRepository genreRepository = new GenreRepository();
            this.businessGenre = new BusinessGenre(genreRepository);

            this.comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDirectors.DropDownStyle = ComboBoxStyle.DropDownList;

            FillComboBoxGenres();

            FillComboBoxDirectors();

            listBoxMovies.Items.Clear();

            List<Movie_Genre_Director_MovieRole_Actor> listMovies = businessMovie.SelectAllMoviesAllClasses();


            foreach (Movie_Genre_Director_MovieRole_Actor variable in listMovies)
            {
                if (variable.GetSetMovie_Amount1 == 0)
                {
                    Movie movieM = new Movie();
                    movieM.GetSetId_Movie1 = variable.GetSetId_Movie1;

                    businessMovie.UpdateMovieStatus(movieM);

                    FillMovies();

                }
                else
                {
                    Movie movieM1 = new Movie();
                    movieM1.GetSetId_Movie1 = variable.GetSetId_Movie1;
                    businessMovie.UpdateMovieStatus2(movieM1);

                    FillMovies();

                }
            }
               

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
            pictureBoxHelp.BackColor = Color.Transparent;
            checkBoxMovieOscar.BackColor = Color.Transparent;
        }

        //SPOLJNA METODA KOJA POPUNJAVA SVE PODATKE U COMBO BOX(Genres) IZ TABELE Genres IZ BAZE
        public void FillComboBoxGenres()
        {
            comboBoxGenre.Items.Clear();
            List<Genre> listGenres = businessGenre.SelectAllGenres();

            foreach (Genre variable in listGenres)
            {            
                    comboBoxGenre.Items.Add(variable.GetSetGenre_Name1);
                        
            }
        }

        //SPOLJNA METODA KOJA POPUNJAVA SVE PODATKE U COMBO BOX(Directors) IZ TABELE Directors IZ BAZE
        public void FillComboBoxDirectors()
        {
            comboBoxDirectors.Items.Clear();
            List<Director> listDirectors = businessDirector.SelectAllDirectors();

            foreach (Director variable in listDirectors)
            {              
                    comboBoxDirectors.Items.Add(variable.GetSetDirector_Name1 + " " + variable.GetSetDirector_Surname1);

            }
        }

        //SPOLJNA METODA KOJA ISPISUJE SVE PODATKE U LISTU IZ TABELE Movies IZ BAZE
        public void FillMovies()
        {
            listBoxMovies.Items.Clear();
            List<Movie_Genre_Director_MovieRole_Actor> listMovies = businessMovie.SelectAllMoviesAllClasses();

            
            foreach (Movie_Genre_Director_MovieRole_Actor variable in listMovies)
            {
                listBoxMovies.Items.Add("Film: " +variable.GetSetMovie_Name1 + " -- Godina: " + variable.GetSetMovie_Year1 + " -- Status: " + variable.GetSetMovie_Status1 + " -- Kolicina:  " + variable.GetSetMovie_Amount1 + " -- Cena: " + variable.GetSetMovie_Rental_Price1 + " -- Zanr: " + variable.GetSetGenre_Name1 + " -- Reziser: " + variable.GetSetDirector_Name1 + " " + variable.GetSetDirector_Surname1 + " -- Glumci: " + variable.GetSetActor_Surname1 + " -- Trajanje: " + variable.GetSetMovie_Duration1 + " -- Ocena: " + variable.GetSetMovie_IMDB_Rating1);
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
            int movieYear;
            double movieDuration;
            double movieRating;
            int movieAmount;
            double moviePrice;
            string movieStatus = "Na Stanju";

            if (Regex.IsMatch(textBoxMovieName.Text, @"[a-zA-Z]") && Regex.IsMatch(comboBoxGenre.Text, @"[a-zA-Z]") && Regex.IsMatch(comboBoxDirectors.Text, @"[a-zA-Z]") && Int32.TryParse(textBoxMovieYear.Text, out movieYear) && Double.TryParse(textBoxMovieDuration.Text, out movieDuration) && Double.TryParse(textBoxMovieIMDBRating.Text, out movieRating) && textBoxMovieStatus.Text.Equals(movieStatus) && Int32.TryParse(textBoxMovieAmount.Text, out movieAmount) && Double.TryParse(textBoxMovieRentalPrice.Text, out moviePrice))
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

                MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");
                textBoxMovieStatus.Text = "Na Stanju";
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
                ClearData();
                MessageBox.Show("Morate odabrati FILM za brisanje!", "Obavestenje");
            }

        }

        // PRETRAGA FILMOVA U BAZI
        private void buttonMovieSearch_Click(object sender, EventArgs e)
        {
            listBoxMovies.Items.Clear();
            Movie m = new Movie();
            string variable1 = textBoxMovieSearch.Text;

            // PRETRAGA FILMOVA U BAZI  AKO FILM IMA OSKARA
            if (checkBoxMovieOscar.Checked == true)
            {
                List<Movie_Genre_Director_MovieRole_Actor> listMovies = businessMovie.SearchMovieOscar(variable1);

                    foreach (Movie_Genre_Director_MovieRole_Actor variable in listMovies)
                    {
                        listBoxMovies.Items.Add("Film: " + variable.GetSetMovie_Name1 + " -- Godina: " + variable.GetSetMovie_Year1 + " -- Status: " + variable.GetSetMovie_Status1 + " -- Kolicina:  " + variable.GetSetMovie_Amount1 + " -- Cena: " + variable.GetSetMovie_Rental_Price1 + " -- Zanr: " + variable.GetSetGenre_Name1 + " -- Reziser: " + variable.GetSetDirector_Name1 + " " + variable.GetSetDirector_Surname1 + " -- Glumci: " + variable.GetSetActor_Surname1 + " -- Trajanje: " + variable.GetSetMovie_Duration1 + " -- Ocena: " + variable.GetSetMovie_IMDB_Rating1);
                    }
                ClearData();
                comboBoxDirectors.Items.Clear();
                FillComboBoxDirectors();
                comboBoxGenre.Items.Clear();
                FillComboBoxGenres();
                checkBoxMovieOscar.Checked = true;
            }
            else
            {                    // PRETRAGA FILMOVA U BAZI BEZ FILTRIRANJA OSKARA

                List<Movie_Genre_Director_MovieRole_Actor> listMovies = businessMovie.SearchMovie(variable1);
                foreach (Movie_Genre_Director_MovieRole_Actor variable in listMovies)
                {
                    listBoxMovies.Items.Add("Film: " + variable.GetSetMovie_Name1 + " -- Godina: " + variable.GetSetMovie_Year1 + " -- Status: " + variable.GetSetMovie_Status1 + " -- Kolicina:  " + variable.GetSetMovie_Amount1 + " -- Cena: " + variable.GetSetMovie_Rental_Price1 + " -- Zanr: " + variable.GetSetGenre_Name1 + " -- Reziser: " + variable.GetSetDirector_Name1 + " " + variable.GetSetDirector_Surname1 + " -- Glumci: " + variable.GetSetActor_Surname1 + " -- Trajanje: " + variable.GetSetMovie_Duration1 + " -- Ocena: " + variable.GetSetMovie_IMDB_Rating1);
                }
                ClearData();
                comboBoxDirectors.Items.Clear();
                FillComboBoxDirectors();
                comboBoxGenre.Items.Clear();
                FillComboBoxGenres();
            }
        }

        /*METODA ZA UNOS FILMA A TAKODJE PRILIKOM UNOSA FILMA ISTOVREMENO VRSI UNOS ULOGE ZA TAJ FILM U TABELI ULOGE,
        GDE SETUJE IME ULOGE NA "Nije Uneto" i POVEZUJE SA GLUMCEM "Nije Uneto" 
        (potrebno radi lancane reakcije nesto kao triger) */    
        private void buttonInsertMovie_Click(object sender, EventArgs e)
        {
            int movieYear;
            double movieDuration;
            double movieRating;
            int movieAmount;
            double moviePrice;
            string movieStatus = "Na Stanju";

            if (Regex.IsMatch(textBoxMovieName.Text, @"[a-zA-Z]") && Regex.IsMatch(comboBoxGenre.Text, @"[a-zA-Z]") && Regex.IsMatch(comboBoxDirectors.Text, @"[a-zA-Z]") && Int32.TryParse(textBoxMovieYear.Text, out movieYear) && Double.TryParse(textBoxMovieDuration.Text, out movieDuration) && Double.TryParse(textBoxMovieIMDBRating.Text, out movieRating) && textBoxMovieStatus.Text.Equals(movieStatus) && Int32.TryParse(textBoxMovieAmount.Text, out movieAmount) && Double.TryParse(textBoxMovieRentalPrice.Text, out moviePrice))
            {
                List<Movie_Genre_Director> listMovies = businessMovie.SelectAllMovies();

                /*PRVO PROVERAVA DA LI VEC POSTOJI FILM SA TIM NAZIVOM OD TOG REZISERA IZ TE GODINE,
                UKOLIKO POSTOJI ONDA IZBACUJE OBAVESTENJE I PRAZNI Text Box polja, I SAMIM TIM NE MOZE
                DA SE IZVRSI DALJE KOD, A UKOLIKO NE POSTOJI ONDA IZVRSAVA DALJE KOD*/

                foreach (Movie_Genre_Director variable in listMovies)
                {
                    if ((variable.GetSetMovie_Name1 == textBoxMovieName.Text || variable.GetSetMovie_Name1.ToLower() == textBoxMovieName.Text || variable.GetSetMovie_Name1.ToUpper() == textBoxMovieName.Text)
                     && variable.GetSetId_Director1 == Convert.ToInt32(TextBoxHiddenIDDirector.Text) && variable.GetSetMovie_Year1 == Convert.ToInt32(textBoxMovieYear.Text))
                    {
                        ClearData();

                        comboBoxDirectors.Items.Clear();

                        FillComboBoxDirectors();

                        comboBoxGenre.Items.Clear();

                        FillComboBoxGenres();

                        MessageBox.Show("Uneti film vec postoji u bazi!", "Obavestenje");

                        
                    }
                }

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

                    List<Movie_Genre_Director> listMovies1 = businessMovie.SelectAllMovies();
                    Movie_Genre_Director movie = listMovies1.Last();

                    MovieRole mr = new MovieRole();
                    mr.GetSetRole_Name1 = "Nije Uneto";
                    mr.GetSetRole_Description1 = "Nije Uneto";
                    mr.GetSetId_Actor_Actors1 = Convert.ToInt32("2");
                    mr.GetSetId_Movie_Movies1 = movie.GetSetId_Movie1;
                    businessMovieRole.InsertMovieRole(mr);
                    ClearData();

                    FillMovies();
                    comboBoxDirectors.Items.Clear();
                    FillComboBoxDirectors();
                    comboBoxGenre.Items.Clear();
                    FillComboBoxGenres();
                }
                else
                {
                    MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");
                }
            }
            else
            {
                textBoxMovieStatus.Text = "Na Stanju";

                MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");
            }

        }

        //PRILIKOM ODABIRA JEDNOG REDA U LISTI SVI PODACI SE POKAZUJU U TextBox POLJA ZA EVENTUALNO DALJE AZURIRANJE
        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMovies.Text != "")
            {
                string variable;
                variable = listBoxMovies.Text;

                List<Movie_Genre_Director_MovieRole_Actor> listMovies = businessMovie.SelectAllMoviesAllClasses().Where(m => "Film: " + m.GetSetMovie_Name1 + " -- Godina: " + m.GetSetMovie_Year1 + " -- Status: " + m.GetSetMovie_Status1 + " -- Kolicina:  " + m.GetSetMovie_Amount1 + " -- Cena: " + m.GetSetMovie_Rental_Price1 + " -- Zanr: " + m.GetSetGenre_Name1 + " -- Reziser: " + m.GetSetDirector_Name1 + " " + m.GetSetDirector_Surname1 + " -- Glumci: " + m.GetSetActor_Surname1 + " -- Trajanje: " + m.GetSetMovie_Duration1 + " -- Ocena: " + m.GetSetMovie_IMDB_Rating1 == variable).ToList();

                Movie_Genre_Director_MovieRole_Actor movie = listMovies.First();

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

            List<Genre> listGenres = businessGenre.SelectAllGenres().Where(m => m.GetSetGenre_Name1 == GenreName).ToList();

            Genre g = listGenres.First();
            TextBoxHiddenIDGenre.Text = Convert.ToString(g.GetSetId_Genre1);
        }

        //PRILIKOM KLIKA NA IME REZISERA U Combo Box Director NJEGOV ID SE SALJE U SKRIVENO POLJE 
        private void comboBoxDirectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DirectorNameAndSurname;
            DirectorNameAndSurname = comboBoxDirectors.Text;

            List<Director> listDirectors = businessDirector.SelectAllDirectors().Where(m => m.GetSetDirector_Name1 + " " + m.GetSetDirector_Surname1 == DirectorNameAndSurname).ToList();

            Director d = listDirectors.First();
            TextBoxHiddenIDDirector.Text = Convert.ToString(d.GetSetId_Director1);
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", Uri.EscapeDataString("C:\\Users\\madon\\Documents\\Projekat_SI_VideoClub\\repos\\VideoClubAviato\\VideoClubAviato\\HELP HTML\\Movie.html"));

        }

        private void pictureBoxHelp_MouseHover(object sender, EventArgs e)
        {
            pictureBoxHelp.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxHelp, "Prikaz pomocne dokumentacije.");

        }
    }
}
