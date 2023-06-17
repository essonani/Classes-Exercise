using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public  class Car
    { 
        public Car() 
        { 

        }

        public Car (string MakeInput,string ModelInput,int YearInput)
        {
          Make=MakeInput;
          Model=ModelInput;
            Year = Year;
        }
            
      public string Make { get; set; }
        public string Model { get; set; }    
        public string Year { get; set; }

    }
}
