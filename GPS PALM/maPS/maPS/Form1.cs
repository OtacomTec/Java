using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadCellIDs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr =
                   System.IO.File.OpenText(openFileDialog1.FileName);
                string strCellIDs = sr.ReadToEnd();
                string[] cellIDs = strCellIDs.Split('\n');
                foreach (string str in cellIDs)
                {
                    lstCellIDs.Items.Add(str.Replace('\r', ' '));
                }
            }
        }

        private void lstCellIDs_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            string[] cellidFields =
                lstCellIDs.SelectedItem.ToString().Split('-');
            // [0] - CID 
            // [1] - LAC
            // [2] – MCC
            // [3] - Time

            //---Arguments for GetLatLng(MCC MNC LAC CID)---
            string[] args = { 
                cellidFields[2], // MCC 
                "0",             // MNC – don’t need it here
                cellidFields[1], // LAC
                cellidFields[0]  // CID
            };

            string[] latlng =  GoogleMaps.GMM.GetLatLng(args).Split('|');

            webBrowser1.Navigate(
                   "http://maps.google.com/maps?hl=en&q=" +
                   latlng[0].ToString().Replace(',', '.') +
                   "," + latlng[1].ToString().Replace(',', '.') +
                   "&ie=UTF8");
        }


    }
}
