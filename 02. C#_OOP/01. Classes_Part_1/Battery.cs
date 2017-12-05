namespace Classes_Part_1
{
    using System;

    public class Battery
    {
        private string model { get; set; }

        private uint hoursIdle { get; set; }
        
        private uint hoursTalk { get; set; }

        public Battery()
        {

        }

        public Battery(string model, uint hoursIdle, uint hoursTalk)
        {
            this.model = model;

            this.hoursIdle = hoursIdle;

            this.hoursTalk = hoursTalk;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public uint HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public uint HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
    }
}