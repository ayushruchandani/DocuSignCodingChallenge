using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSignCodingChallenge
{
    //Class cold which inherits from the Weather class. 
    //It overrides the vitual methods present in Weather class and implements logic in those methods. 
    //Its object is created in the Implementer class of type Weather, if the selected weather is COLD.
    class Cold : Weather
    {
        //overriden pants method which returns 'pants' if the pants are not put on, otherwise returns fail. 
        //It is called when 6 is encountered in the numeric input string array. 
        public override String Pants()
        {
            if (!PutPants)
            {
                PutPants = true;
                return "pants, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Jacket method which returns 'jacket' if the jacket is not put on, otherwise returns fail. 
        //It is called when 5 is encountered in the numeric input string array. 
        public override String Jacket()
        {
            if (!PutJacket)
            {
                PutJacket = true;
                return "jacket, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Shirt method which returns 'shirt' if the shirt is not put on, otherwise returns fail. 
        //It is called when 4 is encountered in the numeric input string array. 
        public override String Shirt()
        {
            if (!PutShirt)
            {
                PutShirt = true;
                return "shirt, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Socks method which returns 'socks' if the socks are not put on, otherwise returns fail. 
        //It is called when 3 is encountered in the numeric input string array. 
        public override String Socks()
        {
            if (!PutSocks)
            {
                PutSocks = true;
                return "socks, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Headwear method which returns 'hat' if the hat is not put on and shirt is put on, otherwise returns fail. 
        //It is called when 2 is encountered in the numeric input string array. 
        public override String Headwear()
        {
            if (PutShirt && !PutHeadwear)
            {
                PutHeadwear = true;
                return "hat, ";
            }
            else
            {
                return "fail.";
            }
        }

        //overriden Footwear method which returns 'boots' if the footwaer is not put on and socks and pants are put on, otherwise returns fail. 
        //It is called when 1 is encountered in the numeric input string array. 
        public override String Footwear()
        {
            if (PutSocks && PutPants && !PutFootwear)
            {
                PutFootwear = true;
                return "boots, ";
            }
            else
            {
                return "fail.";
            }
        }


    }
}
