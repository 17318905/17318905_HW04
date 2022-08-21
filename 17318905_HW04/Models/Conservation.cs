using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17318905_HW04.Models
{
    public class Conservation : Organisation
    {
        //Data Members
        public string _Agenda;


        //Constructor

        public Conservation():base()
        {
           
        }
        public Conservation(int ID, string Name, int YearEstablished, string Image, string Support,string OrgType, string Agenda) : base(ID, Name, YearEstablished, Image, Support, OrgType)
        {
            _Agenda = Agenda;
        }


        //Method
        public override string OrgDescription()
        {
            return "The " + this.Name + " organisation focused on the " + this.Agenda + ". \n" +
                   "Established in " + this.YearEstablished + ". ";
        }
        public override string ResponseDelay()
        {
            return "Should you want to get involved with " + this.Name + ", please contact them on their website." + "\n" +
                "A response will be given to you within " + Convert.ToString(CalculateResponse()) + " days.";
        }

        private int CalculateResponse()
        {
            Random ResponseTime = new Random();
            int Response = ResponseTime.Next(0, 12);
            return Response;
        }



        //Properties
        public string Agenda { get { return _Agenda; } set { _Agenda = value; } }
    }
}