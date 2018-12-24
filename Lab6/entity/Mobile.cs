using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6.entity
{
    public class Mobile
    {

        private string manufacturer;
        private MobileInfo mobileInfo;

        public Mobile()
        {
        }

        public Mobile(string manufacturer, MobileInfo mobileInfo1)
        {
            Manufacturer = manufacturer;
            MobileInfo1 = mobileInfo1;
        }

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        internal MobileInfo MobileInfo1 { get => mobileInfo; set => mobileInfo = value; }

        public override bool Equals(object obj)
        {
            var mobile = obj as Mobile;
            return mobile != null &&
                   Manufacturer == mobile.Manufacturer &&
                   EqualityComparer<MobileInfo>.Default.Equals(MobileInfo1, mobile.MobileInfo1);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Manufacturer, MobileInfo1);
        }

        public override string ToString()
        {
            return "Mobile: manufacturer - " + Manufacturer + ", " + MobileInfo1.ToString();
        }

        public class MobileInfo
        {
            private string model;
            private List<string> properties;

            public string Model { get => model; set => model = value; }
            public List<string> Properties { get => properties; set => properties = value; }

            public MobileInfo()
            {
            }

            public MobileInfo(string model, List<string> properties)
            {
                Model = model;
                Properties = properties;
            }

            public override bool Equals(object obj)
            {
                var info = obj as MobileInfo;
                return info != null &&
                       Model == info.Model &&
                       EqualityComparer<List<string>>.Default.Equals(Properties, info.Properties);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Model, Properties);
            }

            public override string ToString()
            {
                string properties = "";
                foreach(String st in Properties)
                {
                    properties += st + ", ";
                }
                return "Mobile Info: model - " + Model + ", properties - " + properties;
            }
        } 
    }
}
