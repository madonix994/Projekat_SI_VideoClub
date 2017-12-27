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
    public partial class Contact : Form
    {

        public int number1;
        public int number2;

        public Contact()
        {
            InitializeComponent();

            textBoxEmailOfSender.Focus();

            Random random = new Random();
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
            labelRandom1.Text = Convert.ToString(number1)+" + ";
            labelRandom2.Text = Convert.ToString(number2);

            this.comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;


        }
   
        public int Variable = 1;
        public int Variable2 = 1;
        public int Variable3 = 1;
        public int Variable4 = 1;

        private void textBoxEmailOfSender_Leave(object sender, EventArgs e)
        {
            if (IsValidEmail() == true)
            {

                if (textBoxEmailOfSender.Text != "")
                {
                    if (Variable3 == 1)
                    {
                        progressBar1.PerformStep();

                        Variable3++;
                    }

                }
            }
            else
            {
                MessageBox.Show("Vasa E-mail adresa nije validna!", "Obavestenje");

                textBoxEmailOfSender.Focus();

            }
}
        private void textBoxSubject_Leave(object sender, EventArgs e)
        {
            if (textBoxSubject.Text != "")
            {
                if (Variable == 1)
                {
                    progressBar1.PerformStep();

                    Variable++;
                }

            }
        }

        private void textBoxMessageBody_Leave(object sender, EventArgs e)
        {
            if (textBoxMessageBody.Text != "")
            {
                if (Variable2 == 1)
                {
                    progressBar1.PerformStep();

                    Variable2++;
                }

            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text != "")
            {
                if (Variable4 == 1)
                {
                    progressBar1.PerformStep();

                    Variable4++;
                }

            }
        }


        private void buttonAttachment_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxAttachment.Text = openFileDialog1.FileName.ToString();
            }

        }

        private bool IsValidEmail()
        {
            string emailToCheck =  textBoxEmailOfSender.Text;

            try
            {

                MailAddress mail = new MailAddress(emailToCheck);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        private void textBoxResponse_Leave(object sender, EventArgs e)
        {
            int Response = Convert.ToInt32(textBoxResponse.Text);
            if (Response == (number1 + number2))
            {
                buttonSendMessage.Enabled = true;
            }
            else
            {
                buttonSendMessage.Enabled = false;
            }
        }



        private void buttonSendMessage_Click(object sender, EventArgs e)
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

        private void Contact_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MainPage mainPage = new MainPage();

            mainPage.ShowDialog();
        }
    }
}
