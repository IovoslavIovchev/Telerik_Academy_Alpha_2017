namespace Classes_Part_1
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;

    public class Call
    {
        private string dialedNum;

        private uint duration;

        private DateTime date;

        private DateTime time;

        public Call(string dialedNum, uint duration, string date, string time)
        {
            this.dialedNum = dialedNum;

            this.duration = duration;

            this.date = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            this.time = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNum;
            }
        }

        public uint Duration
        {
            get { return this.duration; }
        }

        public string Date
        {
            get
            {
                return this.date.ToString("dd-MM-yyyy");
            }
        }

        public string Time
        {
            get
            {
                return this.time.ToString("HH:mm:ss");
            }
        }
    }
}
