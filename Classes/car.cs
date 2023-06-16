using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public  class car
    { 
        public car() 
        { 

        }

        public car (string makeInput,string modelInput,int yearInput)
        {
          Make=makeInput;
          Model=modelInput;
            Year = Year;
        }
            
      public string Make { get; set; }
        public string Model { get; set; }    
        public string Year { get; set; }

    }
}
