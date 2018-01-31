using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocuSignCodingChallenge
{
    public partial class Dresser : Form
    {
        public Dresser()
        {
            InitializeComponent();
        }


        //Method called on Button Click which sends the input to the main implementer class which implements the entire logic.

        private void button1_Click(object sender, EventArgs e)
        {
            String weather = "";
            String result = "";
            if(radioButton1.Checked == true)
            {
                weather = radioButton1.Text;
            }
            else if(radioButton2.Checked == true)
            {
                weather = radioButton2.Text;
            }
            //The string of numeric digits is fetched from the Textbox.
            String numericInput = textBox1.Text;
            //If the string is empty, print a message to prompt user to enter the input.
            if (numericInput.Trim().Equals(String.Empty))
                result = "Please enter an input";
            // if string is not empty, call the input evaluation function in the Implementer class. 
            else
                result = Implementer.evaluateInput(weather, numericInput);


            //print the obtained output in the label present on the Windows Form. 
            label5.Text = result;
        }
    }
}
