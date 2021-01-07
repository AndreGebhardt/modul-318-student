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

        private void abfarhtsTafel_Load(object sender, EventArgs e)
        {
            
        }

        private void verbindungSuchen1_Click(object sender, EventArgs e)
        {
            var verbindungen = transport.GetStationBoard(comboBoxStation.Text, comboBoxStation.Text);  

            dataGridViewabfahrt.Rows.Clear();

            dataGridViewabfahrt.Rows.Clear();

            for (int i = 0; i < 4; i++)
            {
                dataGridViewabfahrt.Rows.Add(new string[]
                {
                    verbindungen.ConnectionList[i].From.Departure.ToString(),
                    verbindungen.ConnectionList[i].Duration.ToString(),
                    verbindungen.ConnectionList[i].From.Platform.ToString(),
                    verbindungen.ConnectionList[i].To.Arrival.ToString(),
                    verbindungen.ConnectionList[i].To.Delay.ToString()

                });
            }

        private void verbindungSuchen1_TextChanged(object sender, EventArgs e)
        {
            verbindungSuchen1.Enabled = comboBoxStation.Text.Length > 0;
        }           

        private void comboBoxStation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
