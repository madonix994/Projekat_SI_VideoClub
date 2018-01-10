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

            List<RentalStorage> lista2 = businessRentalStorage.SelectAllRentalDetailsByNameAndSurname().Where(rs => rs.GetSetUserCard_Name1.Contains(UserCardName) && rs.GetSetUserCard_Surname1.Contains(UserCardSurname)).ToList();


            foreach (RentalStorage pom in lista2)
            {
                listBoxRentalDetails.Items.Add("Film: " +pom.GetSetMovie_Name1 + "  -- Datum Uzimanja: " + pom.GetSetRental_Date_Of_Take1 + "  -- Datum Vracanja: " + pom.GetSetRental_Date_Of_Return1);
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
                string pomocna = listBoxRentalDetails.Text;
                string HiddenMovieName;


                List<RentalStorage> lista = businessRentalStorage.SelectAllRentalDetailsByNameAndSurname().ToList();
                RentalStorage pomobjekat = lista.First();

                foreach (RentalStorage pom in lista)
                {
                    if ("Film: " + pom.GetSetMovie_Name1 + "  -- Datum Uzimanja: " + pom.GetSetRental_Date_Of_Take1 + "  -- Datum Vracanja: " + pom.GetSetRental_Date_Of_Return1 == pomocna)
                    {
                        TextBoxHiddenMovieName.Text = pom.GetSetMovie_Name1;
                        HiddenMovieName = TextBoxHiddenMovieName.Text;
                        List<Movie_Genre_Director> listaFilmova = businessMovie.SelectAllMovies().Where(m => m.GetSetMovie_Name1.Contains(HiddenMovieName)).ToList();
                        if(listaFilmova.Count() != 0)
                        {
                            Movie_Genre_Director pom2 = listaFilmova.First();
                            TextBoxHiddenMovieAmount.Text = Convert.ToString(pom2.GetSetMovie_Amount1);
                            TextBoxHiddenMovieID.Text = Convert.ToString(pom2.GetSetId_Movie1);
                            TextBoxHiddenDateOfReturn.Text = pomobjekat.GetSetRental_Date_Of_Return1;
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
                    int kolicina = Convert.ToInt32(TextBoxHiddenMovieAmount.Text);
                
                string imefilma = TextBoxHiddenMovieName.Text;
                int IDFilma = Convert.ToInt32(TextBoxHiddenMovieID.Text);

                kolicina++;

                List<Movie_Genre_Director> listaFilmova = businessMovie.SelectAllMovies().Where(m => m.GetSetMovie_Name1.Contains(imefilma)).ToList();
                Movie_Genre_Director pom2 = listaFilmova.First();

                pom2.GetSetMovie_Amount1 = kolicina;

                Movie mov = new Movie();

                mov.GetSetMovie_Amount1 = kolicina;
                mov.GetSetMovie_Name1 = imefilma;
                mov.GetSetId_Movie1 = IDFilma;


                

                businessMovie.UpdateMovieAmount(mov);
                businessMovie.UpdateMovieStatus2(mov);

                DateTime dateTime = DateTime.Now;

                RentalStorage pomocniobjekat = new RentalStorage();
                pomocniobjekat.GetSetRental_Date_Of_Return1 = Convert.ToString(dateTime);
                pomocniobjekat.GetSetMovie_Name1 = imefilma;

                businessRentalStorage.UpdateRentalStorageDateOfReturn(pomocniobjekat);

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
