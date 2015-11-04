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
{/* ABOUT THIS APP. THE PURPOSE OF THIS APP IS TO DEVELOP A WORKING TRAVEL APP THAT DISPLAYS ALL OF OUR WORKING KNOWLEGE OF C# PROGRAMMING 
  * UP TO THIS POINT. Include the following: arrays and collection processing, input validation and exception handling, date processing and 
  * calculations, output formats, great user experience including some graphics and maybe animation, PLUS all the default requirements such 
  * as good GUI layout, tabbing, Enter and Esc keys, object/control naming, and documentation!
  */

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


        #region globalvariables 
        // public values ( might later be added to structure of class) 

        public DateTime dateout;
        public DateTime dateIn;
        
        public List <string> areasTavelingTo = new List<string>();  
        public string travelAreas = ""; 
        public List<DateTime> backUpdates = new List<DateTime>();
        public List<string> listSource = new List<string>();

        public string travelDates = "";
        // seasons picked and taken into account for the weather 
        public string seas ;

        public List<Image> ForeCastImagesBasedOnSeaons = new List<Image> { Properties.Resources.Cloudy,Properties.Resources.Sunny,Properties.Resources.Partly_Cloudy,Properties.Resources.LightRain, Properties.Resources.HeavyRain, Properties.Resources.Windy, Properties.Resources.Flurries,Properties.Resources.SleetSnow, Properties.Resources.Snow} ;
        #endregion
      
        // map button click 
        private void btnMap_Click(object sender, EventArgs e)
        {
             
            Form2Map f2 = new Form2Map();
            f2.Enabled = true;
            f2.ShowDialog();

            DialogResult selectedbutton = f2.DialogResult;
            if (selectedbutton == DialogResult.OK)
            {
                this.travelAreas = f2.Tag.ToString();
                MessageBox.Show("Selected travel Areas " + this.travelAreas);
            }

            // show dialog box. 
            //this.Hide();
            //this.Visible = false;
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

                listBoxTripDatesOrData.Items.Add("Depature Date: " + dept.ToShortDateString() + "  Return Date: " + comeBack.ToShortDateString());
                lblTripDates.Text = ("Depature Date: " + dept.ToShortDateString() + "  Return Date: " + comeBack.ToShortDateString());
               // listSource.Add("Departure Date: " + dept.ToShortDateString() + "  Return Date: " + comeBack.ToShortDateString());
               
                // pass down dept and comeback so that to a single method to determine both. 
                backUpdates.Add(dept); 
                backUpdates.Add(comeBack);
               
              //  copyListcontents(listBoxTripDatesOrData); 
                progressBar1.Value = (10);
            //    listSource = listBoxTripDatesOrData.Items.ToString(); 
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

            // call the method to set the seasons. 
                getSeason(dept, seas);
                getSeason(comeBack, seas);

                copyListcontents(listBoxTripDatesOrData); 

            
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
                if (deptartureDate.AddSeconds(20) < thisCurrentRunningSessionDateAndtime)
                {
                    // then do this 
                    MessageBox.Show("Check your dates you cannot go back in time.", " Hey McFly!");
                    // throw the flag 
                    return false;
                }
                else if (returnDateTime < deptartureDate)
                {
                    MessageBox.Show("Return date cannot be before departure date. Check your dates and try again ", "Invalid Date Selection"); 
                    // throw the flag 
                    return false;
                }
                else if (deptartureDate == thisCurrentRunningSessionDateAndtime)
                {
                    return true;
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

        // Main for Load settings. 
        private void Main_Load(object sender, EventArgs e)
        {
            // loads the map button and forecast button disabled until dates are entered. 
            dateTimePickerReturnDate.Value = dateTimePickerReturnDate.Value.AddDays(1);
            btnMap.Enabled = false;
            btnForecast.Enabled = false;
          //  listBoxTripDatesOrData.DataSource = listSource; 
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
        
        // travel gear 
        List<String> summerGear = new List<string> () { "Swim trunks","sun tan lotion", "shorts", "dress warm", "sandals", "shorts" } ;

        List<string> winterGear = new List<string>() {"Heavy winter coat", "gloves", "stocking cap" , "long johns" } ;

        List<string> rainGear = new List<string> () { "Umbrella","rain boots","prepare for rain"} ;

        // season info 
        // Spring March - June
        // Summer June - September 
        // Fall September - December 
        // winter December - March 
        
        // only needs to pass in one datetime. Can set both the start trip date and finish trip date season. run this method for each date.
        public void getSeason(DateTime dtValue, string nameOfVariable)
        {
             string weatherSetter = ""; 
            // spring conditions
            if (dtValue.Month <= 3 && dtValue.Day <= 21 || dtValue.Month <= 6 && dtValue.Day >=22)
            {
                weatherSetter  += seasons.Spring.ToString() + ""; 
            }
            //summer
            else if  (dtValue.Month >= 6  || dtValue.Month <= 8)
            {
                weatherSetter += seasons.Summer.ToString(); 
            }
                //fall 
            else if (dtValue.Month >=9 || (dtValue.Month <= 12 && dtValue.Day <=22))
	        {
                weatherSetter += seasons.Fall.ToString() + "";
            }
                //winter
            else if (dtValue.Month >=1  || dtValue.Month >= 3)
            {
                weatherSetter += seasons.Winter.ToString() + "";
            }
        }

  
        // this method will recieve the seasons set by range of dates entered. 
        public void setPossibleWeatherIcons(string seasonGlobalVariable,List<Image> listOfWeatherPics)
        {
            if (seasonGlobalVariable.Contains("Summer"))
            {
                // no snow or flurries or temps below 60 degrees
                
                // weather icon range 0,7
                // temp range 60, 102
                //pic avaialable 
                
            }
            // else // weather icon range 0,9 
            // temp range 0, 23 

        }

        private void btnMap_MouseHover(object sender, EventArgs e)
        {
            e.ToString();
        }

        public void copyListcontents(ListBox datesListbox)
        {
            if (datesListbox.Items.Count == -1)
            {
                // do nothing because there is nothing in the list. 
            }
            else
            {
               
                {
                    listSource.Add(datesListbox.Items.ToString());
                }
            }
        }

        private void buttonTripSummary_Click(object sender, EventArgs e)
        {
            // display the trip summary. 
            MessageBox.Show( 
        }
        
        // the plan is to have the date by now and recieve the regions selection from the user. 
   
        // temps based on season of trip. 

        // suggested travel gear for trip: 

        // save trip data to a file / word document 
    }
    
    }



enum seasons 
{
     Spring,
     Summer, 
     Fall, 
     Winter
}

 