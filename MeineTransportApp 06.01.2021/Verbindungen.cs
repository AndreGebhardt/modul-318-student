using SwissTransport.Core;
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
    public partial class Verbindungen : Form
    {
        Transport transport = new Transport();
        
        public Verbindungen()
        {
            InitializeComponent();
            
        }                        

        private void start_TextChanged(object sender, EventArgs e)
        {
            verbindungSuchen.Enabled = comboBoxStart.Text.Length > 0;
        }

        private void Verbindungen_Load(object sender, EventArgs e)
        {
            //verbindungSuchen.Enabled = false;
        }

        

        
        // ist eine Verbindung(Switch)zum Abfahrtsplan

        private void abfahrtsButton_Click(object sender, EventArgs e)
        {
            abfarhtsTafel at = new abfarhtsTafel();
            at.ShowDialog();
        }

        private void verbindungSuchen_Click_1(object sender, EventArgs e)
        {
            var verbindungen = transport.GetConnections(comboBoxStart.Text, comboBoxNach.Text);  //("Luzern", "Sursee"); Beispiel verbindungen, am anfang des Projektes

            dataGridViewVerbindungen.Rows.Clear();
            
            for (int i = 0; i < 4; i++)
            {
                dataGridViewVerbindungen.Rows.Add(new string[]
                {
                    verbindungen.ConnectionList[i].From.Departure.ToString(),
                    verbindungen.ConnectionList[i].Duration.ToString(),
                    verbindungen.ConnectionList[i].From.Platform.ToString(),
                    verbindungen.ConnectionList[i].To.Arrival.ToString(),
                    verbindungen.ConnectionList[i].To.Delay.ToString()

                });
            }
            //var verbindungen = transport.GetConnections(comboBoxStart.Text, comboBoxNach.Text);

            //var temp1 = verbindungen.ConnectionList[0].From.Station;
            //MessageBox.Show(temp1.ToString());

            //var temp2 = verbindungen.ConnectionList[0].To.Station.Name;
            //MessageBox.Show(temp2.ToString());


        }

        private void comboBoxStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            verbindungSuchen.Enabled = true;
        }

        private void comboBoxStart_TextChanged(object sender, EventArgs e)
        {
            
                        
           

            if (comboBoxStart.Text.Length > 0)
            {
                var station = transport.GetStations(comboBoxStart.Text);
                foreach (var x in station.StationList)
                {
                    comboBoxStart.Items.Add(x.Name);

                }
            }

            
        }

        private void comboBoxNach_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxNach.Text.Length > 0)
            {
                var station1 = transport.GetStations(comboBoxNach.Text);
                foreach (var x in station1.StationList)
                {
                    comboBoxNach.Items.Add(x.Name);

                }
            }          
           
            
        }
       
    }
}
