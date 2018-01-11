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
    public partial class RentalPage : Form
    {
        //POVEZIVANJE SA BUSINESS LAYER-OM MOVIE I MOVIE ROLE
        private BusinessUserCard businessUserCard;
        
        private BusinessRental businessRental;

        private BusinessMovie businessMovie;

        private BusinessRentalStorage businessRentalStorage;



        private BusinessMovieRental businessMovieRental;


        public RentalPage()
        {
            InitializeComponent();

            IMovieRentalRepository movieRentalRepository = new MovieRentalRepository();
            this.businessMovieRental = new BusinessMovieRental(movieRentalRepository);

            IRentalStorageRepository rentalStorageRepository = new RentalStorageRepository();
            this.businessRentalStorage = new BusinessRentalStorage(rentalStorageRepository);

            IUserCardRepository userCardRepository = new UserCardRepository();
            this.businessUserCard = new BusinessUserCard(userCardRepository);

            IRentalRepository rentalRepository = new RentalRepository();
            this.businessRental = new BusinessRental(rentalRepository);

            IMovieRepository movieRepository = new MovieRepository();
            this.businessMovie = new BusinessMovie(movieRepository);


            FillComboBoxUserCards();

            FillComboBoxMovies();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBoxHelp.BackColor = Color.Transparent;
            pictureBoxAddMovie2.BackColor = Color.Transparent;
            pictureBoxRemoveMovie2.BackColor = Color.Transparent;
            Printer.BackColor = Color.Transparent;



            this.comboBoxMovieName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMovieName2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxUserCardName.DropDownStyle = ComboBoxStyle.DropDownList;
            DateTime localDate = DateTime.Now;
            textBoxDateOfRental.Text = Convert.ToString(localDate);

            FillRentals();


        }


        // ISPIS SVIH PODATAKA REZERVACIJI U LISTU!!!
        public void FillRentals() {
            listBoxRentals.Items.Clear();
            List<RentalStorage> listRentalStorages = businessRentalStorage.SelectAllRentalStorages();
            foreach (RentalStorage variable in listRentalStorages)
            {
                listBoxRentals.Items.Add("Korisnik: " + variable.GetSetUserCard_Name1 + " " + variable.GetSetUserCard_Surname1 + "  -- Adresa: " + variable.GetSetUserCard_Address1 + "  -- Telefon: " + variable.GetSetUserCard_Phone_Number1 + "  -- Iznajmljeni Filmovi: " + variable.GetSetMovie_Name1 + "  -- Ukupna Cena: " + variable.GetSetTotal_Price1 + "  -- Datum Uzimanja: " + variable.GetSetRental_Date_Of_Take1);
            }
        }

        //SPOLJNA METODA KOJA POPUNJAVA SVE PODATKE U COMBO BOX(UserCards) IZ TABELE UserCards IZ BAZE
        public void FillComboBoxUserCards()
        {
            comboBoxUserCardName.Items.Clear();
            List<UserCard> listUserCards = businessUserCard.SelectAllUsers();

            foreach (UserCard variable in listUserCards)
            {
                comboBoxUserCardName.Items.Add(variable.GetSetUserCard_Name_Of_User1 + " " + variable.GetSetUserCard_Surname_Of_User1);

            }
        }

        //SPOLJNA METODA KOJA POPUNJAVA SVE PODATKE U COMBO BOX(Movies) IZ TABELE Movies IZ BAZE
        public void FillComboBoxMovies()
        {
            comboBoxMovieName.Items.Clear();
            List<Movie> listMovies = businessMovie.SelectAllMoviesIdAndNameAndAmount();

            foreach (Movie variable in listMovies)
            {
                if(variable.GetSetMovie_Amount1 > 0)
                {
                    comboBoxMovieName.Items.Add(variable.GetSetMovie_Name1);
                    comboBoxMovieName2.Items.Add(variable.GetSetMovie_Name1);

                }

                
            }
        }


        private void buttonInsertRental_MouseHover(object sender, EventArgs e)
        {
            buttonInsertRental.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertRental, "Unesite novu Rezervaciju.");
        }


        private void buttonRentalSearch_MouseHover(object sender, EventArgs e)
        {
            buttonRentalSearch.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonRentalSearch, "Pretrazite Rezervaciju.");
        }


        private void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(b, 0, 0);
            
        }
        Bitmap b;

        private void Printer_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            b = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(b);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            Preview.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;

        private void comboBoxUserCardName_Leave(object sender, EventArgs e)
        {
            if (comboBoxUserCardName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }
        }

        private void comboBoxMovieName_Leave(object sender, EventArgs e)
        {
            if (comboBoxMovieName.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void textBoxDateOfRental_Leave(object sender, EventArgs e)
        {
            if (textBoxDateOfRental.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }

        public List<string> listVariable = new List<string>();

        

        private void buttonInsertRental_Click(object sender, EventArgs e)
        {

            DateTime dt;

            if (Regex.IsMatch(comboBoxMovieName.Text, @"[a-zA-Z]") && Regex.IsMatch(comboBoxUserCardName.Text, @"[a-zA-Z]") && DateTime.TryParse(textBoxDateOfRental.Text, out dt))
            {
                Rental r = new Rental();
                Rental r2 = new Rental();
                MovieRental mRental = new MovieRental();
                RentalStorage rStorage = new RentalStorage();
                
                r.GetSetId_UserCard_UserCards1 = Convert.ToInt32(TextBoxHiddenIDUserCard.Text);
                r.GetSetRental_Date_Of_Take1 = Convert.ToDateTime(textBoxDateOfRental.Text);

                businessRental.InsertRental(r);

                List<Rental> listRentals = businessRental.SelectAllRentals();
                
                r2 = listRentals.Last();
                
                listVariable.Add(Convert.ToString(TextBoxHiddenIDMovie.Text));
                if (comboBoxMovieName2.Visible == true)
                {
                    listVariable.Add(Convert.ToString(TextBoxHiddenIDMovie2.Text));
                }


                int Id_Rental = r2.GetSetId_Rental1;
                
                foreach (string variable in listVariable) {
                    mRental.Id_Rental_Rentals1 = Id_Rental;
                    mRental.Id_Movie_Movies1 = Convert.ToInt32(variable);

                    List<Movie_Genre_Director> listMovies = businessMovie.SelectAllMovies().Where(m => m.GetSetId_Movie1 == mRental.Id_Movie_Movies1).ToList();
                    Movie_Genre_Director variable2 = listMovies.First();

                    int movieAmount = variable2.GetSetMovie_Amount1;

                    movieAmount--;

                    Movie movie = new Movie();
                    movie.GetSetId_Movie1 = mRental.Id_Movie_Movies1;
                    movie.GetSetMovie_Amount1 = movieAmount;

                    businessMovieRental.InsertMovieRental(mRental);
                    businessMovie.UpdateMovieAmountMinus(movie);



                    List<UserCard> listUserCards = businessUserCard.SelectAllUsers().Where(u => u.GetSetId_UserCard1 == Convert.ToInt32(TextBoxHiddenIDUserCard.Text)).ToList();
                    UserCard user = listUserCards.First();

                    rStorage.GetSetMovie_Name1 = variable2.GetSetMovie_Name1;
                    rStorage.GetSetUserCard_Name1 = user.GetSetUserCard_Name_Of_User1;
                    rStorage.GetSetUserCard_Surname1 = user.GetSetUserCard_Surname_Of_User1;
                    rStorage.GetSetUserCard_Address1 = user.GetSetUserCard_Address_Of_User1;
                    rStorage.GetSetUserCard_Phone_Number1 = user.GetSetUserCard_PhoneNumber_Of_User1;
                    rStorage.GetSetRental_Date_Of_Take1 = Convert.ToDateTime(textBoxDateOfRental.Text);
                    rStorage.GetSetRental_Date_Of_Return1 = "Nije Vraceno";
                    rStorage.GetSetTotal_Price1 = variable2.GetSetMovie_Rental_Price1;

                    businessRentalStorage.InsertRentalStorage(rStorage);

                    FillRentals();
                }

            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja na pravi nacin!", "Obavestenje");

            }
        }
        

        private void buttonRentalSearch_Click(object sender, EventArgs e)
        {
            listBoxRentals.Items.Clear();
            RentalStorage rst = new RentalStorage();
            string RentalSearch = textBoxRentalSearch.Text;

            List<RentalStorage> listRentalStorages = businessRentalStorage.SearchRentalStorage(RentalSearch);
            foreach (RentalStorage variable in listRentalStorages)
            {
                listBoxRentals.Items.Add("Korisnik: " + variable.GetSetUserCard_Name1 + " " + variable.GetSetUserCard_Surname1 + "  -- Adresa: " + variable.GetSetUserCard_Address1 + "  -- Telefon: " + variable.GetSetUserCard_Phone_Number1 + "  -- Iznajmljeni Filmovi: " + variable.GetSetMovie_Name1 + "  -- Ukupna Cena: " + variable.GetSetTotal_Price1 + "  -- Datum Uzimanja: " + variable.GetSetRental_Date_Of_Take1);
            }

        }

        private void comboBoxUserCardName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string UserCardName;
            UserCardName = comboBoxUserCardName.Text;

            
            List<UserCard> listuserCards = businessUserCard.SelectAllUsers().Where(m => m.GetSetUserCard_Name_Of_User1 + " " +m.GetSetUserCard_Surname_Of_User1 == UserCardName).ToList();

            UserCard usc = listuserCards.First();
            TextBoxHiddenIDUserCard.Text = Convert.ToString(usc.GetSetId_UserCard1);
        }
        public List<Movie> listMovies = new List<Movie>();
        public Movie mov = new Movie();
        public Movie mov2 = new Movie();
        private void comboBoxMovieName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MovieName;
            MovieName = comboBoxMovieName.Text;

            listMovies = businessMovie.SelectAllMoviesIdAndName().Where(m => m.GetSetMovie_Name1 == MovieName).ToList();
            mov = listMovies.First();

            TextBoxHiddenIDMovie.Text = Convert.ToString(mov.GetSetId_Movie1);

        }

        private void comboBoxMovieName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MovieName2;
            MovieName2 = comboBoxMovieName2.Text;

            listMovies = businessMovie.SelectAllMoviesIdAndName().Where(m => m.GetSetMovie_Name1 == MovieName2).ToList();
            mov2 = listMovies.First();

            TextBoxHiddenIDMovie2.Text = Convert.ToString(mov2.GetSetId_Movie1);

        }

        private void comboBoxMovieName2_Leave(object sender, EventArgs e)
        {
            if (comboBoxMovieName.Text == comboBoxMovieName2.Text)
            {
                MessageBox.Show("Ne mozete odabrati dva ista filma!", "Obavestenje");
                
                comboBoxMovieName2.Focus();
            }
        }

        public string UserCardName;
        public string UserCardSurname;

        private void listBoxRentals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRentals.Text != "")
            {
                string variable = listBoxRentals.Text;

                List<RentalStorage> listRentalStorages = businessRentalStorage.SelectAllRentalStorages().Where(rs => "Korisnik: " + rs.GetSetUserCard_Name1 + " " + rs.GetSetUserCard_Surname1 + "  -- Adresa: " + rs.GetSetUserCard_Address1 + "  -- Telefon: " + rs.GetSetUserCard_Phone_Number1 + "  -- Iznajmljeni Filmovi: " + rs.GetSetMovie_Name1 + "  -- Ukupna Cena: " + rs.GetSetTotal_Price1 + "  -- Datum Uzimanja: " + rs.GetSetRental_Date_Of_Take1 == variable).ToList();
                RentalStorage rentalStorage = listRentalStorages.First();



                UserCardName = rentalStorage.GetSetUserCard_Name1;
                UserCardSurname = rentalStorage.GetSetUserCard_Surname1;
            }
            else
            {
                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");
            }
            

                
            

        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            RentalDetails rentalDetails = new RentalDetails();

            rentalDetails.TextBoxHiddenUserCardName1.Text = UserCardName;
            rentalDetails.TextBoxHiddenUserCardSurname1.Text = UserCardSurname;

            if (rentalDetails.TextBoxHiddenUserCardName1.Text != "" && rentalDetails.TextBoxHiddenUserCardSurname1.Text != "")
                {

                this.Hide();
                rentalDetails.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Morate odabrati REZERVACIJU za Detaljniji prikaz!", "Obavestenje");

                }


        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", Uri.EscapeDataString("C:\\Users\\madon\\Documents\\Projekat_SI_VideoClub\\repos\\VideoClubAviato\\VideoClubAviato\\HELP HTML\\Rental.html"));

        }

        private void pictureBoxHelp_MouseHover(object sender, EventArgs e)
        {

            pictureBoxHelp.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxHelp, "Prikaz pomocne dokumentacije.");

        }

        private void Printer_MouseHover(object sender, EventArgs e)
        {
            Printer.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(Printer, "Stampanje.");
        }

        private void buttonDetails_MouseHover(object sender, EventArgs e)
        {
            buttonDetails.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDetails, "Detaljnije o Rezervaciji.");
        }

        private void pictureBoxAddMovie2_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Visible == false && comboBoxMovieName2.Visible == false && pictureBoxRemoveMovie2.Visible == false)
            {
                comboBoxMovieName2.Visible = true;
                pictureBoxRemoveMovie2.Visible = true;
                pictureBox8.Visible = true;
            }
            
        }

        private void pictureBoxRemoveMovie2_Click(object sender, EventArgs e)
        {
            comboBoxMovieName2.Visible = false;
            pictureBoxRemoveMovie2.Visible = false;
            pictureBox8.Visible = false;
        }
    }

      
    }

