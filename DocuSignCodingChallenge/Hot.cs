using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSignCodingChallenge
{
    //Class Hot which inherits from the Weather class. 
    //It overrides the vitual methods present in Weather class and implements logic in those methods. 
    //Its object is created in the Implementer class of type Weather, if the selected weather is HOT.
    class Hot : Weather
    {
        //Initializing the socks and jacket boolean variables as true when the Hot object is created since they are not required in Hot weather.
        public Hot()
        {
            PutSocks = true;
            PutJacket = true;
        }

        //overriden pants method which returns 'shorts' if the shorts are not put on, otherwise returns fail. 
        //It is called when 6 is encountered in the numeric input string array. 
        public override String Pants()
        {
            if (!PutPants)
            {
                PutPants = true;
                return "shorts, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Jacket method which returns 'fails' when 5 is encountered in input string as Jacket is not required in Hot weather. 
        public override String Jacket()
        {
            return "fail.";
        }

        //overriden Shirt method which returns 't-shirt' if the t-short is not put on, otherwise returns fail. 
        //It is called when 4 is encountered in the numeric input string array. 
        public override String Shirt()
        {
            if (!PutShirt)
            {
                PutShirt = true;
                return "t-shirt, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Socks method which returns 'fail' if 3 is encountered in input string as socks are not required in Hot weather. 
        public override String Socks()
        {
            return "fail.";
        }

        //overriden Headwear method which returns 'sun visor' if the it is not put on and shirt is put on, otherwise returns fail. 
        //It is called when 2 is encountered in the numeric input string array. 
        public override String Headwear()
        {
            if(PutShirt && !PutHeadwear)
            {
                PutHeadwear = true;
                return "sun visor, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Footwear method which returns 'sandals' if the sandal is not put on and socks and pants are put on, otherwise returns fail. 
        //It is called when 1 is encountered in the numeric input string array. 
        public override String Footwear()
        {
            if(PutSocks && PutPants && !PutFootwear)
            {
                PutFootwear = true;
                return "sandals, ";
            }
            else
            {
                return "fail.";
            }
        }

    }
}
