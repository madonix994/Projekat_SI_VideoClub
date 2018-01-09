using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace VideoClubAviato
{
    public partial class ContactPage : Form
    {
        public int Variable1;
        public int Variable2;


        public ContactPage()
        {
            InitializeComponent();

            textBoxEmailOfSender.Focus();

            label10.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            labelEmailOfSender.BackColor = Color.Transparent;
            labelRandom1.BackColor = Color.Transparent;
            labelRandom2.BackColor = Color.Transparent;




            Random random = new Random();
            Variable1 = random.Next(0, 10);
            Variable2 = random.Next(0, 10);
            labelRandom1.Text = Convert.ToString(Variable1) + " + ";
            labelRandom2.Text = Convert.ToString(Variable2);

            this.comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private bool IsValidEmail()
        {
            string emailToCheck = textBoxEmailOfSender.Text;

            try
            {
                MailAddress mail = new MailAddress(emailToCheck);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        private void buttonAttachment_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxAttachment.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void textBoxNameOfSnder_Leave_1(object sender, EventArgs e)
        {
            if (textBoxNameOfSnder.Text == "")
            {
                MessageBox.Show("Morate uneti svoje ime!", "Obavestenje");

                textBoxNameOfSnder.Focus();

            }
        }

        private void textBoxSubject_Leave_1(object sender, EventArgs e)
        {
            if (textBoxSubject.Text == "")
            {
                MessageBox.Show("Morate napisati naslov Poruke!", "Obavestenje");

                textBoxSubject.Focus();

            }
        }

        private void textBoxEmailOfSender_Leave_1(object sender, EventArgs e)
        {
            if (IsValidEmail() == true)
            {


            }
            else
            {
                MessageBox.Show("Vasa E-mail adresa nije validna!", "Obavestenje");

                textBoxEmailOfSender.Focus();

            }
        }

        private void comboBoxCategory_Leave_1(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text == "")
            {
                MessageBox.Show("Morate izabrati Kategoriju!", "Obavestenje");

                comboBoxCategory.Focus();

            }
        }

        private void textBoxMessageBody_Leave_1(object sender, EventArgs e)
        {
            if (textBoxMessageBody.Text == "")
            {
                MessageBox.Show("Morate popuniti polje za Poruku!", "Obavestenje");

                textBoxSubject.Focus();

            }
        }

        private void buttonSendMessage_Click_1(object sender, EventArgs e)
        {
            string kategorija = comboBoxCategory.Text;


            try
            {


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("madonix994@gmail.com");
                message.To.Add("faks298@gmail.com");
                message.Subject = textBoxSubject.Text;
                textBoxMessageBody.AppendText("\n");
                textBoxMessageBody.AppendText("\n");
                textBoxMessageBody.AppendText("Kategorija je " + kategorija + ".");
                textBoxMessageBody.AppendText("\n");
                textBoxNameOfSnder.AppendText("Ime posiljaoca: " + textBoxNameOfSnder.Text);
                textBoxMessageBody.AppendText("\n");
                textBoxMessageBody.AppendText("Email sa kog je poslata poruka je: " + textBoxEmailOfSender.Text);
                message.Body = textBoxMessageBody.Text;

                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                if (textBoxAttachment.Text != "")
                {
                    message.Attachments.Add(new Attachment(textBoxAttachment.Text));

                }

                client.Credentials = new System.Net.NetworkCredential("madonix994@gmail.com", "kraljevo036");
                client.Send(message);
                message = null;
                MessageBox.Show("Vasa poruka je poslata.", "Obavestenje");


                this.Hide();

                MainPage mainPage = new MainPage();

                mainPage.ShowDialog();

            }
            catch (Exception s)

            {
                MessageBox.Show("Doslo je do greske.", "Obavestenje");
            }
        }

        private void textBoxResponse_Leave_1(object sender, EventArgs e)
        {
            int Response = Convert.ToInt32(textBoxResponse.Text);
            if (Response == (Variable1 + Variable2))
            {
                buttonSendMessage.Enabled = true;
            }
            else
            {
                buttonSendMessage.Enabled = false;
            }
        }

        private void ContactPage_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }
    }
}
