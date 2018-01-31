using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSignCodingChallenge
{
    // Implementer class is the main implementation class which fetches the input and performs activity based on the input. 
    //It is called from the Dresser class when the button is clicked.
    public class Implementer
    {
        //evaulateInput function fetches the input, and performs the basic checking. 
        public static String evaluateInput(String weather, String numericInput)
        {
            //commas in the numeric input string are replaced with spaces. 
            numericInput = numericInput.Replace(",", string.Empty);
            //numeric input string is split from spaces and stored in an array.
            String[] numArray = numericInput.Split(' ');
            StringBuilder result = new StringBuilder();
            Weather weatherType;

            //creating the object of weather class based on what type of weather is selected by the user. 
            if (weather.Equals("HOT"))
            {
                weatherType = new Hot();
            }
            else
            {
                weatherType = new Cold();
            }

            //making sure if the first character in the string is 8. If not, returning fail directly. 
            if (!numArray[0].Equals("8"))
            {
                return "fail.";
            }
            //otherwise appending text 'removing PJs to the output string. 
            else
            {
                result.Append(weatherType.PJs());
            }

            //checking the input string from the second character onwards till the end
            for(int i = 1; i < numArray.Length; i++)
            {
                //check if the current character is 1
                if (numArray[i].Equals("1"))
                {
                    result.Append(weatherType.Footwear());
                }
                //check if the current character is 2.
                else if (numArray[i].Equals("2"))
                {
                    result.Append(weatherType.Headwear());
                }
                //check if current character is 3
                else if (numArray[i].Equals("3"))
                {
                    result.Append(weatherType.Socks());
                    //if current character is 3 and the weather is Hot, returning the string directly with fail message as socks are not required in Hot weather. 
                    if (weatherType is Hot)
                    {
                        weatherType.Reset();
                        return result.ToString();
                    }
                }
                //check if current character is 4
                else if (numArray[i].Equals("4"))
                {
                    result.Append(weatherType.Shirt());
                }
                //check if current character is 5.
                else if (numArray[i].Equals("5"))
                {
                    result.Append(weatherType.Jacket());
                    //if current character is 5 and weather is Hot, returning the string directly with fail message as jacket is not required in Hot weather. 
                    if (weatherType is Hot)
                    {
                        weatherType.Reset();
                        return result.ToString();
                    }
                }
                //check if current character is 6
                else if (numArray[i].Equals("6"))
                {
                    result.Append(weatherType.Pants());
                }
                //check if current character is 7
                else if (numArray[i].Equals("7"))
                {
                    result.Append(weatherType.LeaveHouse());
                }
                //if any of the other characters appear apart from those mentioned above, append a fail message to the output string and return the output string. 
                else
                {
                    result.Append("fail.");
                    weatherType.Reset();
                    return result.ToString();
                }
            }

            weatherType.Reset();
            //Return the output string. This string will be printed on the Windows Form. 
            return result.ToString();

        }

    }
}
