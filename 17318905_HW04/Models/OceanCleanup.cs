using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17318905_HW04.Models
{
    public class OceanCleanup : Organisation
    {
        //Data Members
        public string _Plan;
        public string _Method;
        public string _Actions;

        //Constructor

        public OceanCleanup():base()
        {

        }
        public OceanCleanup(int ID, string Name, int YearEstablished, string Image, string Support,string Orgtype, string Plan, string Method, string Actions) : base (ID, Name, YearEstablished,Image,Support,Orgtype)
        {
            _Plan = Plan;
            _Method = Method;
            _Actions = Actions;

        }

        //Methods
        public override string OrgDescription()
        {
            return "The " + this.Name + " organisation focused on the " + this.Plan + ". \n" +
                   "Established in " + this.YearEstablished + ", " + this.Name + "focuses on " + this.Actions + ".";
        }
        public override string ResponseDelay()
        {
            return "Should you want to get involved with " + this.Name + ", please contact them on their website." + "\n" +
                "A response will be given to you within " + Convert.ToString(CalculateResponse()) + " days.";
        }

        private int CalculateResponse()
        {
            Random ResponseTime = new Random();
            int Response= ResponseTime.Next(0,16);
            return Response;
        }


        //Properties
        public string Plan { get { return _Plan; } set { _Plan = value; } }
        public string Method { get { return _Method; } set { _Method = value; } }
        public string Actions { get { return _Actions; }  set { _Actions = value; } }

    }
}