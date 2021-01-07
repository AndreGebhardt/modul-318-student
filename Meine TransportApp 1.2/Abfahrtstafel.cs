using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meine_TransportApp_1._2
{
    public partial class abfahrt : Form
    {
        Transport transport = new Transport();

        public abfahrt()
        {
            InitializeComponent();
        }

        
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxName.Text))
            {
                List<Station> stations = transport.GetStations(comboBoxName.Text).StationList;
                if (stations.Count > 0)
                {
                    comboBoxName.Items.Clear();
                    foreach (Station station in stations)
                    {
                        comboBoxName.Items.Add(station.Name);
                    }
                }
                comboBoxName.Text = "";
                comboBoxName.SelectedIndex = 0;
            }
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {

        }

        private void tafel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
