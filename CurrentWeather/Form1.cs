using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentWeather
{
    public partial class Form1 : Form
    {
        readonly string BaseUrl = "http://weather-csharp.herokuapp.com/";

        /* Instantiation of the array that will be used for the ComboBox. It doesn't matter what 
         * order they're listed in because the ComboBox is set to automatically alphebetize it */
        readonly string[] stateAbbreviations = new string[] {"AL", "AK", "AZ", "AR", "CA", "CO", "CT",
            "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI",
            "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR",
            "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // I opted to use a ComboBox to reduce the amount of needed validation
            cbxState.Items.AddRange(stateAbbreviations);
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            btnGetWeather.Enabled = false;

            // Added trim to make output (hopefully) look better
            string city = txtCity.Text.Trim();
            string state = cbxState.Text;

            if (LocationDataValid(city, state))
            {
                if (GetWeatherText(city, state, out string weather, out string textErrorMessage))
                {
                    lblWeather.Text = weather;
                }
                else
                {
                    MessageBox.Show(textErrorMessage, "Error");
                } 

                if (picWeather.Image != null)
                {
                    picWeather.Image.Dispose();
                }

                if (GetWeatherImage(city, state, out Image image, out string imageErrorMessage))
                {
                    picWeather.Image = image;
                }
            }
            else
            {
                MessageBox.Show("Please enter both city and state", "Error");
            }

            btnGetWeather.Enabled = true;
        }

        private bool GetWeatherText(string city, string state, out string weatherText, out string errorMessage)
        {
            string weatherTextUrl = String.Format("{0}text?city={1}&state={2}", BaseUrl, city, state);
            Debug.WriteLine(weatherTextUrl);

            errorMessage = null;
            weatherText = null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    weatherText = client.DownloadString(weatherTextUrl);
                }

                Debug.WriteLine(weatherText);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                errorMessage = e.Message;
                return false;
            }
        }

        private bool LocationDataValid(string city, string state)
        {

            if (String.IsNullOrWhiteSpace(city))
            {
                return false;
            }

            if (String.IsNullOrWhiteSpace(state))
            {
                return false;
            }

            return true;
        }

        private bool GetWeatherImage(string city, string state, out Image weatherImage, out string errorMessage)
        {
            weatherImage = null;
            errorMessage = null;

            try
            {
                using (WebClient client = new WebClient())
                {
                    string weatherPhotoUrl = String.Format("{0}photo?city={1}&state={2}", BaseUrl, city, state);
                    string tempFileDirectory = Path.GetTempPath().ToString();
                    String weatherFilePath = Path.Combine(tempFileDirectory, "weather_image.jpeg");
                    Debug.WriteLine(weatherFilePath);
                    client.DownloadFile(weatherPhotoUrl, weatherFilePath);
                    weatherImage = Image.FromFile(weatherFilePath);
                }
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                errorMessage = e.Message;
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
