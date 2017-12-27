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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            labelShowMovies.BackColor = Color.Transparent;
            labelShowActors.BackColor = Color.Transparent;
            labelShowGenres.BackColor = Color.Transparent;
            labelShowMovieRoles.BackColor = Color.Transparent;
            labelShowRentals.BackColor = Color.Transparent;
            labelShowUserCards.BackColor = Color.Transparent;
            labelShowDirectors.BackColor = Color.Transparent;

            pictureBoxMovies.BackColor = Color.Transparent;
            pictureBoxDirectors.BackColor = Color.Transparent;
            pictureBoxGenres.BackColor = Color.Transparent;
            pictureBoxMovieRoles.BackColor = Color.Transparent;
            pictureBoxUserCards.BackColor = Color.Transparent;
            pictureBoxHelp.BackColor = Color.Transparent;
            pictureBoxContact.BackColor = Color.Transparent;
        }

        private void labelShowMovies_MouseEnter(object sender, EventArgs e)
        {
            labelShowMovies.ForeColor = Color.White;
            labelShowMovies.Font = new Font("Arial", 27, FontStyle.Bold);
            labelShowMovies.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(labelShowMovies, "Prikaz svih informacija o Filmovima.");

        }

        private void labelShowMovies_MouseLeave(object sender, EventArgs e)
        {

            labelShowMovies.ForeColor = Color.Black;

        }

        private void labelShowActors_MouseEnter(object sender, EventArgs e)
        {
            labelShowActors.ForeColor = Color.White;
            labelShowActors.Font = new Font("Arial", 27, FontStyle.Bold);
            labelShowActors.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(labelShowActors, "Prikaz svih informacija o Glumcima.");

        }

        private void labelShowActors_MouseLeave(object sender, EventArgs e)
        {
            labelShowActors.ForeColor = Color.Black;

        }

        private void labelShowDirectors_MouseEnter(object sender, EventArgs e)
        {
            labelShowDirectors.ForeColor = Color.White;
            labelShowDirectors.Font = new Font("Arial", 27, FontStyle.Bold);
            labelShowDirectors.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(labelShowDirectors, "Prikaz svih informacija o Reziserima.");

        }

        private void labelShowDirectors_MouseLeave(object sender, EventArgs e)
        {
            labelShowDirectors.ForeColor = Color.Black;
        }

        private void labelShowGenres_MouseEnter(object sender, EventArgs e)
        {
            labelShowGenres.ForeColor = Color.White;
            labelShowGenres.Font = new Font("Arial", 27, FontStyle.Bold);
            labelShowGenres.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(labelShowGenres, "Prikaz svih informacija o Zanrovima.");

        }

        private void labelShowGenres_MouseLeave(object sender, EventArgs e)
        {
            labelShowGenres.ForeColor = Color.Black;
        }

        private void labelShowMovieRoles_MouseEnter(object sender, EventArgs e)
        {
            labelShowMovieRoles.ForeColor = Color.White;
            labelShowMovieRoles.Font = new Font("Arial", 27, FontStyle.Bold);
            labelShowMovieRoles.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(labelShowMovieRoles, "Prikaz svih informacija o Ulogama.");

        }

        private void labelShowMovieRoles_MouseLeave(object sender, EventArgs e)
        {
            labelShowMovieRoles.ForeColor = Color.Black;
        }

        private void labelShowUserCards_MouseEnter(object sender, EventArgs e)
        {
            labelShowUserCards.ForeColor = Color.White;
            labelShowUserCards.Font = new Font("Arial", 27, FontStyle.Bold);
            labelShowUserCards.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(labelShowUserCards, "Prikaz svih informacija o Korisnicima.");
        }

        private void labelShowUserCards_MouseLeave(object sender, EventArgs e)
        {
            labelShowUserCards.ForeColor = Color.Black;
        }

        private void labelShowRentals_MouseEnter(object sender, EventArgs e)
        {
            labelShowRentals.ForeColor = Color.White;
            labelShowRentals.Font = new Font("Arial", 27, FontStyle.Bold);
            labelShowRentals.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(labelShowRentals, "Prikaz svih informacija o Rezervacijama.");

        }

        private void labelShowRentals_MouseLeave(object sender, EventArgs e)
        {
            labelShowRentals.ForeColor = Color.Black;

        }

        private void pictureBoxMovies_Click(object sender, EventArgs e)
        {
            this.Hide();

            MoviePage moviePage = new MoviePage();

            moviePage.ShowDialog();
        }

        private void labelShowMovies_Click(object sender, EventArgs e)
        {
            this.Hide();

            MoviePage moviePage = new MoviePage();

            moviePage.ShowDialog();
        }

        private void pictureBoxMovies_MouseHover(object sender, EventArgs e)
        {
            pictureBoxMovies.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxMovies, "Prikaz svih informacija o Filmovima.");

        }

        private void pictureBoxDirectors_Click(object sender, EventArgs e)
        {
            this.Hide();

            DirectorPage directorPage = new DirectorPage();

            directorPage.ShowDialog();
        }

        private void labelShowDirectors_Click(object sender, EventArgs e)
        {
            this.Hide();

            DirectorPage directorPage = new DirectorPage();

            directorPage.ShowDialog();
        }

        private void pictureBoxDirectors_MouseHover(object sender, EventArgs e)
        {
            pictureBoxDirectors.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxDirectors, "Prikaz svih informacija o Reziserima.");

        }

        private void pictureBoxMovieRoles_Click(object sender, EventArgs e)
        {
            this.Hide();

            MovieRolePage movieRolePage= new MovieRolePage();

            movieRolePage.ShowDialog();
        }

        private void labelShowMovieRoles_Click(object sender, EventArgs e)
        {
            this.Hide();

            MovieRolePage movieRolePage = new MovieRolePage();

            movieRolePage.ShowDialog();
        }

        private void pictureBoxMovieRoles_MouseHover(object sender, EventArgs e)
        {
            pictureBoxMovieRoles.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxMovieRoles, "Prikaz svih informacija o Ulogama.");
        }

        private void pictureBoxGenres_Click(object sender, EventArgs e)
        {
            this.Hide();

            GenrePage genrePage = new GenrePage();

            genrePage.ShowDialog();
        }

        private void labelShowGenres_Click(object sender, EventArgs e)
        {
            this.Hide();

            GenrePage genrePage = new GenrePage();

            genrePage.ShowDialog();
        }

        private void pictureBoxGenres_MouseHover(object sender, EventArgs e)
        {
            pictureBoxGenres.Cursor = Cursors.Hand;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxGenres, "Prikaz svih informacija o Zanrovima.");
        }

        private void pictureBoxUserCards_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserCardPage userCardPage = new UserCardPage();

            userCardPage.ShowDialog();
        }

        private void labelShowUserCards_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserCardPage userCardPage = new UserCardPage();

            userCardPage.ShowDialog();
        }

        private void pictureBoxUserCards_MouseHover(object sender, EventArgs e)
        {
            pictureBoxUserCards.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxUserCards, "Prikaz svih informacija o Korisnicima.");

        }

        private void labelShowRentals_Click(object sender, EventArgs e)
        {
            this.Hide();

            RentalPage rentalPage = new RentalPage();

            rentalPage.ShowDialog();
        }

        private void pictureBoxActors_Click(object sender, EventArgs e)
        {
            this.Hide();

            ActorPage actorPage = new ActorPage();

            actorPage.ShowDialog();

        }


        private void labelShowActors_Click(object sender, EventArgs e)
        {
            this.Hide();

            ActorPage actorPage = new ActorPage();

            actorPage.ShowDialog();
        }

       

        private void pictureBoxActors_MouseHover(object sender, EventArgs e)
        {
            pictureBoxActors.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxActors, "Prikaz svih informacija o Glumcima.");
        }

        private void pictureBoxContact_MouseHover(object sender, EventArgs e)
        {
            pictureBoxContact.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxContact, "Kontaktirajte nas.");
        }

        private void pictureBoxContact_Click(object sender, EventArgs e)
        {
            this.Hide();

            Contact contact = new Contact();

            contact.ShowDialog();

        }

        private void pictureBoxHelp_MouseHover(object sender, EventArgs e)
        {
            pictureBoxHelp.Cursor = Cursors.Hand;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pictureBoxHelp, "Prikaz pomocne dokumentacije.");
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            // OVDE CE DA IDE KOD ZA HELP!!!
        }
    }
}
