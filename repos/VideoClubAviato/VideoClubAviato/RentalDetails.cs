using BusinessLayer;
using DataLayer;
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
    public partial class RentalDetails : Form
    {
        private BusinessRentalStorage businessRentalStorage;
        private BusinessMovie businessMovie;


        public RentalDetails()
        {
            InitializeComponent();

            IRentalStorageRepository rentalStorageRepository = new RentalStorageRepository();
            this.businessRentalStorage = new BusinessRentalStorage(rentalStorageRepository);


            IMovieRepository movieRepository = new MovieRepository();
            this.businessMovie = new BusinessMovie(movieRepository);


            this.Width = 600;
            this.Height = 120;


        }

        //SPOLJASNJA METODA KOJA POPUNJAVA LISTBOX SA DETALJIMA O REZERVACIJI PO KORISNIKU
        public void FillListBoxRentalStorage()
        {
            string UserCardName = TextBoxHiddenUserCardName1.Text;
            string UserCardSurname = TextBoxHiddenUserCardSurname1.Text;

            List<RentalStorage> listRentalStorages = businessRentalStorage.SelectAllRentalDetailsByNameAndSurname().Where(rs => rs.GetSetUserCard_Name1.Contains(UserCardName) && rs.GetSetUserCard_Surname1.Contains(UserCardSurname)).ToList();


            foreach (RentalStorage variable in listRentalStorages)
            {
                listBoxRentalDetails.Items.Add("Film: " +variable.GetSetMovie_Name1 + "  -- Datum Uzimanja: " + variable.GetSetRental_Date_Of_Take1 + "  -- Datum Vracanja: " + variable.GetSetRental_Date_Of_Return1);
            }
        }

        //SPOLJNA METODA KOJA CISTI ListBox NAKON KLIKA NA BILO KOJE DUGME
        public void ClearData()
        {
            listBoxRentalDetails.Items.Clear();
        }

        private void listBoxRentalDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRentalDetails.Text != "")
            {
                string variable1 = listBoxRentalDetails.Text;
                string HiddenMovieName;


                List<RentalStorage> listRentalStorages = businessRentalStorage.SelectAllRentalDetailsByNameAndSurname().ToList();
                RentalStorage rentalStorage = listRentalStorages.First();

                foreach (RentalStorage variable in listRentalStorages)
                {
                    if ("Film: " + variable.GetSetMovie_Name1 + "  -- Datum Uzimanja: " + variable.GetSetRental_Date_Of_Take1 + "  -- Datum Vracanja: " + variable.GetSetRental_Date_Of_Return1 == variable1)
                    {
                        TextBoxHiddenMovieName.Text = variable.GetSetMovie_Name1;
                        HiddenMovieName = TextBoxHiddenMovieName.Text;
                        List<Movie_Genre_Director> listMovies = businessMovie.SelectAllMovies().Where(m => m.GetSetMovie_Name1.Contains(HiddenMovieName)).ToList();
                        if(listMovies.Count() != 0)
                        {
                            Movie_Genre_Director variable2 = listMovies.First();
                            TextBoxHiddenMovieAmount.Text = Convert.ToString(variable2.GetSetMovie_Amount1);
                            TextBoxHiddenMovieID.Text = Convert.ToString(variable2.GetSetId_Movie1);
                            TextBoxHiddenDateOfReturn.Text = rentalStorage.GetSetRental_Date_Of_Return1;
                        }
                        else
                        {
                            MessageBox.Show("Film je obrisan u medjuvremenu!", "Obavestenje");
                        }
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");

            }

        }

        private void buttonMovieReturn_Click(object sender, EventArgs e)
        {
            if (TextBoxHiddenMovieName.Text != "")
            {
                if(TextBoxHiddenMovieAmount.Text != "")
                {
                    int movieAmount = Convert.ToInt32(TextBoxHiddenMovieAmount.Text);
                
                string movieName = TextBoxHiddenMovieName.Text;
                int idMovie = Convert.ToInt32(TextBoxHiddenMovieID.Text);

                movieAmount++;

                List<Movie_Genre_Director> listMovies = businessMovie.SelectAllMovies().Where(m => m.GetSetMovie_Name1.Contains(movieName)).ToList();
                Movie_Genre_Director mgd = listMovies.First();

                mgd.GetSetMovie_Amount1 = movieAmount;

                Movie mov = new Movie();

                mov.GetSetMovie_Amount1 = movieAmount;
                mov.GetSetMovie_Name1 = movieName;
                mov.GetSetId_Movie1 = idMovie;


                

                businessMovie.UpdateMovieAmount(mov);
                businessMovie.UpdateMovieStatus2(mov);

                DateTime dateTime = DateTime.Now;

                RentalStorage rentalStorage = new RentalStorage();
                rentalStorage.GetSetRental_Date_Of_Return1 = Convert.ToString(dateTime);
                rentalStorage.GetSetMovie_Name1 = movieName;

                businessRentalStorage.UpdateRentalStorageDateOfReturn(rentalStorage);

                ClearData();
                FillListBoxRentalStorage();
                }
                else
                {
                    MessageBox.Show("Film je obrisan u medjuvremenu!", "Obavestenje");

                }
            }
            else
            {
                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");
            }
        }
        
        //DUGME ZA PRIKAZ DETALJA NA LISTBOX-u
        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 500;

            ClearData();
            FillListBoxRentalStorage();
        }

        private void RentalDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

            RentalPage rentalPage = new RentalPage();

            rentalPage.ShowDialog();
        }
    }
}
