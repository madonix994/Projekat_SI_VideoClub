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
    public partial class UserCardPage : Form
    {
        //POVEZIVANJE SA BUSINESS LAYER-om
        public BusinessUserCard businessUserCard = new BusinessUserCard();

        public UserCardPage()
        {
            InitializeComponent();

            FillUsers();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;


        }
        
        // ISPIS SVIH KORISIKA U LISTU!!!
        public void FillUsers()
        {
            listBoxUserCards.Items.Clear();
            List<UserCard> listaU = businessUserCard.SelectAllUsers();
            foreach (UserCard pom in listaU)
            {
                listBoxUserCards.Items.Add(pom.GetSetId_UserCard1 + ". " + pom.GetSetUserCard_Name_Of_User1 + " " + pom.GetSetUserCard_Surname_Of_User1 + "  --  " + pom.GetSetUserCard_Address_Of_User1 + "  --  " + pom.GetSetUserCard_PhoneNumber_Of_User1);
            }

        }

        //SPOLJNA METODA KOJA CISTI SVA Text Box POLJA NAKON UNOSA I IZMENE PODATAKA PRILIKOM KLIKA NA ODGOVARAJUCU DUGMAD
        public void ClearData()
        {
            textBoxUserCardName.Text = "";
            textBoxUserCardSurname.Text = "";
            textBoxUserCardAddress.Text = "";
            textBoxUserCardPhoneNumber.Text = "";
            TextBoxHiddenIDUserCard.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }

        private void buttonUserCardSearch_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUserCardSearch, "Pretrazi Korisnika.");
        }

        private void buttonInsertUserCard_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonInsertUserCard, "Unesite novog Korisnika.");
        }

        private void buttonUpdateUserCard_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonUpdateUserCard, "Izmenite podatke o Korisniku.");
        }

        private void buttonDeleteUserCard_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(buttonDeleteUserCard, "Brisanje Korisnika.");
        }

        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;
        public int Variable4 = 1;
        private void FocusLeaveName(object sender, EventArgs e)
        {
                        
            if (textBoxUserCardName.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }
             
            }

        }

        private void FocusLeaveSurname(object sender, EventArgs e)
        {
            if (textBoxUserCardSurname.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void FocusLeaveAddress(object sender, EventArgs e)
        {
            if (textBoxUserCardAddress.Text != "")
            {
                if (Variable3 == 1)
                {
                    progressBar1.PerformStep();

                    Variable3++;
                }

            }
        }

        private void FocusLeavePhone(object sender, EventArgs e)
        {
            if (textBoxUserCardPhoneNumber.Text != "")
            {
                if (Variable4 == 1)
                {
                    progressBar1.PerformStep();

                    Variable4++;
                }

            }
        }


        //DUGME ZA UNOS KORISNIKA U BAZU!
        private void buttonInsertUserCard_Click(object sender, EventArgs e)
        {
            if (textBoxUserCardName.Text != "" && textBoxUserCardSurname.Text != "" && textBoxUserCardAddress.Text != "" && textBoxUserCardPhoneNumber.Text != "")
            {
                List<UserCard> listaU = businessUserCard.SelectAllUsers();
                foreach (UserCard pom in listaU)
                {
                    if ((pom.GetSetUserCard_Name_Of_User1 == textBoxUserCardName.Text || pom.GetSetUserCard_Name_Of_User1.ToLower() == textBoxUserCardName.Text || pom.GetSetUserCard_Name_Of_User1.ToUpper() == textBoxUserCardName.Text)
                       && (pom.GetSetUserCard_Surname_Of_User1 == textBoxUserCardSurname.Text || pom.GetSetUserCard_Surname_Of_User1.ToLower() == textBoxUserCardSurname.Text || pom.GetSetUserCard_Surname_Of_User1.ToUpper() == textBoxUserCardSurname.Text)
                       && pom.GetSetUserCard_Address_Of_User1 == textBoxUserCardAddress.Text)
                    {
                        ClearData();
                        MessageBox.Show("Uneti korisnik vec postoji u bazi!", "Obavestenje");
                    }
                }
                if (textBoxUserCardName.Text != "" && textBoxUserCardSurname.Text != "" && textBoxUserCardAddress.Text != "" && textBoxUserCardPhoneNumber.Text != "")
                {
                    UserCard u = new UserCard();
                u.GetSetUserCard_Name_Of_User1 = textBoxUserCardName.Text;
                u.GetSetUserCard_Surname_Of_User1 = textBoxUserCardSurname.Text;
                u.GetSetUserCard_Address_Of_User1 = textBoxUserCardAddress.Text;
                u.GetSetUserCard_PhoneNumber_Of_User1 = Convert.ToInt32(textBoxUserCardPhoneNumber.Text);

                businessUserCard.InsertUser(u);
                FillUsers();
                ClearData();
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

        //PRILIKOM KLIKA NA DUGME VRSI SE AZURIRANJE FILMA U BAZI
        private void buttonUpdateUserCard_Click(object sender, EventArgs e)
        {
            if (textBoxUserCardName.Text != "" && textBoxUserCardSurname.Text != "" && textBoxUserCardAddress.Text != "" && textBoxUserCardPhoneNumber.Text != "")
            {
                UserCard uc = new UserCard();

                uc.GetSetId_UserCard1 = Convert.ToInt32(TextBoxHiddenIDUserCard.Text);


                uc.GetSetUserCard_Name_Of_User1 = textBoxUserCardName.Text;
                uc.GetSetUserCard_Surname_Of_User1 = textBoxUserCardSurname.Text;

                uc.GetSetUserCard_Address_Of_User1 = textBoxUserCardAddress.Text; //ID filma iz textBox-a!!!
                uc.GetSetUserCard_PhoneNumber_Of_User1 = Convert.ToInt32(textBoxUserCardPhoneNumber.Text);//ID glumca iz textBox-a!!!

                businessUserCard.UpdateUserCard(uc);
                ClearData();
                FillUsers();
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja!", "Obavestenje");
            }
        }

        //DUGME ZA BRISANJE KORISNIKA IZ BAZE
        private void buttonDeleteUserCard_Click(object sender, EventArgs e)
        {
            if (TextBoxHiddenIDUserCard.Text != "")
            {
                UserCard uc = new UserCard();

                uc.GetSetId_UserCard1 = Convert.ToInt32(TextBoxHiddenIDUserCard.Text);

                businessUserCard.DeleteUserCard(uc);

                ClearData();
                FillUsers();
            }
            else
            {
                MessageBox.Show("Morate odabrati KORISNIKA za brisanje!", "Obavestenje");
            }
        }

        //DUGME ZA PRETRAGU KORISNIKA U BAZI
        private void buttonUserCardSearch_Click(object sender, EventArgs e)
        {
            listBoxUserCards.Items.Clear();
            UserCard uc = new UserCard();
            string pom1 = textBoxUserCardSearch.Text;

            List<UserCard> lista = businessUserCard.SearchUserCard(pom1);
            foreach (UserCard pom in lista)
            {
                listBoxUserCards.Items.Add(pom.GetSetId_UserCard1 + ". " + pom.GetSetUserCard_Name_Of_User1 + " " + pom.GetSetUserCard_Surname_Of_User1 + "  --  " + pom.GetSetUserCard_Address_Of_User1 + "  --  " + pom.GetSetUserCard_PhoneNumber_Of_User1);
            }
        }

        //PRILIKOM ODABIRA JEDNOG REDA U LISTI SVI PODACI SE POKAZUJU U TextBox POLJA ZA EVENTUALNO DALJE AZURIRANJE
        private void listBoxUserCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUserCards.Text != "")
            {
                string pom;
                pom = listBoxUserCards.Text;

                List<UserCard> lista = businessUserCard.SelectAllUsers().Where(u => u.GetSetId_UserCard1 + ". " + u.GetSetUserCard_Name_Of_User1 + " " + u.GetSetUserCard_Surname_Of_User1 + "  --  " + u.GetSetUserCard_Address_Of_User1 + "  --  " + u.GetSetUserCard_PhoneNumber_Of_User1 == pom).ToList();

                UserCard uc = lista.First();

                TextBoxHiddenIDUserCard.Text = Convert.ToString(uc.GetSetId_UserCard1);

                textBoxUserCardName.Text = uc.GetSetUserCard_Name_Of_User1;
                textBoxUserCardSurname.Text = uc.GetSetUserCard_Surname_Of_User1;
                textBoxUserCardAddress.Text = uc.GetSetUserCard_Address_Of_User1;
                textBoxUserCardPhoneNumber.Text = Convert.ToString(uc.GetSetUserCard_PhoneNumber_Of_User1);
            }
            else
            {
                MessageBox.Show("Kliknuli ste na prazno polje u listi, odaberite bilo koji red iz liste!", "Obavestenje");
            }
        }


    }
}
