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
    public partial class abfarhtsTafel : Form
    {
        Transport transport = new Transport();

        public abfarhtsTafel()
        {
            InitializeComponent();
        }
                

        private void verbindungSuchen1_Click(object sender, EventArgs e)
        {
            var stationsTafel = transport.GetStations(comboBoxStation.Text).StationList[0].Id;
            var tafel = transport.GetStationBoard(comboBoxStation.Text, stationsTafel);
            var stationName = transport.GetStations(comboBoxStation.Text).StationList[0].Name;

            dataGridViewabfahrt.Rows.Clear();

            

            for (int i = 0; i < 4; i++)
            {
                var verbindung = transport.GetConnections(comboBoxStation.Text, tafel.Entries[i].To);
                
                dataGridViewabfahrt.Rows.Add(new string[]
                {
                    verbindung.ConnectionList[i].From.Departure.ToString(),
                    tafel.Entries[i].To.ToString(),
                    verbindung.ConnectionList[i].From.Platform.ToString(),                    
                    verbindung.ConnectionList[i].To.Delay.ToString()

                });
            }
        
        }

        private void comboBoxStation_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxStation.Text.Length > 0)
            {
                try
                {                                    
                    var station1 = transport.GetStations(comboBoxStation.Text);

                    foreach (var x in station1.StationList)
                    {
                        comboBoxStation.Items.Add(x.Name);
                    }   
                }
                catch
                {
                    MessageBox.Show("Keine gültige Station gefunden.");
                }
            }
        }
    }
}
