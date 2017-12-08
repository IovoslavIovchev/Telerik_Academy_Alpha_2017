namespace Classes_Part_1
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;

    class Call
    {
        private string dialedNum;
 
        private uint duration;

        private DateTime date;

        private DateTime time;

        private List<Call> callHistory;

        public Call(string dialedNum, uint duration, string date, string time)
        {
            this.dialedNum = dialedNum;

            this.duration = duration;

            this.date = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            this.time = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
