using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParsing
{
    public class SalesData
    {
        public string street, city, state, type, date;
        public int zip, sqr_feet, price;
        public short baths;
        public double latitude, longitude;

        public SalesData(string street, string city, string state, string type, string date, int zip, int sqr_feet, int price, short baths, double latitude, double longitude)
        {
            this.street = street;
            this.city = city;
            this.type = type;
            this.date = date;
            this.zip = zip;
            this.sqr_feet = sqr_feet;
            this.price = price;
            this.baths = baths;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public void PrintMetadata()
        {
            Console.WriteLine(street + "\t" + city + "\t" + state + "\t" + type + "\t" + date + "\t" + zip + "\t" + sqr_feet + "\t" + price + "\t" + baths + "\t" + latitude + "\t" + longitude);
        }
    }
}
