using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Byte_Conversions BC = new Byte_Conversions();
            BC.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempatureConversions TC = new TempatureConversions();
            TC.ShowDialog();
        }
    }
}
