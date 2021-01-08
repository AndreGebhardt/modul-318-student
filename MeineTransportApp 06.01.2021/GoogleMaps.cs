using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeineTransportApp_06._01._2021
{
    public partial class GoogleMaps : Form
    {
        private void SuppressScriptErrors()
        {
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Window.Error += new HtmlElementErrorEventHandler(scriptWindow_Error);
            }
        }

        private void scriptWindow_Error(object sender, HtmlElementErrorEventArgs e)
        {
            MessageBox.Show("Suppressed error!");
            e.Handled = true;
        }

        // Hides script errors without hiding other dialog boxes.
        private void SuppressScriptErrorsOnly(WebBrowser browser)
        {
            // Ensure that ScriptErrorsSuppressed is set to false.
            browser.ScriptErrorsSuppressed = true;

            // Handle DocumentCompleted to gain access to the Document object.
            browser.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(
                    browser_DocumentCompleted);
        }

        private void browser_DocumentCompleted(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Document.Window.Error +=
                new HtmlElementErrorEventHandler(Window_Error);
        }

        private void Window_Error(object sender,
            HtmlElementErrorEventArgs e)
        {
            // Ignore the error and suppress the error dialog box. 
            e.Handled = true;
        }


        public GoogleMaps()
        {
            InitializeComponent();
        }

        private void buttonSuche_Click(object sender, EventArgs e)
        {
            string strasse = textBoxStrasse.Text;
            string stadt = textBoxStadt.Text;
            string land_kanton = textBoxStaat.Text;
            string plz = textBoxPlz.Text;

            try
            {
                StringBuilder abfrageadresse = new StringBuilder();
                abfrageadresse.Append("http://maps.google.ch/maps?q=");

                if (strasse != string.Empty)
                {
                    abfrageadresse.Append(strasse + "," + "+");
                }
                if (stadt != string.Empty)
                {
                    abfrageadresse.Append(stadt + "," + "+");
                }
                if (land_kanton != string.Empty)
                {
                    abfrageadresse.Append(land_kanton+ "," + "+");
                }
                if (plz != string.Empty)
                {
                    abfrageadresse.Append(plz + "," + "+");
                }

                webBrowser1.Navigate(abfrageadresse.ToString());

            }
            catch //(Exception ex)        
            {
                MessageBox.Show("Fehler"); //MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
