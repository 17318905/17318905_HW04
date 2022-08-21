using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17318905_HW04.Models
{
    public class MarineWildlife : Organisation
    {
       //Data Members
        public string _Cause;
        public string _Activity;


        //Constructor

        public MarineWildlife():base()
        {
            
        }
        public MarineWildlife(int ID, string Name, int YearEstablished, string Image, string Support, string OrgType, string Cause, string Activity) : base(ID, Name, YearEstablished, Image,Support,OrgType)
        {
            _Cause = Cause;
            _Activity = Activity;
        }
        //Methods
        public override string OrgDescription()
        {
            return "The " + this.Name + " organisation focused on the " + this.Cause + ". \n" +
                   "Established in " + this.YearEstablished + ", " + this.Name + "focuses on " + this.Activity + ".";
        }
        public override string ResponseDelay()
        {
            return "Should you want to get involved with "+this.Name +", please contact them on their website."+"\n"+
                "A response will be given to you within "+ Convert.ToString(CalculateResponse())+" days.";
        }

        private int CalculateResponse()
        {
            Random ResponseTime = new Random();
            int Response = ResponseTime.Next(0, 10);
            return Response;
        }



        //Properties
        public string Cause { get { return _Cause; } set { _Cause = value; } }
        public string Activity { get { return _Activity; } set { _Activity = value; } }
    }
}