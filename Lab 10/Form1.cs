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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /* THIS PROGRAM WILL AID IN PLANNING YOU TRAVEL 
         
         * * IT CAN SUGGEST WEATHER 
         *      SUGGEST LIST OF ITEMS TO BRING
         *      EMERGENCY ROAD SIDE ASSITANCE NUMBER 
         *  //RADAR GIF -- EXTRA FEATURE 
         *  
         * // MAP -- ALREADY DONE 
         * 
         * // HOTEL -- DRAWN FROM LIST BY REGION. 
         * 
         * // GAS CALCULATOR 
         * 
         * // MILEAGE LOG 
         /*
         * /
        */



        // public values ( might later be added to structure of class) 

        public DateTime dateout;
        public DateTime dateIn;
        public List<DateTime> backUpdates = new List<DateTime>(); 
        

        /// <summary>
        /// Opens a map to select destination region 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        // map button click 
        private void btnMap_Click(object sender, EventArgs e)
        {

            Form2Map f2 = new Form2Map();
            f2.Enabled = true;
            f2.Show();


            // show dialog box. 
            //this.Hide();
           // this.Visible = false;
        }

        // closes the main window 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // when this button is clicked record the arrival and departure date for the trip 
        private void btnEnterDates_Click(object sender, EventArgs e)
        {
            // set these two days first then test them 
            DateTime dept = dateTimePickerDeparture.Value;

            DateTime comeBack = dateTimePickerReturnDate.Value;

            if (validateDateInput(dept, comeBack) == true)
            {
                // call the methods to find the departure and return date 
                getSetPickedTripDates(dateTimePickerDeparture, dateTimePickerReturnDate);

                listBoxTripDatesOrData.Items.Add("Depature Date: " + dept.ToShortDateString() + "  Return Date:" + comeBack.ToShortDateString());
                // pass down dept and comeback so that to a single method to determine both. 
                backUpdates.Add(dept); 
                backUpdates.Add(comeBack); 
                progressBar1.Value = (10);
                
                // check to see if the list contains date to enable the map and forecast button. 
            }
                if(listBoxTripDatesOrData.Items.Count >=1)
                {
                    btnMap.Enabled = true; 
                    btnForecast.Enabled = true;
                }
                else 
                {
                    btnMap.Enabled = false; 
                    btnForecast.Enabled = false; 
                }
            
        }

        // first write a method to validate data input based off of current date 

        // this method requires the data to be set already when passed in. 
        public bool validateDateInput(DateTime deptartureDate, DateTime returnDateTime)
        {
            try
            {
                // set the current dateTime to most recent value 
                DateTime thisCurrentRunningSessionDateAndtime = DateTime.Now;


                //todo get this working right. 
                if (deptartureDate > thisCurrentRunningSessionDateAndtime)
                {
                    // then do this 
                    MessageBox.Show("Check your dates you cannot depart back in time", " Hey McFly!");

                     // throw the flag 
                    return false;
                }
                else if (returnDateTime < deptartureDate)
                {
                    MessageBox.Show("Return date cannot be before departure date. Check your dates and try again ", "Invalid Date Selection"); 
    
                    // throw the flag 
                    return false;
                }
                return true;
            }
            // catch any crazy errors. 
            catch (Exception ex)
            {
                MessageBox.Show("Something went terribly wrong here while trying to retrieve the current date and time." + ex.Message + "Strack Trace:" + ex.StackTrace, "Uh, Oh");
            }

            // return true on all paths and hope of the best ! 
            return false;

        }

        // next write the method to set date and time
        public void getSetPickedTripDates(DateTimePicker go, DateTimePicker comeback)
        {
            //verbose
            dateout = Convert.ToDateTime(go.Value);
            dateIn = Convert.ToDateTime(comeback.Value);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //todo figure out why this isn't working 
            dateTimePickerReturnDate.Value = dateTimePickerReturnDate.Value.AddDays(1);
            btnMap.Enabled = false;
            btnForecast.Enabled = false;
        }

        // when this button is clicked bring up a seperate form for the gas calculator 
        private void buttonGasCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This still needs to be coded ");
        }

        /// <summary>
        /// Get s a fake forecast for the amount of days selected. Maxium forecast a 7 day Forecast
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForecast_Click(object sender, EventArgs e)
        {
            //FORECAST IMAGES 
            pbForecastDay1.Image = Properties.Resources.Sunny;
            pbForecastDay2.Image = Properties.Resources.Cloudy;
            pbForecastDay3.Image = Properties.Resources.HeavyRain;

            // FORECAST LABELS ABOVE 
            labelDescriptionDay1.Text = "Sunny";
            labelDescriptionDay2.Text = "Partly Cloudy";
            labelDescriptionDay3.Text = "Rain";

            //FORECAST LABELS BELOW 
            labelHighLowDay1.Text = " High:  \n\t Low: ";
            labelHighLowDay2.Text = " High:  \n\t Low: ";
            labelHighLowDay3.Text = " High:  \n\t Low: ";

            // TODO get random icons for weather AS WELL AS TEMPS AND DESCRIPTIONS 

            progressBar1.Value = (20); 
        }

            //Do i need to create a tag to recieve Form 2 state selection? 

            

            

        }

    }

        
    
        