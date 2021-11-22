/*
 * This class contains all the calculations as well as the string manipulation for
 * the GPGGA strings. It also contains the data output for the form
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using System.Data.OleDb;
using System.Device.Location;
using System.Windows.Forms.DataVisualization.Charting;

namespace ENEL712_Mini_Project
{
    public partial class Updates : Form {

        string dataIN;
        Queue<String[]> coords = new Queue<String[]>();

        /*  
         *  Initialise global Variables
         */

        string lat1 = null, lat2 = null, long1 = null, long2 = null;
        double distanceDiff;
        double timeDiff;
        double totalTime;
        double speed;
        double newDistance;
        double totalDist;
        double degreeBearing;

        /*  
         *  Initialise Updates partial class
         */
        public Updates()
        {
            InitializeComponent();
        }

        /*
         * GPS_Emulator initialising
         */
        private void GPS_Emulator_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); //gets port names into a string array
            cBoxComPort.Items.AddRange(ports);  //adds range of ports contained in the comPort
            portStatus.Text = "OFF";    //set portStatus as off
            butPortClose.Enabled = false;   //disable close port button
            chBoxAlwaysUpdate.Checked = true;   //check always update checkbox
            chBoxAddToOldData.Checked = false;  //uncheck add to aold data checkbox

        }

        /*
         * Recieved data on serial port 1
         */
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();    //store recieved data on dataIN
            this.Invoke(new EventHandler(ShowData));    //trigger show data event
        }

        /*
         * Port open button conditions
         */
        private void butPortOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;   //adds serial ports to comport combo box
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);  //adds baud rates to baud rate combo box
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);  //adds data bits to data bits combo box
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);   //adds stop bits to stop bits combo box
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);   //adds parit bits to parity bits combo box

                serialPort1.Open(); //opens serial port selected
                progressBar1.Value = 100;   //when port opens progress increases to 100


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  //error if unable to open
            }

            /*
             * If the serial port is open, set the portStatus to ON, disable portOpen button and
             * enable portClose button. Otherwise keep portStatus off
             */
            if (serialPort1.IsOpen)
            {
                portStatus.Text = "ON"; 
                butPortOpen.Enabled = false;
                butPortClose.Enabled = true;
            }
            else
            {
                portStatus.Text = "Off";

            }


        }

        //port close button
        private void butPortClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) //if serial port open
            {
                serialPort1.Close();    //close serial port
                progressBar1.Value = 0; //reduce progress bar to 0 
                portStatus.Text = "OFF";    //set port status to OFF
                butPortClose.Enabled = false;   //disable port close button
                butPortOpen.Enabled = true; //enable port open button
            }

        }

        /*
         * Clear Data in the box if it isnt empty
         */
        private void butClearDataIN_Click(object sender, EventArgs e)
        {
            if (tBoxDataLog.Text != "")
            {
                tBoxDataLog.Text = "";
            }
        }

        /*
         * get distance difference between old and new point
         */
        private double gpsDistanceDiff(string lat1, string lat2, string long1, string long2)
        {
            /*
             * convert all the input string variables to doubles
             */
            double latitude1 = Convert.ToDouble(lat1);
            double latitude2 = Convert.ToDouble(lat2);
            double longitude1 = Convert.ToDouble(long1);
            double longitude2 = Convert.ToDouble(long2);

            /*
             * set gps points using the geocoordinate functions
             */
            GeoCoordinate gpsPoint1 = new GeoCoordinate(latitude1, longitude1);
            GeoCoordinate gpsPoint2 = new GeoCoordinate(latitude2, longitude2);


            double distance;
            distance = gpsPoint1.GetDistanceTo(gpsPoint2);  //get distance from point 1 to point 2 
            return distance; //return the distance


        }

        /*
         * time difference between two data strings
         */
        private double gpsTimeDiff(string time1, string time2)
        {
            double time2Sec = TimeSpan.Parse(time2).TotalSeconds;   //convert time to seconds
            double time1Sec = TimeSpan.Parse(time1).TotalSeconds;   //conver time to seconds

            return time2Sec - time1Sec; // return time difference in seconds
        }

        /*
         * calculate gps speed
         */
        private double gpsSpeed(double timeDiff, double distDiff)
        {
            double time = Convert.ToDouble(timeDiff) / (60 * 60);   //convert time to hours
            double distance = Convert.ToDouble(distDiff)/1000;  //convert distance to kilometers
            
            double speed;
            speed = distance / time;    //calculate speed
            if (distance == 0)  //if distance is 0, speed is 0
            {
                speed = 0;
            }
            else if(time == 0)  //if there is no change in time, keep time = 1 and add distance until change in time
            {
                time = 1;
                newDistance += distance;
                speed = newDistance / time;
            }

            return speed;   //return calculated speed
        }

        /*
         * calculate degree bearing from point1 to point 2
         */
        private double gpsDegreeBearing(string lat1, string lat2, string long1, string long2)
        {
            /*
             * convert string variables to double variables
             */
            double latitude1 = Convert.ToDouble(lat1);
            double latitude2 = Convert.ToDouble(lat2);
            double longitude1 = Convert.ToDouble(long1);
            double longitude2 = Convert.ToDouble(long2);

            /*
             * calculate to bearing in radians
             */
            var dLon = ToRad(longitude2 - longitude1);
            var dPhi = Math.Log(Math.Tan(ToRad(latitude2) / 2 + Math.PI / 4) / Math.Tan(ToRad(latitude1) / 2 + Math.PI / 4));
            if (Math.Abs(dLon) > Math.PI)
            {
                dLon = dLon > 0 ? -(2 * Math.PI - dLon) : (2 * Math.PI + dLon);
            }
            return ToBearing(Math.Atan2(dLon, dPhi));

        }

        /*
         * convert to radians
         */
        public static double ToRad(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        /*
         * convert to radians
         */
        public static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        /*
         * convert to bearing
         */
        public static double ToBearing(double radians)
        {
            return (ToDegrees(radians) + 360) % 360;
        }

        /*
         * convert string to latitude
         */
        private String latitudeConversion(string latData)
        {
            string[] dataArray = dataIN.Split(','); //split string by comma

            /*
             * split string into substrings then calculate full latitude
             */
            string latitude1 = latData.Substring(0, 2); //
            string latitude2 = latData.Substring(2, 11);
            double fullLat = Convert.ToDouble(latitude1) + (Convert.ToDouble(latitude2) / 60);

            /*
             * if direction is south, latitude is negative
             * else it is positive
             */
            string vertDirection = dataArray[3];
            if(vertDirection == "S")
            {
                fullLat = fullLat * - 1;
            }
            else if(vertDirection == "N")
            {
                fullLat = Math.Abs(fullLat);
            }

            /*
             * format to 8dp and return gps latitude
             */
            string gpsLatitude = fullLat.ToString("0.00000000");
            return gpsLatitude;

        }

        /*
         * convert string to longitude
         */
        private String longitudeConversion(string longData)
        {
            /*
             * split data string by commas
             */
            string[] dataArray = dataIN.Split(',');

            /*
             * split string into substrings then calculate full longitude
             */
            string longitude1 = longData.Substring(0, 3);
            string longitude2 = longData.Substring(3, 11);
            double fullLong = Convert.ToDouble(longitude1) + (Convert.ToDouble(longitude2) / 60);

            /*
             * if direction is west longitude is negative
             * else it is positive
             */
            string horDirection = dataArray[5];
            if(horDirection == "W")
            {
                fullLong = fullLong * -1;
            } 
            else if(horDirection == "E"){
                fullLong = Math.Abs(fullLong);
            }

            /*
             * format to 8dp and return gps longitude
             */
            string gpsLongitude = fullLong.ToString("0.00000000");
            return gpsLongitude;
        }

        /*
         * convert data string to time
         */
        private String timeConversion(string timeData)
        {
            /*
             *  split time data into substrings of hours, minutes and seconds
             */
            string hour = timeData.Substring(0, 2);
            string minutes = timeData.Substring(2, 2);
            string seconds = timeData.Substring(4, 2);
            string gpsTime = hour + ":" + minutes + ":" + seconds;

            return gpsTime; //return gps time
        }

        /*
         * if always update is checked, add to old data is unchecked
         */
        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;          
            }
        }

        /*
         * if add to old data is checked, always update is unchecked
         */
        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddToOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddToOldData.Checked = true;           
            }
        }

        /*
         * all the data that needs to be displayed is in this method
         */
        private void ShowData(object sender, EventArgs e)
        {
            /*
             * display data length
             */
            int dataINLength = dataIN.Length;
            lblDataINLength.Text = string.Format("{0:00}", dataINLength);

            /*
             * split data array
             */
            string[] dataArray = dataIN.Split(',');

            /*
             * if always update is checked, both dataIn and dataLog is always updating
             * else dataIn always updates and dataLog gets new data added under previous data
             */
            if (chBoxAlwaysUpdate.Checked)
            {
                tBoxDataIN.Text = Convert.ToString(dataIN.Split('$'));  //get rid of $ sign

                tBoxDataLog.Text = dataIN;
            }
            else if (chBoxAddToOldData.Checked)
            {
                tBoxDataIN.Text = dataIN;
                tBoxDataLog.Text += Convert.ToString(dataIN.Split('$'));    //get rid of $ sign and keep adding new data under old data
                tBoxDataLog.SelectionStart = tBoxDataLog.TextLength;
                tBoxDataLog.ScrollToCaret();    //automatically scroll down as data exceeds textbox size
            } 
                

            // Place data in queue
            String[] dataToAdd = { longitudeConversion(dataArray[4]), latitudeConversion(dataArray[2]), timeConversion(dataArray[1]) };
            coords.Enqueue(dataToAdd);
            

            // Check queue size
            if (coords.Count == 1)
            {
            }
            else
            {
                // Dequeue one record, and Pop another
                String[] oldRec = coords.Dequeue();
                String[] newRec = coords.Peek();
                
                /*
                 * calculation answers using data from queue
                 */
                distanceDiff = gpsDistanceDiff(oldRec[1], newRec[1], oldRec[0], newRec[0]);
                timeDiff = gpsTimeDiff(oldRec[2], newRec[2]);
                speed = gpsSpeed(timeDiff, distanceDiff);
                degreeBearing = gpsDegreeBearing(oldRec[1], newRec[1], oldRec[0], newRec[0]);
                    
            }

            /*
             *add updated data to the form
             */
            updateTime();
            updateLongitude();
            updateLatitude();
            updateDistanceDiff(distanceDiff);
            updateTotalTime(timeDiff);
            updateSpeed(speed);
            updateTotalDistance(distanceDiff);
            updateCompass(degreeBearing);
            updateSpeedChart(speed, totalTime);

        }

        private void chartSpeed_Click(object sender, EventArgs e)
        {

        }

        private void tBoxLat2_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}