namespace Classes_Part_1
{
    using System;

    public class GSM
    {
        private string model { get; set; }

        private string manufacturer { get; set; }

        private decimal price = 0.00M;

        private string owner = null;

        private Battery batteryCharacteristics = new Battery();

        private Display displayCharacteristics = new Display();


        public GSM ()
        {

        }

        public GSM (string model, string manufacturer)
        {
            this.model = model;

            this.manufacturer = manufacturer;
        }

        public GSM (string model, string manufacturer, decimal price, string owner,
                    string batteryModel, uint batteryHoursIdle, uint batteryHoursTalk,
                    double displaySize, uint displayNumberOfColours)
        {
            this.model = model;

            this.manufacturer = manufacturer;

            this.price = price;

            this.owner = owner;
            
            this.batteryCharacteristics.Model = batteryModel;

            this.batteryCharacteristics.HoursIdle = batteryHoursIdle;

            this.batteryCharacteristics.HoursTalk = batteryHoursTalk;

            this.displayCharacteristics.Size = displaySize;

            this.displayCharacteristics.NumberOfColours = displayNumberOfColours;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid GSM Model");
                }

                this.model = value;
            }
        }

        public string Manufacturer 
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
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
    }
}