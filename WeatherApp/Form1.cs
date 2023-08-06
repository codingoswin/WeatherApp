using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public readonly string Apikey = "1605d8725f4554471e687125951af67c";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Getweather();
        }

        void Getweather() 
        {
            using (var web = new WebClient()) 
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", TBCity.Text, Apikey);
                
                var response = web.DownloadString(url);

                var Info = JsonConvert.DeserializeObject<WeatherInfo.root>(response);

                
                LabDetails.Text = Info.weather[0].description;
                LabSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                LabSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                LabWindspeed.Text = Info.wind.speed.ToString();
                LabPressure.Text = Info.main.pressure.ToString();
                pictureBox.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                LabCondition.Text = Info.weather[0].main;
                LabTemp.Text = Info.main.temp.ToString();
            }
            
            DateTime convertDateTime(long sec)
            {
                var day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(sec).ToLocalTime();

                return day;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void LabSunset_Click(object sender, EventArgs e)
        {

        }
    }
}
