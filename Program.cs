using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _74_toString_Method
{
    class Time
    {
        private int hours, minutes, seconds;
        public Time(int h, int m, int s) // 3 parameter constructor named Time/ Overloading valid
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public Time() // Default constructor named Time. Overloading Valid
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public int Hour // Hour property setting with get, set
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
            }
        }
        public int Minute // minute property setting with get, set
        {
            get
            {
                return minutes;
            }
            set
            {
                minutes = value;
            }
        }
        public int Second // second property setting with get, set
        {
            get
            {
                return minutes;
            }
            set
            {
                minutes = value;
            }
        }
        public void setTime(int h, int m, int s) // set time method takes already inst. obj. and set values for it
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public override string ToString()
        {
            return hours + ":" + minutes + ":" + seconds;
        }
        public string displayTime()
        {
            return hours + ":" + minutes + ":" + seconds;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Time theTime = new Time(18, 23, 0); // new object with default constructor Time() 
            Console.WriteLine(theTime.ToString());
            Console.WriteLine(theTime.displayTime());



        }
    }
}
