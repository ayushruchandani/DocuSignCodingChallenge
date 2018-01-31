using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSignCodingChallenge
{
    //Weather class is the parent class of 2 subclasses - Hot and Cold. 
    //It implements the virtual methods for each type of dress type. These methods are overrriden in the subclasses and implemented there based on weather type. 
    class Weather
    {
        //All the boolean variables for each type of dress. 
        //They are initialized to false as in the beginning none of these items are put on by the user.
        public static Boolean PutFootwear = false;
        public static Boolean PutHeadwear = false;
        public static Boolean PutSocks = false;
        public static Boolean PutShirt = false;
        public static Boolean PutJacket = false;
        public static Boolean PutPants = false;


        //Virtual methods for all types of dress. These methods are overriden by subclasses. 
        public virtual String Footwear()
        {
            return "";
        }

        public virtual String Headwear()
        {
            return "";
        }

        public virtual String Socks()
        {
            return "";
        }

        public virtual String Shirt()
        {
            return "";
        }

        public virtual String Jacket()
        {
            return "";
        }

        public virtual String Pants()
        {
            return "";
        }


        //PJs method which is called when the input character is 8. Returns 'Removing PJs' message.
        public String PJs()
        {
            return "Removing PJs, ";
        }

        //This method is called when the character 7 is encountered in input string. 
        //If all the conditions are met, i.e. all the necessary dresse are put on, it returns the message 'leaving house' otherwise returns 'fail'.
        public String LeaveHouse()
        {
            if (PutFootwear && PutHeadwear && PutSocks && PutJacket && PutPants && PutShirt)
            {
                return "leaving house.";
            }
            else
            {
                return "fail.";
            }
        }


        //This methods resets all the boolean flags at the end. It is called whenever a fail is encountered.
        //It ensures a proper execution of code in the next attempt of input. 
        public void Reset()
        {
            PutFootwear = false;
            PutHeadwear = false;
            PutSocks = false;
            PutShirt = false;
            PutJacket = false;
            PutPants = false;
        }
    }
}
