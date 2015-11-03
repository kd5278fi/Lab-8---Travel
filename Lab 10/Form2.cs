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

        // trip info map choices 
        TripInfo mapChoices = new TripInfo(); 
        // list of regions 
        List<string> RegionsPickedList = new List<string>();

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            if (f1.travelAreas.Equals(""))
            {
                MessageBox.Show("Please selected a region to travel to. Further travel plans cannot be made until that is done", "No region selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                gobackToMain();
            }
        }

        private void gobackToMain()
        {
         //todo rewrite this is proper form.    
            this.Hide();
            f1.Show();
           // f1.Enabled = true;
            
           
        }


        // this button should record the checkboxes in order.  
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (RegionsPickedList.Count == 0)
            {
                checkBoxMidWest.BackColor = Color.Red;
                checkBoxWest.BackColor = Color.Red;
                checkBoxNorthEast.BackColor = Color.Red;
                checkBoxSouthEast.BackColor = Color.Red;
                checkBoxSouthWest.BackColor = Color.Red;

                MessageBox.Show("Please check a region to travel to ", " No Selection ");
            }
                
            else
            {
                //set the tagged information to be passed back to main. 

                // this.Tag = RegionsPickedList;

                string items = "";

                foreach (string place in RegionsPickedList)
                {
                    items += place + ",";
                }

                // this sets the tag equal to the items selected 
                

                // now to pass it to form1 ;

                // maybe implement a dictionary with set values for each possible region location available
                this.Tag = items;
                f1.travelAreas = this.Tag.ToString() ; 
                MessageBox.Show("You are traveling to " + items + "regions of the United States" );
                
            }
        }
        // pass this method each of the checkboxes and record each selection. There are 5 regions
        #region recordRegionSelection
        // the check changed property automatically records order in selected order. 
        private void checkBoxWest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWest.Checked == true)
            {
                RegionsPickedList.Add(regions.West.ToString()); 
            }
            else if (checkBoxWest.Checked == false && (RegionsPickedList.Contains(regions.West.ToString())))
            {
                RegionsPickedList.Remove(regions.West.ToString());
            }
            
        }

        private void checkBoxSouthWest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSouthWest.Checked == true)
            {
                RegionsPickedList.Add(regions.Soutwest.ToString()); 
            }
            else if (checkBoxSouthWest.Checked == false && (RegionsPickedList.Contains(regions.Soutwest.ToString())))
            {
                RegionsPickedList.Remove(regions.Soutwest.ToString());
            }
        }

        private void checkBoxMidWest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMidWest.Checked == true)
            {
                RegionsPickedList.Add(regions.Midwest.ToString());
            }
            else if (checkBoxMidWest.Checked == false && (RegionsPickedList.Contains(regions.Midwest.ToString())))
            {
                RegionsPickedList.Remove(regions.Midwest.ToString());
            }
        }

        private void checkBoxSouthEast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSouthEast.Checked == true)
            {
                RegionsPickedList.Add(regions.Southeast.ToString()); 
            }
            else if (checkBoxSouthEast.Checked == false && (RegionsPickedList.Contains(regions.Southeast.ToString())))
            {
                RegionsPickedList.Remove(regions.Southeast.ToString());
            }
        }

        private void checkBoxNorthEast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNorthEast.Checked == true)
            {
                RegionsPickedList.Add(regions.Northeast.ToString()); 
            }
            else if (checkBoxNorthEast.Checked == false && (RegionsPickedList.Contains(regions.Northeast.ToString())))
            {
                RegionsPickedList.Remove(regions.Northeast.ToString());
            }
        }
        #endregion
    }
}
public enum regions
{      
    West ,
    Soutwest ,
    Midwest ,
    Northeast ,
    Southeast ,
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









