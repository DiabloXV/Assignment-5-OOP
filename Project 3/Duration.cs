using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    public class Duration
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        // Constructor that takes hours, minutes, and seconds
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
            Normalize();
        }

        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString()
        {
            string result = "";
            if (Hours > 0)
                result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0)
                result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration d = (Duration)obj;
            return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
