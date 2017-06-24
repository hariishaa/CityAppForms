using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.DTO
{
    // todo: remove this classes
    // todo: remove resource string 'json'
    public class Company
    {
        //public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
        //public Geometry[] geometries { get; set; }
    }

    public class Properties
    {
        public string id { get; set; }
        public Companymetadata CompanyMetaData { get; set; }
        //public string description { get; set; } ???????????????????????????
        //public string name { get; set; }
        //public float[][] boundedBy { get; set; }
        //public string[] attributions { get; set; }
    }

    public class Companymetadata
    {
        public string id { get; set; }
        public string name { get; set; }
        //public int[][] nameHighlight { get; set; }
        public string address { get; set; }
        public string url { get; set; }
        public Category[] Categories { get; set; }
        //public Chain[] Chains { get; set; }
        public Phone[] Phones { get; set; }
        //public Geo Geo { get; set; }
        public Feature[] Features { get; set; }
        public Link[] Links { get; set; }
        public Hours Hours { get; set; }
        //public Snippet Snippet { get; set; }
    }

    //public class Geo
    //{
    //    public string precision { get; set; }
    //}

    public class Hours
    {
        public Availability[] Availabilities { get; set; }
        public string text { get; set; }
        //public int tzOffset { get; set; }
    }

    public class Availability
    {
        public bool Everyday { get; set; }
        public bool TwentyFourHours { get; set; }
        public Interval[] Intervals { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
    }

    public class Interval
    {
        public string from { get; set; }
        public string to { get; set; }
    }

    //public class Snippet
    //{
    //    public string[] FeatureSet { get; set; }
    //}

    public class Category
    {
        public string _class { get; set; }
        public string name { get; set; }
        //public int[][] nameHighlight { get; set; }
    }

    //public class Chain
    //{
    //    public string id { get; set; }
    //    public string name { get; set; }
    //}

    public class Phone
    {
        public string type { get; set; }
        public string formatted { get; set; }
        public string country { get; set; }
        public string prefix { get; set; }
        public string number { get; set; }
    }

    public class Feature
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public Value[] values { get; set; }
        public bool value { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class Link
    {
        public string type { get; set; }
        public string href { get; set; }
        public string aref { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }
    }
}
