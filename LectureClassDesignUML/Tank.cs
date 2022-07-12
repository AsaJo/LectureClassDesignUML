using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureClassDesignUML
{
    internal class Tank
    {
        // All members(states or behaviors are privated as default)
        // States

       public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArithmeticException("cant be Null");
                }
                else
                {
                    name = value;
                }
            }
        }
      // States
        // Fields  
        string engine;       //default value for a string is null/ bool default value false
        string name;
        bool enginIsOn;
        int crew;            //default value for a int is 0
        string gun;

     // behavior

        // Construtor(s)
        public Tank(string name ,int crew,string gun)
        {
           
           this.crew = crew;
           this.gun = gun;
           Name = name;
            
            
        }

        //Methods
        public string Drive()
        {
            if (enginIsOn)//(enginIsOn == true)
            {
                return $"you are driving you {name} tank";
            }
            else
            {
                return $"you are not driving";
            }
        }
        public string StartEngin() 
        {
            if (enginIsOn)
            {
                return "Engin is alredy on";
            }
            else
            {
                enginIsOn = true;
                return "the engin start and makes noise Brummm Brummm";
            }
            
        }   
    }
}
