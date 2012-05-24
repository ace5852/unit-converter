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
    public partial class Byte_Conversions : Form
    {
        public Boolean Converted = false;

        public Byte_Conversions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reset Converion Checker
            Converted = false;
            //Clear TextBoxes
            txtBytes.Text = "";
            txtKB.Text = "";
            txtMB.Text = "";
            txtGB.Text = "";
            txtTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check if the user needs to hit clear.
            if (Converted == true)
            {
                MessageBox.Show("A conversion has been preformed, hit clear before trying to convert again.", "Conversion Preformed");
                return;
            }

            //Variables For TextBox Checking
            Boolean B = false;
            Boolean KB = false;
            Boolean MB = false;
            Boolean GB = false;
            Boolean TB = false;
            short Filled = 0;

            //Check What Textboxes have been filled in
            //At the same time check what how many textboxes have been filled in.

            if (txtBytes.Text != "")
            {
                B = true;
                Filled++;
            }
            if (txtKB.Text != "")
            { 
                KB = true;
                Filled++;
            }
            if (txtMB.Text != "") 
            {
                MB = true;
                Filled++;
            }
            if (txtGB.Text != "") 
            {
                GB = true;
                Filled++;
            }
            if (txtTB.Text != "") { 
                TB = true;
                Filled++;
            }

           //Notify User About Conversion order if necessary.
            if (Filled > 1)
            {
                MessageBox.Show("You have input more than one piece of data. This program will only convert from the piece of data closest to the top.", "More than one piece of data");
            }
            //The user did enter data, right?
            if (Filled == 0)
            {
                MessageBox.Show("You forgot to enter data to convert!", "No Data");
                return;
            }
            //Let us convert
            if (B == true)
            {
                //We are converting from bytes
                txtKB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtBytes.Text) / 1024, 2));
                txtMB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtKB.Text) / 1024, 2));
                txtGB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtMB.Text) / 1024, 2));
                txtTB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtGB.Text) / 1024, 2));
                //Mark it as Converted So The User Must Click Clear
                Converted = true;
                return;
            }

            if (KB == true)
            {
                //We are converting from kilobytes
                txtBytes.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtKB.Text) * 1024, 2));

                txtMB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtKB.Text) / 1024, 2));
                txtGB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtMB.Text) / 1024, 2));
                txtTB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtGB.Text) / 1024, 2));
                //Mark it as Converted So The User Must Click Clear
                Converted = true;
                return;
            }

            if (MB == true)
            {
                //We are converting from megabytes
                txtKB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtMB.Text) * 1024, 2));
                txtBytes.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtKB.Text) * 1024, 2));

                txtGB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtMB.Text) / 1024, 2));
                txtTB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtGB.Text) / 1024, 2));
                //Mark it as Converted So The User Must Click Clear
                Converted = true;
                return;
            }

            if (GB == true)
            {
                //We are converting from gigabytes
                txtMB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtGB.Text) * 1024, 2));
                txtKB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtMB.Text) * 1024, 2));
                txtBytes.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtKB.Text) * 1024, 2));

                txtTB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtGB.Text) / 1024, 2));
                //Mark it as Converted So The User Must Click Clear
                Converted = true;
                return;
            }

            if (TB == true)
            {
                //We are converting from terabytes
                txtGB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtTB.Text) * 1024, 2));
                txtMB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtGB.Text) * 1024, 2));
                txtKB.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtMB.Text) * 1024, 2));
                txtBytes.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtKB.Text) * 1024, 2));
                //Mark it as Converted So The User Must Click Clear
                Converted = true;
                return;
            }


        }

        #region Number Validation
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtBytes.Text != "")
                {
                    Convert.ToDouble(txtBytes.Text);
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtBytes.Text = "";
            }


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtKB.Text != "")
                {
                    Convert.ToDouble(txtKB.Text);
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtKB.Text = "";
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtMB.Text != "")
                {
                    Convert.ToDouble(txtMB.Text);
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtMB.Text = "";
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtGB.Text != "")
                {
                    Convert.ToDouble(txtGB.Text);
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtGB.Text = "";
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtTB.Text != "")
                {
                    Convert.ToDouble(txtTB.Text);
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtTB.Text = "";
            }
        }
        #endregion
    }
}
