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
    public partial class TempatureConversions : Form
    {
        private Boolean converted = false;

        public TempatureConversions()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear it out.
            txtdegC.Text = "";
            txtdegF.Text = "";
            txtK.Text = "";
            //Mark unconverted
            converted=false;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Check if the user needs to hit clear.
            if (converted == true)
            {
                MessageBox.Show("A conversion has been preformed, hit clear before trying to convert again.", "Conversion Preformed");
                return;
            }

            //Variables For TextBox Checking
            Boolean F = false;
            Boolean C = false;
            Boolean K = false;
            short Filled = 0;

            //Check What Textboxes have been filled in
            //At the same time check what how many textboxes have been filled in.

            if (txtdegF.Text != "")
            {
                F = true;
                Filled++;
            }
            if (txtdegC.Text != "")
            {
                C = true;
                Filled++;
            }
            if (txtK.Text != "")
            {
                K = true;
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
            //Let us get conversion variables
                double TEMP = 0.00;
                double NEWTEMP = 0.00;
            //Let us convert
            if (F == true)
            {
                //We are converting from Degrees F
                TEMP = Convert.ToDouble(txtdegF.Text);
                NEWTEMP = (TEMP - 32)*(5/9);
                txtdegC.Text = Convert.ToString(Math.Round(NEWTEMP, 2));
                txtK.Text = Convert.ToString(Convert.ToDouble(txtdegC.Text) + 273.15);
                return;

            }

            if (C == true)
            {
                //We are converting from Degrees C
                TEMP = Convert.ToDouble(txtdegC.Text);
                NEWTEMP = (TEMP * (5 / 9)) + 32;
                txtdegF.Text = Convert.ToString(Math.Round(NEWTEMP, 2));
                txtK.Text = Convert.ToString(Convert.ToDouble(txtdegC.Text) + 273.15);
                return;
            }

            if (K == true)
            {
                //We are converting from Kelvin
                txtdegC.Text = Convert.ToString(Convert.ToDouble(txtK.Text) - 273.15);
                TEMP = Convert.ToDouble(txtdegC.Text);
                NEWTEMP = (TEMP * (5 / 9)) + 32;
                txtdegF.Text = Convert.ToString(Math.Round(NEWTEMP, 2));
                return;
            }
        }



        #region Validate Input 
        private void txtdegF_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtdegF.Text != "")
                {
                    if (txtdegF.Text != "-")
                    {
                        Convert.ToDouble(txtdegF.Text);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtdegF.Text = "";
            }
        }

        private void txtdegC_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtdegC.Text != "")
                {
                    if (txtdegC.Text != "-")
                    {
                        Convert.ToDouble(txtdegC.Text);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtdegC.Text = "";
            }
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            //Validate That the Text Is a Number
            try
            {
                if (txtK.Text != "")
                {
                    if (txtK.Text != "-")
                    {
                        Convert.ToDouble(txtK.Text);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers may be input into this textbox.", "Input Error");
                txtK.Text = "";
            }
        }
        #endregion

    }
}
