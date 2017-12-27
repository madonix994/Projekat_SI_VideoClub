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
    public partial class GenrePage : Form
    {
        //POVEZIVANJE SA BUSINESS LAYER-OM GENRE I MOVIE TABELE
        public BusinessGenre businessGenre = new BusinessGenre();
        public BusinessMovie businessMovie = new BusinessMovie();

        public GenrePage()
        {
            InitializeComponent();
            FillGenres();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;

        }

        //SPOLJNA METODA KOJA ISPISUJE SVE PODATKE U LISTU IZ TABELE Genres IZ BAZE
        public void FillGenres()
        {
            listBoxGenres.Items.Clear();
            List<Genre> listaG = businessGenre.SelectAllGenres();
            foreach (Genre pom in listaG)
            {
                if (pom.GetSetGenre_Name1 == "Nije Uneto") { }
                else
                {
                    listBoxGenres.Items.Add(pom.GetSetId_Genre1 + ". " + pom.GetSetGenre_Name1);
                }

            }
        }

        //SPOLJNA METODA KOJA CISTI SVA Text Box POLJA NAKON UNOSA I IZMENE PODATAKA PRILIKOM KLIKA NA ODGOVARAJUCU DUGMAD
        public void ClearData()
        {
            TextBoxHiddenIDGenre.Text = "";
            textBoxGenreName.Text = "";
        }

        /*KREIRANJE METODE ZA UPDATE GDE VRSIMO AZURIRANJE MOVIE TABELE ODNOSNO SETUJEMO ZANR ZA ODREDJENI FILM
          NA "Nije Uneto" U OKVIRU MOVIE TABELE NAKON BRISANJA TOG ZANRA IZ TABELE ZANROVI
          (potrebno radi lancane reakcije nesto kao triger)    */
        public void UpdateGenreOnMovie()
        {
            Movie m = new Movie();

            m.GetSetId_Genre_Genres1 = Convert.ToInt32(TextBoxHiddenIDGenre.Text); //ID zanra iz textBox-a!!!

            businessMovie.UpdateGenreOnMovie(m);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        private void MouseHoverInsertGenre(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertGenre, "Unesite novi Zanr.");

        }

        private void MouseHoverUpdateGenre(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateDirector, "Izmenite podatke o Zanru.");

        }

        private void MouseHoverDeleteGenre(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteGenre, "Brisanje Zanra.");

        }
        private void buttonGenreSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonGenreSearch, "Pretrazi Zanr.");

        }

        public int Variable = 1;
        private void textBoxGenreName_Leave(object sender, EventArgs e)
        {
            if (textBoxGenreName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }

        }

        //PRILIKOM KLIKA NA DUGME VRSI SE UNOS ZANRA U BAZU !
        private void buttonInsertGenre_Click(object sender, EventArgs e)
        {
            if (textBoxGenreName.Text != "")
            {              
                Genre g = new Genre();
                g.GetSetGenre_Name1 = textBoxGenreName.Text;

                businessGenre.InsertGenre(g);
                ClearData();
                FillGenres();
            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        //PRILIKOM KLIKA NA DUGME VRSI SE AZURIRANJE ZANRA U BAZI
        private void buttonUpdateDirector_Click(object sender, EventArgs e)
        {
            if (textBoxGenreName.Text != "")
            {
                Genre g = new Genre();

                g.GetSetId_Genre1 = Convert.ToInt32(TextBoxHiddenIDGenre.Text);
                g.GetSetGenre_Name1 = textBoxGenreName.Text;


                businessGenre.UpdateGenre(g);
                ClearData();
                FillGenres();
            }
            else
            {

                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");

            }
        }

        /*PRILIKOM KLIKA NA DUGME VRSI SE BRISANJE ZANRA IZ BAZE 
        (GDE POZIVAMO METODU ZA AZURIRANJE ZANRA ZA FILM KOJEM SMO IZBRISALI ZANR)  
        (potrebno radi lancane reakcije nesto kao triger)*/
        private void buttonDeleteGenre_Click(object sender, EventArgs e)
        {
            if (TextBoxHiddenIDGenre.Text != "")
            {
                Genre g = new Genre();

                g.GetSetId_Genre1 = Convert.ToInt32(TextBoxHiddenIDGenre.Text);

                UpdateGenreOnMovie();
                businessGenre.DeleteGenre(g);

                ClearData();
                FillGenres();
            }
            else
            {
                MessageBox.Show("Morate odabrati ZANR za brisanje!", "Obavestenje");
            }
        }

        //PRETRAGA ZANROVA U BAZI
        private void buttonGenreSearch_Click(object sender, EventArgs e)
        {
            listBoxGenres.Items.Clear();

            string pom1 = textBoxGenreSearch.Text;

            List<Genre> lista = businessGenre.SearchbyGenre(pom1);
            foreach (Genre pom in lista)
            {
                if (pom.GetSetGenre_Name1 == "Nije Uneto") { }
                else
                {
                    listBoxGenres.Items.Add(pom.GetSetId_Genre1 + ". " + pom.GetSetGenre_Name1);
                }

            }

        }

        //PRILIKOM ODABIRA JEDNOG REDA U LISTI SVI PODACI SE POKAZUJU U TextBox POLJA ZA EVENTUALNO DALJE AZURIRANJE
        private void listBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGenres.Text != "")
            {
                string pom;
            pom = listBoxGenres.Text;

            List<Genre> lista = businessGenre.SelectAllGenres().Where(g => g.GetSetId_Genre1 + ". " + g.GetSetGenre_Name1 == pom).ToList();
            Genre genre = lista.First();

            TextBoxHiddenIDGenre.Text = Convert.ToString(genre.GetSetId_Genre1);

            textBoxGenreName.Text = genre.GetSetGenre_Name1;
            }
            else
            {

                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");

            }
        }
    }
}
