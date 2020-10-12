﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace OlegTielushkoProject1
{
    public partial class Part1 : Form
    {
        public Part1()
        {
            InitializeComponent();
            roll_chart.Titles.Add("Rolls Distribution");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Part2 part2 = new Part2();
            part2.ShowDialog();
            this.Close();
        }

        private void Part1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //clear input button
        private void button2_Click(object sender, EventArgs e)
        {
            //clearing input.
            this.rollCount.Text = string.Empty;
            this.seed.Text = string.Empty;
            FocusInputText();

            //clearing chart and chart data when user presses "clear"
            roll_chart.Series.Clear();
            foreach (var series in roll_chart.Series)
            {
                series.Points.Clear();
            }
            var chartarea = new ChartArea();
            roll_chart.ChartAreas.Clear();
            roll_chart.ChartAreas.Add(chartarea);
        }

        #region Private Helpers 
        //focuse the user input text back to textbox
        private void FocusInputText()
        {
            this.rollCount.Focus();
        }
        #endregion

        //build histogram button
        private void button2_Click_1(object sender, EventArgs e)
        {
            //initialize variables for dice_roll count and rand_seed for rand generator
            int dice_rolls, rand_seed;
            error_label.Text = "";

            //initialize the array to store the count for each number. 
            //Index 0 is roll 1, index 1 is roll 2 and so on.
            int[] rolls_generated = new int[] { 0, 0, 0, 0, 0, 0 };
            //1, 2, 3, 4, 5, 6 
            //- representation of die numbers 
            //under indeces

            //parse the textbox input to get the integer values. 
            //included try except block to handle parsing empty input.
            try
            {
                dice_rolls = int.Parse(rollCount.Text);
                rand_seed = int.Parse(seed.Text);
            } catch (Exception)
            {
                error_label.Text = "There has been a problem with your input! Please enter a whole number!";
                return;
            } 
            //initializing random number generator using seed given.
            Random rand = new Random(rand_seed);

            //incrementing the counters for the each index of the array
            //NOTE: index number corresponds to the roll number of the dice-1.
            
            //rolling the number of times the user asked us to roll.
            for (int i = 1; i < dice_rolls; i++)
            {
                rolls_generated[rand.Next(1, 7) - 1]++;
            }

            /****************************
             * initializing histogram   *
             ***************************/

            //creating the x-axis labels that will be put into the series.
            string[] number_series = { "1", "2", "3", "4", "5", "6" };

            /******************************************************
             * clearing chart data before creating a new chart    *
             * in case user does not press "Clear" button first.  *
             * It will remove all of the chart information before *
             * creating new rolls                                 *
             ******************************************************/
            
            //clearing series
            roll_chart.Series.Clear();

            //clearing points for each of the series.
            foreach (var series in roll_chart.Series)
            {
                series.Points.Clear();
            }

            //clearing previous chart area
            roll_chart.ChartAreas.Clear();

            //allocating new blank chart area
            var chart_area = new ChartArea();
           
            //adding the blank chart area to our chart.
            roll_chart.ChartAreas.Add(chart_area);

            /*****************************************
             * filling up the data of the histogram. *
             *****************************************/

            //initializing a series called "rolls" that identifies the count of rolls for each number
            roll_chart.Series.Add("rolls");

            /*
             * filling up the XY data of the series.
             * X - the face value on the die.
             * Y - the amount of rolls that resulted in that face of the die.
             */
            
            //going through each face of the die and adding the amount of rolls generated
            for (int j = 0; j < number_series.Length; j++)
            {
                roll_chart.Series["rolls"].Points.AddXY(number_series[j],rolls_generated[j]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
