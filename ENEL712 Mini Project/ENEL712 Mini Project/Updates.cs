/*
 * This partial class contains the update methods to be called into GPS_Emulator.cs
 * in order to update the showData class which outputs to the form
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENEL712_Mini_Project;

namespace ENEL712_Mini_Project
{
    public partial class Updates
    {
        /*
         * update old and new time values in the form
         */
        private void updateTime()
        {
            tBoxTime1.Text = tBoxTime2.Text;
            tBoxTime2.Text = coords.Peek()[2];
        }

        /*
         * update old and new longitude values in the form
         */
        private void updateLongitude() 
        {
            tBoxLong1.Text = tBoxLong2.Text;
            tBoxLong2.Text = coords.Peek()[0];
        }
        
        /*
         * update old and new latitude values in the form
         */
        private void updateLatitude()
        {
            tBoxLat1.Text = tBoxLat2.Text;
            tBoxLat2.Text = coords.Peek()[1];
        }

        /*
         * update total time
         */
        private void updateTotalTime(double timeDiff)
        {
            /*
             *add time difference to total time then convert it to seconds and minutes
             */
            totalTime += timeDiff;
            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            double seconds = t.Seconds;
            double minutes = Math.Abs(t.TotalMinutes);  //minutes is a absolute value

            tBoxTotalTime.Text = minutes.ToString("0") + ":" + Convert.ToString(seconds);   //display minutes and seconds
        }

        /*
         * update total distance
         */
        private void updateTotalDistance(double distDiff)
        {
            totalDist += distDiff;  //add to distance difference to current total distance
            tBoxTotalDistance.Text = (totalDist / 1000).ToString(); //conver to km and display
        }

        /*
         * update compass using bearing angle
         */
        private void updateCompass(double bearingAngle)
        {
            /*
             * use string bearing angle, string array of bearings and index to check and
             * display bearings
             */
            string[] bearings = { "NE", "E", "SE", "S", "SW", "W", "NW", "N" };
            double index = bearingAngle - 22.5;
            int index2 = 0;
            if (index < 0)
            {
                index += 360;
            }
            index2 = (int)(index / 45);  //parseInt(index / 45)in JS
            tBoxCompass.Text = (bearings[index2]);
        }

        /*
         * update distance difference and convert to string then display
         */
        private void updateDistanceDiff(double dist)
        {
            tBoxDist.Text = Convert.ToString(dist);
        }

        /*
         * update speed
         */
        private void updateSpeed(double speed)
        {
            string speedStr = speed.ToString("00.00000");
            tBoxSpeed.Text = speedStr;
        }

        /*
         * update speed chart
         */
        private void updateSpeedChart(double speed, double totalTime)
        {
            chartSpeed.Series["Speed"].Points.AddXY(totalTime, speed); //shows speed with totalTime as x variable and speed as y variable
        }
    }
}
