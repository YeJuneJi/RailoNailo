using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailoNailo
{
    class Weather
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string howWeather;

        public string HowWeather
        {
            get { return howWeather; }
            set { howWeather = value; }
        }

        private double press;

        public double Press
        {
            get { return press; }
            set { press = value; }
        }

        private double temp;

        public double Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        private double maxtemp;

        public double Maxtemp
        {
            get { return maxtemp; }
            set { maxtemp = value; }
        }

        private double mintemp;

        public double Mintemp
        {
            get { return mintemp; }
            set { mintemp = value; }
        }
    }
}
