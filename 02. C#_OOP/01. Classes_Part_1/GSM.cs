namespace Classes_Part_1
{
    using System;

    public class GSM
    {
        private string model { get; } //MANDATORY

        private string manufacturer { get; } //MANDATORY

        private decimal price = 0.00M;

        private string owner = "[none]";

        private Battery batteryCharacteristics = new Battery();

        private Display displayCharacteristics = new Display();

        public GSM (string model, string manufacturer) //MANDATORY
        {
            this.model = model;

            this.manufacturer = manufacturer;
        }

        public GSM (string model, string manufacturer, decimal price, string owner, int batteryType,
                    string batteryModel, uint batteryHoursIdle, uint batteryHoursTalk,
                    double displaySize, uint displayNumberOfColours) //OPTIONAL
        {
            this.model = model;

            this.manufacturer = manufacturer;

            this.price = price;

            this.owner = owner;

            this.batteryCharacteristics = new Battery(batteryModel, batteryHoursIdle, batteryHoursTalk, batteryType);

            this.displayCharacteristics = new Display(displaySize, displayNumberOfColours);
        }

        public GSM (string model, string manufacturer, decimal price, 
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
                        + $"Starting at: {price}$" + Environment.NewLine 
                        + $"Display: {displayCharacteristics.Size}-inch display with {displayCharacteristics.NumberOfColours} colours" + Environment.NewLine
                        + $"A {batteryCharacteristics.Type} battery: {batteryCharacteristics.HoursIdle} hours idle & {batteryCharacteristics.HoursTalk} hours talk";

            return specs;
        }
    }
}