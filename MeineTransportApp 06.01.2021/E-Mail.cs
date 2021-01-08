using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net.Mail;

namespace MeineTransportApp_06._01._2021
{
    public partial class E_Mail : Form
    {
        public E_Mail()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';
        }

        private void buttonSenden_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(textBoxVon.Text, textBoxAn.Text, textBoxBetreff.Text, mailTxt.Text);

            SmtpClient client = new SmtpClient(textBoxSmtp.Text);
            // Für Gmail = smtp.gmail.com |Yahoo = smtp.yahoo.com
            client.Port = 465;
            client.Credentials = new System.Net.NetworkCredential(textBoxUser.Text, textBoxPassword.Text);

            client.EnableSsl = true;
            client.Send(mail);

            MessageBox.Show("E-Mail wurde erfolgreich gesendet");// MessageBoxButtons.OK);

        }
    }
}
