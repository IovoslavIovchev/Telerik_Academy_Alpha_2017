namespace Classes_Part_1
{
    using System;
    using System.Collections.Generic;
    using Bytes2you.Validation;

    public class GSM
    {
        private string model { get; } //MANDATORY

        private string manufacturer { get; } //MANDATORY

        private decimal price = 0.00M;

        private uint cores = 0;

        private double ram = 0;

        private double storage = 0;

        private string owner = "[none]";

        private Battery batteryCharacteristics = new Battery();

        private Display displayCharacteristics = new Display();

        private static GSM iPhone4s = new GSM("iPhone 4S", "Apple", 199.99M, "Steve", 2, 1, 16, 1, "Non-Removable", 70, 16, 3.5, 16000000);

        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer) //MANDATORY
        {
            this.model = model;

            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, uint cores, double ram, double storage,
                    int batteryType, string batteryModel, uint batteryHoursIdle, uint batteryHoursTalk,
                    double displaySize, uint displayNumberOfColours) //OPTIONAL
        {
            this.model = model;

            this.manufacturer = manufacturer;

            this.price = price;

            this.owner = owner;

            this.cores = cores;

            this.ram = ram;

            this.storage = storage;

            this.batteryCharacteristics = new Battery(batteryModel, batteryHoursIdle, batteryHoursTalk, batteryType);

            this.displayCharacteristics = new Display(displaySize, displayNumberOfColours);
        }

        public GSM(string model, string manufacturer, decimal price,
                    string owner, Battery battery, Display display) //OPTIONAL
        {
            this.model = model;

            this.manufacturer = manufacturer;

            this.price = price;

            this.owner = owner;

            this.batteryCharacteristics = battery;

            this.displayCharacteristics = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Price");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.batteryCharacteristics;
            }
            set
            {
                this.batteryCharacteristics = value;
            }
        }

        public uint Cores
        {
            get
            {
                return this.cores;
            }
            set
            {
                this.cores = value;
            }
        }

        public double RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }

        public double Storage
        {
            get
            {
                return this.storage;
            }
            set
            {
                this.storage = value;
            }
        }

        public string BatteryType
        {
            get
            {
                return Battery.Description(this.Battery.Type);
            }
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryCharacteristics.Model;
            }
            set
            {
                this.batteryCharacteristics.Model = value;
            }
        }

        public uint BatteryHoursIdle
        {
            get
            {
                return this.batteryCharacteristics.HoursIdle;
            }
            set
            {
                this.batteryCharacteristics.HoursIdle = value;
            }
        }

        public uint BatteryHoursTalk
        {
            get
            {
                return this.batteryCharacteristics.HoursTalk;
            }
            set
            {
                this.batteryCharacteristics.HoursTalk = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.displayCharacteristics;
            }
            set
            {
                this.displayCharacteristics = value;
            }
        }

        public double DisplaySize
        {
            get
            {
                return this.displayCharacteristics.Size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Display Size");
                }

                this.displayCharacteristics.Size = value;
            }
        }

        public uint DisplayNumberOfColours
        {
            get
            {
                return this.displayCharacteristics.NumberOfColours;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Display Size");
                }

                this.displayCharacteristics.NumberOfColours = value;
            }
        }

        public override string ToString()
        {
            string specs = $"{owner}'s {manufacturer} {model}:" + Environment.NewLine
                        + $" - Starting at: {price:F2}$" + Environment.NewLine
                        + $" - {cores}-core CPU | {ram:F1}GB RAM | {storage}GB Internal Storage" + Environment.NewLine
                        + $" - Display: {displayCharacteristics.Size}-inch | {displayCharacteristics.NumberOfColours} colours" + Environment.NewLine
                        + $" - {batteryCharacteristics.Type} battery: {batteryCharacteristics.HoursIdle} hours Idle | {batteryCharacteristics.HoursTalk} hours Talk";

            return specs;
        }

        public static GSM iPhone4S
        {
            get
            {
                return iPhone4s;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory = new List<Call>() { };
        }

        public void AddCall(string dialedNum, uint duration, string date, string time)
        {
            Guard.WhenArgument(this.callHistory, "Call History ísn't initialized").IsNull().Throw();

            this.callHistory.Add(new Call(dialedNum, duration, date, time));
        }

        public decimal CallPrice(decimal pricePerMinute)
        {
            Guard.WhenArgument(this.callHistory, "Call History ísn't initialized").IsNull().Throw();

            decimal price = 0M;

            foreach (Call c in this.callHistory)
            {
                price += c.Duration;
            }

            price = Math.Ceiling(price / 100) * pricePerMinute;

            return price;
        }
    }
}