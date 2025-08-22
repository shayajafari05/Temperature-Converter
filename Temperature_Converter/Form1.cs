using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class frmTemperature : Form
    {
        int TempF, TempC;
        public frmTemperature()
        {
            InitializeComponent();
        }

        private void vsbTemp_Scroll(object sender, ScrollEventArgs e)
        {
            // Read F and convert to C
            TempF = vsbTemp.Value;
            lblTempF.Text = Convert.ToString(TempF);
            TempC = Convert.ToInt32((TempF - 32) * 5 / 9);
            lblTempC.Text = Convert.ToString(TempC);


            // Read F and convert to C
            TempF = vsbTemp.Value;
            lblTempF.Text = Convert.ToString(TempF);
            TempC = Convert.ToInt32((TempF - 32) * 5 / 9);
            lblTempC.Text = Convert.ToString(TempC);
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Temperature Conversion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult iReset;
            iReset = MessageBox.Show("Confirm if you want to reset", "Temperature Conversion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iReset == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void frmTemperature_Load(object sender, EventArgs e)
        {

        }
    }
}
