namespace Classes_Part_1
{
    using System;
    using System.ComponentModel;

    public class Battery
    {
        private string model { get; set; }

        private uint hoursIdle { get; set; }
        
        private uint hoursTalk { get; set; }   

        private BatteryType batteryType { get; set; }     

        public static string Description (BatteryType type)
        {
            var memInfo = typeof(BatteryType).GetMember(type.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            string description = ((DescriptionAttribute)attributes[0]).Description;

            return description;
        }

        public Battery()
        {
            this.batteryType = BatteryType.Default;
        }

        public Battery(string model, uint hoursIdle, uint hoursTalk, int batteryType)
        {
            this.model = model;

            this.hoursIdle = hoursIdle;

            this.hoursTalk = hoursTalk;

            this.batteryType = (BatteryType)batteryType;
        }

        public BatteryType Type
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if ((int)value > 3)
                {
                    throw new ArgumentException("Invalid Battery Type (Must be less or equal to 3)");
                }
                this.batteryType = (BatteryType)value;
            }
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

    public enum BatteryType
    {
        [Description("[unspecified]")]
        Default,

        [Description("Li-Ion")]
        LiIon,    

        [Description("NiMH")]
        NiMH,

        [Description("NiCd")]
        NiCd
    }
}