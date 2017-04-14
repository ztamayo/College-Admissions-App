// Zailyn Tamayo
// College Admissions App
// 2 November 2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Admissions_App
{
    public partial class Form1 : Form
    {
        // Test score results
        int SATscore, ACTscore;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void processButton_Click(object sender, EventArgs e)
        {

            // Check if user selected a major
            if (programComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a Program.");
            }

                // Check for Pre College Education
                if ((HSradioButton.Checked == false) & (GEDradioButton.Checked == false) &
                    (NoneRadioButton.Checked == false))
                {
                    MessageBox.Show("Pre College Education Required.");
                }

                // None radio button selected
                if (NoneRadioButton.Checked == true)
                {
                    MessageBox.Show("Admission Denied.");
                }

                // If a degree is selected, automatic admission
                if
                    (BAradioButton.Checked == true | MASradioButton.Checked == true |
                    PhDradioButton.Checked == true)
                {
                    MessageBox.Show("Admission Granted!");
                }

                // If no degree but some college or other experience
                else if
                    (HSradioButton.Checked == true | GEDradioButton.Checked == true |
                    CollegeRadioButton.Checked == true | WEradioButton.Checked == true |
                    LRradioButton.Checked == true | FBradioButton.Checked == true) 
                {
                    // Check if Test Scores meet admission standards
                    if ((SATscore >= 1000) || (ACTscore >= 15))
                    {
                        MessageBox.Show("Admission Granted!");
                    }
                    // If Test Scores too low, deny admission
                    else if ((SATscore <= 1000) || (ACTscore <= 15))
                    {
                        MessageBox.Show("Admission Denied.");
                    }
                }


            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit application
            this.Close();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset all fields
            programComboBox.SelectedIndex = -1;
            HSradioButton.Checked = false;
            GEDradioButton.Checked = false;
            NoneRadioButton.Checked = false;
            CollegeRadioButton.Checked = false;
            BAradioButton.Checked = false;
            MASradioButton.Checked = false;
            PhDradioButton.Checked = false;
            WEradioButton.Checked = false;
            FBradioButton.Checked = false;
            LRradioButton.Checked = false;
            SATcheckBox.Checked = false;
            ACTcheckBox.Checked = false;
            SATscore = 0;
            ACTscore = 0;
            SATtextBox.Text = SATscore.ToString();
            ACTtextBox.Text = ACTscore.ToString();
           
        }

        private void SATtextBox_TextChanged(object sender, EventArgs e)
        {

            // Convert text to integer
            SATscore = int.Parse(SATtextBox.Text);

        }

        private void ACTtextBox_TextChanged(object sender, EventArgs e)
        {

            // Convert text to integer
            ACTscore = int.Parse(ACTtextBox.Text);

        }
    
}
}  