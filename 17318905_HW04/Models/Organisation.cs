using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17318905_HW04.Models
{
    public abstract class Organisation
    {
        public int _ID;
        public string _Name;
        public int _YearEstablished;
        public string _Support;
        public string _Image;
        public string _OrgType;

        //Default Constructor

        public Organisation()
        {

        }
        public Organisation(int ID, string Name, int YearEstablished,string Image, string Support,string OrgType)
        {
            _ID = ID;
            _Name = Name;
            _YearEstablished = YearEstablished;
            _Image = Image;
            _Support = Support;
            _OrgType = OrgType;
        }
      

        //Methods
        public abstract string OrgDescription();
        public abstract string ResponseDelay();
        
        //Properties
        public int ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public int YearEstablished { get { return _YearEstablished; } set { _YearEstablished = value; } }
        public string Image { get { return _Image; } set { _Image = value; } }
        public string Support { get { return _Support; } set { _Support = value; } }
        public string Orgtype { get { return _OrgType; } set { _Support = value; } }
    }
}