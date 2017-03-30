using System;
using System.Windows.Forms;
using System.IO;

namespace LBS
{
    public partial class Form1 : Form
    {
        Timer t;
        //---log file for CellID data---
        const string FILE_NAME = @"\CellIDs.txt";
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
            sw = new StreamWriter(FILE_NAME, true,
            System.Text.Encoding.ASCII);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer()
            {
                Interval = 2000,   //---fired every 2 seconds
                Enabled = true
            };
            t.Tick += new EventHandler(t_Tick);
        }

        void t_Tick(object sender, EventArgs e)
        {
            string cellid = RIL.GetCellTowerInfo();
            string txt = cellid + "-" + DateTime.Now.ToString();

            //---display in textbox control---
            lblCellID.Text = txt;

            //---write to file---           
            sw.WriteLine(txt);
            sw.Flush();
        }


        private void mnuStart_Click(object sender, EventArgs e)
        {
            t.Enabled = true;
            sw = new StreamWriter(FILE_NAME, true,
                System.Text.Encoding.ASCII);
        }
    }
}