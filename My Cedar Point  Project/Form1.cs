using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
    Age 
    under 7 ( 0-7) 
        Rain Storm
        Lil’ Tornado
        Snow Drift Slope
    -7-13 
      Summer Storm
      Storm Chaser
      Blizzard Slope
    > 7 
      Thunder Storm
      Storm Buster
      Avalanche Slope
    
    Temperature
        Water Park (>=74 && summer oonly)
        Amusement Park (for spring, Summer and fall)
        Storm, Buster Ski Park, Avalanche  ( only during winter) 
 */

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            //local Variables declaration
            String strName;             // Will be the  user name 
            String strSeason ;          // desired Season
            String StrPark ;            // what is going to be  the selected Park 
            String strAttraction;       // what is going to be your ride 
            int intAge=-1;              // default age
            int intTemperature;         // the actual temperature 
            //flags
            Boolean blnTooWarm = false; // temperature too warm
            Boolean blnIsError = false; // in case of error

            //Assignments
            strName = txtName.Text;
            strSeason = txtSeason.Text;
            StrPark = "";
            strAttraction = "";

            ///////////////////////////////////////  CLEAN DATA  /////////////////////////////////////////

            //Remove blank before and after the name
            strName = strName.Trim();

            //checking age label
            try
            {
                intAge = Int32.Parse(txtAge.Text);
            }
            catch (FormatException)
            {
                blnIsError = true;
                Console.WriteLine($"Unable to parse age '{txtAge.Text}' to Integer");
                MessageBox.Show("please enter a number for your age");
            }

            //checking season label
            strSeason = strSeason.Trim().ToLower();
            if (!strSeason.Equals("spring") && !strSeason.Equals("summer") && !strSeason.Equals("fall") && !strSeason.Equals("winter"))
            {
                blnIsError = true;
                Console.WriteLine("please input correct season");
                MessageBox.Show("you did not enter a valid season");
            }

            //checking temperature label
            if (!int.TryParse(txtTemperature.Text, out intTemperature))
            {
                blnIsError = true;
                Console.WriteLine($"Unable to parse temprature '{txtTemperature.Text}' to Integer");
                MessageBox.Show("Please enter a number for your temperature");
            }

            ///////////////////////////////////  BEGIN IF STRUCTURE  /////////////////////////////////////
            //Only during winter when <7 Snow Drift Slope, 7-13 Blizzard Slope, >=14 Avalanche Slope 
            if (!blnIsError)
            {
                String season = strSeason.Substring(0, 2);
                if (season.Equals("wi"))
                {
                    //Nested if/elseIf/Else
                    if (intTemperature <= 50)
                    {
                        picClosed.Visible = false;
                        picStormLand.Visible = false;
                        picAmusementPark.Visible = false;
                        picWaterPark.Visible = false;
                        picSki.Visible = true;
                        StrPark = "Ski Park";
                        if (intAge < 7)
                            strAttraction = "Snow Drift Slope";
                        else if (intAge >= 7 && intAge <= 13)
                            strAttraction = "Blizzard Slope";
                        else
                            strAttraction = "Avalanche Slope";
                    }
                    else
                    {
                        blnTooWarm = true;
                    }
                }
                else
                {
                    //Spring, Fall and  Summmer with temparature under 74 dregree
                    if (season.Equals("sp") || season.Equals("fa") || (season.Equals("su") && (intTemperature < 74)))
                    {
                        //with a switch selection
                        StrPark = "Amusement Park";
                        switch (intAge)
                        {
                            case 0:case 1: case 2: case 3:case 4:case 5:case 6:
                                strAttraction = "Lil' Tornado";
                                break;
                            case 7:case 8: case 9: case 10: case 11: case 12: case 13 :
                                strAttraction = "Storm Chaser";
                                break;
                            default:
                                strAttraction = "Storm Buster";
                                break;
                        }
                        picClosed.Visible = false;
                        picStormLand.Visible = false;
                        picSki.Visible = false;
                        picWaterPark.Visible = false;
                        picAmusementPark.Visible = true;

                    }
                    //ONLY during the summer, <7 Rain Storm, 7-13 Summmer Storm, >= 14 Thunder Storm
                    else if (season.Equals("su") && (intTemperature >= 74))
                    {
                        StrPark = "Water Park";
                        picClosed.Visible = false;
                        picStormLand.Visible = false;
                        picSki.Visible = false;
                        picWaterPark.Visible = true;
                        picAmusementPark.Visible = false;

                        //Nested if 
                        if (intAge < 7)
                            strAttraction = "Rain Storm";
                        else if (intAge >= 7 && intAge <= 13)
                            strAttraction = "Summer Storm";
                        else
                            strAttraction = "Thunder Storm";
                    }
                }
              
                //else
                //    MessageBox.Show("Let's have fun!!");

                /////////////////////////////////////  DISPLAY OUTPUT  ///////////////////////////////////////
                // if temperature is >50 in winter
                if (blnTooWarm)
                {
                    picWaterPark.Visible = false;
                    picAmusementPark.Visible = false;
                    picSki.Visible = false;
                    picStormLand.Visible = false;
                    picClosed.Visible = true;
                    lblRide.Visible = false;
                    lblPark.Visible = false;
                    MessageBox.Show(strName + " because it's " + intTemperature + " this Winter" + " Our ski Park is closed because it is too warm.");
                    picClosed.Visible = true;
                }
                else
                {
                    lblPark.Visible = true;
                    lblRide.Visible = true;

                    lblRide.Text = strAttraction;
                    lblPark.Text = StrPark;
                    if (strName.Equals(""))
                        strName ="Customer";
                    //capitalize first char of season
                    strSeason= System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(strSeason.ToLower());
                    MessageBox.Show("Hello " + strName + " ,because you are " + intAge + " years old, and  it is " + strSeason + " you should ride the " + strAttraction + " at the " + StrPark);
                }
            }  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear data
            txtName.Text = "";
            txtAge.Text = "";
            txtTemperature.Text = "";
            txtSeason.Text = "";
            lblRide.Visible = false;
            lblPark.Visible = false;
            picClosed.Visible = false;
            picStormLand.Visible = true;
            picSki.Visible = false;
            picWaterPark.Visible = false;
            picAmusementPark.Visible = false;

            //Put the focus back 
            txtName.Focus();
        }
    }

}


