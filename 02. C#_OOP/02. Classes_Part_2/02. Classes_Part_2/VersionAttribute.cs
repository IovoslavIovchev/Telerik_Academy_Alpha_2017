using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Part_2
{
    class Version : Attribute
    {
        private int major;

        private int minor;

        public Version(int major, int minor)
        {
            Guard.WhenArgument(major, "Major version").IsLessThan(0).Throw();
            Guard.WhenArgument(minor, "Minor version").IsLessThan(0).Throw();

            this.major = major;
            this.minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
        }
    }

    [Version(3, 4)]
    class Sample
    {

    }
}
