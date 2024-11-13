using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack2.forms
{
    public partial class mailsend : Form
    {
        public mailsend()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string to = textBox1.Text; // Zamijenite s pravom e-mail adresom
            string from = "imeltransfer2@gmail.com"; // Zamijenite s pravom e-mail adresom
            string subject =textBox3.Text;
            string body = textBoxEmailBody.Text; // Uzimanje teksta iz TextBox-a

            try
            {
                MailMessage mail = new MailMessage(from, to, subject, body);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Zamijenite s pravim SMTP poslužiteljem
                smtp.Credentials = new NetworkCredential("imeltransfer2@gmail.com", "dldb irtp yvlp mxfm "); // Zamijenite s pravim korisničkim podacima
                smtp.EnableSsl = true; // Ako je potrebno

                smtp.Send(mail);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom slanja e-maila: " + ex.Message);
            }
        }
    }
}
