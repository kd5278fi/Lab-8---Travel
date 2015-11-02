using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form2Map : Form
    {
        public Form2Map()
        {
            InitializeComponent();
        }

        // Form2Map f2 = new Form2Map();
        Main f1 = new Main();

        // list of regions 
        List<string> RegionsPickedList = new List<string>();

        private void btnGoBack_Click(object sender, EventArgs e)
        {

            gobackToMain();

        }

        private void gobackToMain()
        {
            this.Hide();
            f1.Show();
            f1.Enabled = true;
        }


        // this button should record the checkboxes in order.  
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // for each check box checked add them in order 
            //foreach (var cbRegion in this.Controls.OfType<CheckBox>())
            //{
            //    if (cbRegion.Checked == true)
            //    {
            //        RegionsPickedList.Add(cbRegion.Name.ToString());
            //    }
            //}
            if (RegionsPickedList.Count == 0)
            {
                checkBoxMidWest.BackColor = Color.Red;
                checkBoxWest.BackColor = Color.Red;
                checkBoxNorthEast.BackColor = Color.Red;
                checkBoxSouthEast.BackColor = Color.Red;
                checkBoxSouthWest.BackColor = Color.Red;

                MessageBox.Show("Please check a region to travel to ", " No Selection ");
                //groupBoxCheckBoxPlacesToVisit.BackColor = Color.Red;

            }

            else
            {
                //set the tagged information to be passed back to main. 

                // this.Tag = RegionsPickedList;

                string items = "" ;
                
                foreach (string place in RegionsPickedList)
                {
                    items += place + ",";
                
                }
                // maybe implement a dictionary with set values for each possible region location available

                MessageBox.Show("List of regions selected " + items);
                
            }
        }

        // pass this method each of the checkboxes and record each selection. There are 5 regions
        // must be passed in order of northwest, southwest, midwest, 
        public void methodToReadRegionSelection(CheckBox cb1, CheckBox cb2, CheckBox cb3, CheckBox cb4, CheckBox cb5)
        {


            //sample code that works 
            //if (cb1.Text.Contains("West"))
            //{
            //  string regionTester = regions.West.ToString();
            //  MessageBox.Show(" you have selected " + regionTester);
            //}
            //if (cb2.Text.Contains("Southwest") && (cb2.Checked == true))
            //{
            //    string regionTester = regions.Soutwest.ToString();
            //    MessageBox.Show("You have selected " + regionTester);
            //}
        }
        #region recordRegionSelection
        // the check changed property automatically records order in selected order. 
        private void checkBoxWest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWest.Checked == true)
            {
                RegionsPickedList.Add(regions.West.ToString()); 
            }

        }

        private void checkBoxSouthWest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSouthWest.Checked == true)
            {
                RegionsPickedList.Add(regions.Soutwest.ToString()); 
            }
        }

        private void checkBoxMidWest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMidWest.Checked == true)
            {
                RegionsPickedList.Add(regions.Midwest.ToString());
            }
        }

        private void checkBoxSouthEast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSouthEast.Checked == true)
            {
                RegionsPickedList.Add(regions.Southeast.ToString()); 
            }
        }

        private void checkBoxNorthEast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNorthEast.Checked == true)
            {
                RegionsPickedList.Add(regions.Northeast.ToString()); 
            }
        }
        #endregion



    }
}
public enum regions
{      // if it equals zero then no region selected throw an error message
    West,
    Soutwest,
    Midwest,
    Northeast,
    Southeast,
}

// this may need to be moved to another form. I was just experimenting. 
public enum weather
{
    rainy,
    cloudy,
    sunny,
    partlycloudy,
    snow,
}







