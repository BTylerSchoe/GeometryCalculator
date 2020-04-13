/*************************************************************************************
 * Program Name:             Space Eaters Geometry Calculator
 * 
 * Program Author:           Brayden Schoenau
 * 
 * Date:                     01/10/2018
 * 
 * Description:              A small windows form application that asks for user input of either
 *                           Length or Width of a rectangle and calculates the Area and perimeter
 *                           or a radius and calculates the Area and Circumference and displays it for the user in
 *                           a text box. 
 * 
 * **********************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NICE_SpaceEaters_WindowsForm
{
    public partial class frmSpaceEatersGeometryCalculator : Form
    {
        public frmSpaceEatersGeometryCalculator()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbCircularCalculator_CheckedChanged(object sender, EventArgs e)
        {
            // If the circular button is currently checked
            if (rdbCircularCalculator.Checked)
            {
                // Hide the label for length prompt.
                lblLengthPrompt.Hide();
                // Hide the label for width prompt.
                lblWidthPrompt.Hide();
                // Hide the text box for length value.
                txtLegthValue.Hide();
                // Hide the text box for width value.
                txtWidthValue.Hide();
                // Hide the label for calculated rectangular area.
                lblRectangularArea.Hide();
                // Hide the label for rectangular area display.
                lblRectangularAreaDisplay.Hide();
                // Hide the label for the rectangular perimeter.
                lblRectangularPerimeter.Hide();
                // Hide the label for calculated Perimeter display.
                lblRectangularPerimeterDisplay.Hide();
                // Show the label for Radius prompt
                lblRadiusPrompt.Show();
                // Show the text box for radius value.
                txtRadiusValue.Show();
                // Show the label for circular area.
                lblCircularArea.Show();
                // Show the label for circular area display. 
                lblCircularAreaDisplay.Show();
                // Show the label for the circular circumference.
                lblCircularCircumference.Show();
                // Show the label for the circular circumference display.
                lblCircularCircumferenceDisplay.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmSpaceEatersGeometryCalculator_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbRectangularCalculator_CheckedChanged(object sender, EventArgs e)
        {
                // Hide the label for the Radius prompt.
                lblRadiusPrompt.Hide();
                // Hide the label for the Radius value.
                txtRadiusValue.Hide();
                // Hide the label for the circular area.
                lblCircularArea.Hide();
                // Hide the label for the cicular area display.
                lblCircularAreaDisplay.Hide();
                // Hide the label for the cicular circumference.
                lblCircularCircumference.Hide();
                // Hide the label for the cicular circumference display.
                lblCircularCircumferenceDisplay.Hide();
                // Show the label for the length prompt.
                lblLengthPrompt.Show();
                // Show the label for the width prompt.
                lblWidthPrompt.Show();
                // Show the label for the length value.
                txtLegthValue.Show();
                // Show the text box for the width value.
                txtWidthValue.Show();
                // Show the label for the Rectangular area.
                lblRectangularArea.Show();
                // Show the label for the Rectangular Area display.
                lblRectangularAreaDisplay.Show();
                // Show the label for the Rectangular perimeter.
                lblRectangularPerimeter.Show();
                // Show the label for Rectangular Perimeter display.
                lblRectangularPerimeterDisplay.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // initiate and assign userLength double variable to 0.
            double userLength = 0.0;
            // initiate and assign userWidth double variable to 0.
            double userWidth = 0.0;
            // initiate and assign calculatedRectangularArea double variable to 0.
            double calculatedRectangularArea = 0.0;
            // initiate and assign alculatedRectangularPerimeter double variable to 0.
            double calculatedRectangularPerimeter = 0.0;
            // initiate and assign userRadius double variable to 0.
            double userRadius = 0.0;
            // initiate and assign calculatedCircularArea double variable to 0.
            double calculatedCircularArea = 0.0;
            // initiate and assign calculatedCircularCircumference double variable to 0.
            double calculatedCircularCircumference = 0.0;


            // If radio button rectangular is check.
            if (rdbRectangularCalculator.Checked)
            {
                // if txt.LengthValue is numeric output it to userLength.
                if (double.TryParse(txtLegthValue.Text, out userLength) == false)
                {
                    // If user input is not a valid numeric entry, display error message "Please ensure input is numeric".
                    MessageBox.Show("Please ensure input is numeric");
                    // Set focus to Length Text Box so user can re-enter valid input.
                    txtLegthValue.Focus();
                }

                // Check to see if user entered width is a valid numeric entry.
                else if (double.TryParse(txtWidthValue.Text, out userWidth) == false)
                {
                    // If user input is not a valid numeric entry, display error message "Please ensure input is numeric".
                    MessageBox.Show("Please ensure input is numeric");
                    // Set focus to Width Text Box so user can re-enter valid input.
                    txtWidthValue.Focus();
                }
                // If both user entries are numeric.
                else
                {
                    // Set calculatedRectangularArea variable equal to userLength times userWidth rounded to 2 decimal places.
                    calculatedRectangularArea = Math.Round(userLength * userWidth, 2);
                    // Set calculatedRectangularPerimeter variable equal to userLength times 2 plus userWidth times 2, rounded to 2 decimal places.
                    calculatedRectangularPerimeter = Math.Round((userLength * 2) + (userWidth * 2), 2);
                    // Set lblRectangularAreaDisplay.Text equal to calculatedRectangularArea variable.
                    lblRectangularAreaDisplay.Text = calculatedRectangularArea.ToString();
                    // Set lblRectangularPerimeterDisplay.Text equal to calculatedRectangularPerimeter variable.
                    lblRectangularPerimeterDisplay.Text = calculatedRectangularPerimeter.ToString();
                }

            }
            // If radio button Circular is checked.
            else if (rdbCircularCalculator.Checked)
            {
                // If txtRadiusValue.Text is numeric, output it to userRadius
                if (double.TryParse(txtRadiusValue.Text, out userRadius) == false)
                {
                    // If user input is not a valid numeric entry, display error message "Please ensure input is numeric".
                    MessageBox.Show("Please ensure input is numeric");
                    // Set focus to Radius Text Box so user can re-enter valid input.
                    txtRadiusValue.Focus();
                }
                // If user entries are numeric
                else
                {
                    // Set calculatedCircularArea equal to Pi times radius squared, rounded to 2 decimal places.
                    calculatedCircularArea = Math.Round(Math.PI * (Math.Pow(userRadius, 2)), 2);
                    // Set calculatedCircularCircumference equal to 2 times Pi times Radius, rounded to 2 decimal places.
                    calculatedCircularCircumference = Math.Round(2 * Math.PI * userRadius, 2);
                    // Set lblCircularAreaDisplay.Text equal to calculatedCircularArea variable.
                    lblCircularAreaDisplay.Text = calculatedCircularArea.ToString();
                    // Set lblCircularCircumferenceDisplay.Text equal to calculatedCircularCircumference variable.
                    lblCircularCircumferenceDisplay.Text = calculatedCircularCircumference.ToString();
                }
            }
            // If the user has not selected either "Rectangular" or "Circular" radio button
            else
            {
                // Display error message "Please select either rectangular or circular."
                MessageBox.Show("Please select either rectangular or circular.");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Set radio button "Circular" to false.
            rdbCircularCalculator.Checked = false;
            // Set Radio button "Rectangular: to false.
            rdbRectangularCalculator.Checked = false;

            // Show the label for Radius prompt
            lblRadiusPrompt.Show();
            // Show the text box for radius value.
            txtRadiusValue.Show();
            // Show the label for circular area.
            lblCircularArea.Show();
            // Show the label for circular area display. 
            lblCircularAreaDisplay.Show();
            // Show the label for the circular circumference.
            lblCircularCircumference.Show();
            // Show the label for the circular circumference display.
            lblCircularCircumferenceDisplay.Show();


            // Show the label for the length prompt.
            lblLengthPrompt.Show();
            // Show the label for the width prompt.
            lblWidthPrompt.Show();
            // Show the label for the length value.
            txtLegthValue.Show();
            // Show the text box for the width value.
            txtWidthValue.Show();
            // Show the label for the Rectangular area.
            lblRectangularArea.Show();
            // Show the label for the Rectangular Area display.
            lblRectangularAreaDisplay.Show();
            // Show the label for the Rectangular perimeter.
            lblRectangularPerimeter.Show();
            // Show the label for Rectangular Perimeter display.
            lblRectangularPerimeterDisplay.Show();



            // Set txtLegthValue.Text value to empty string.
            txtLegthValue.Text = "";
            // Set txtRadiusValue.Text value to empty string.
            txtRadiusValue.Text = "";
            // Set txtWidthValue.Text value to empty string.
            txtWidthValue.Text = "";
            // Set lblCircularAreaDisplay.Text value to empty string.
            lblCircularAreaDisplay.Text = "";

            // Set lblCircularCircumferenceDisplay.Text value to empty string.
            lblCircularCircumferenceDisplay.Text = "";
            // Set lblRectangularAreaDisplay.Text value to empty string.
            lblRectangularAreaDisplay.Text = "";
            // Set lblRectangularPerimeterDisplay.Text value to empty string.
            lblRectangularPerimeterDisplay.Text = "";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
