using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Date
    {
        private int day, year;
        private string month;



        public Date()   //non parametric
        {
            day = 1;
            month = "dec";
            year = 2022;
        }

        public Date(int dd, string mm, int yy)  //parametric
        {
            day = dd;
            month = mm;
            year = yy;

        }

        /*
        public void SetData()
        {
            Day = 12;
            month = "may";
            year = 2021;
        }*/

        public string GetData()
        {
            return "date is: " + day + "/" + month + "/" + year;

        }

    }
}
