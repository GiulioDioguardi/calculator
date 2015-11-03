using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //all number data are double types
        double result = 0;
        double value1 = 0;
        double value2 = 0;
        string operation = "";
        //determines if number is a new entry
        bool isNewEntry = true;
        //determines if buttonResult is lastly pressed
        bool resultPressed = false;
        //determines if an operator button is lastly pressed
        bool operatorPressed = false;
        //creates an object from a class from an external file that contains
        //all calculations 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            operatorPressed = false;
            //if resultButton was previously pressed clear the operation string
            //otherwise do nothing. This results in re-parsing value1 when an operation is
            //chosen
            if (resultPressed)
            {
                operation = "";
                label1.Text = operation;
                resultPressed = false;
            }
            Button b = (Button)sender;
            //If a number is a new entry, overwrite the contents of the textbox with
            // the pressed number. Otherwise, concatenate it to the existing contents
            if (isNewEntry)
            {
                isNewEntry = false;
                //If the decimal comma is the first button to be pressed, don't just
                // overwrite with a comma, but with a 0 before it. 
                switch (b.Text)
                {
                    case  ",":
                        textBox1.Text = "0,";
                        break;
                    default:
                        textBox1.Text = b.Text;
                        break;
                }
            }
            else
            {
                textBox1.Text += b.Text;
            }
            //To prevent being 2 commas inside the textbox, pressing its button
            //causes it to be disabled. If any other button was pressed it's re-enabled
            //again.
            if (b.Text == ",")
                buttonDecimal.Enabled = false;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //For all operations: if an operation is not yet chosen:
            //parse text in calculator to value1, and assign an operation, set a new entry
            // else: do a calculation based on the previous operation and reassign new 
            //operation. The chosen operation will be displayed in a label on the left
            //side of the textbox.

            //If an operator button is pressed, this if-statement prevents the code 
            //from running again when another operator button is pressed except for
            //re-assigning it.
            if (!operatorPressed)
            {
                operatorPressed = true;
                if (operation == "")
                {
                    value1 = double.Parse(textBox1.Text, CultureInfo.GetCultureInfo("nl-NL").NumberFormat);
                    isNewEntry = true;
                    buttonDecimal.Enabled = true;
                }
                else
                {
                    //In this if statement it is checked if the resultButton was previously
                    //pressed. If it isn't, do a calculation based on the previous operator and assign an operation
                    //if it wasn't, do nothing, but setting resultPressed to false, and assign a new operation
                    //this is to prevent calculating one more time when an operator button was pressed
                    //after repeated pressing of the result button. 
                    if (!resultPressed)
                    {
                        value2 = double.Parse(textBox1.Text, CultureInfo.GetCultureInfo("nl-NL").NumberFormat);
                        result = Operations.NormalOperation(operation, value1, value2);
                        textBox1.Text = result.ToString(CultureInfo.GetCultureInfo("nl-NL").NumberFormat);
                    }
                    else
                    {
                        resultPressed = false;
                    }
                    value1 = result;
                    isNewEntry = true;
                    buttonDecimal.Enabled = true;
                }
            }
            operation = b.Text;
            label1.Text = b.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Sets all values and operations to initial state
            value1 = 0;
            value2 = 0;
            result = 0;
            operation = "";
            label1.Text = "";
            isNewEntry = true;
            buttonDecimal.Enabled = true;
            resultPressed = false;
            operatorPressed = false;
            textBox1.Text = "0";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            //Calculates the result based on the previously chosen operation and 
            //parsed numbers.
            //Repeated pressing results in repeating the calculation

            //if buttonResult was previously pressed value2 must remain the same.
            //else, parse it from the textbox.
            
            if (!resultPressed)
                value2 = double.Parse(textBox1.Text, CultureInfo.GetCultureInfo("nl-NL").NumberFormat);
            result = Operations.NormalOperation(operation, value1, value2);
            textBox1.Text = result.ToString(CultureInfo.GetCultureInfo("nl-NL").NumberFormat);
            //to get the repeated calculation going, value1 is set to the previous
            //result.
            value1 = result;
            isNewEntry = true;
            buttonDecimal.Enabled = true;
            //this boolean is checked for whether buttonResult was last pressed.
            resultPressed = true;
            operatorPressed = false;
        }

        private void buttonSpecialOperation_Click(object sender, EventArgs e)
        {
            //this event handler is for special operations, like square root, or 
            // to 2nd power, that only require one value input. Clicking it will also
            //cause to directly calculate the operation. 
            //If a previous calculation was waiting to be calculated before, press the resultButton
            //first before calculating a special operation.
            //If you don't do that, the input for this special operation won't be the result of the previous
            //calculation, but whatever is in the textbox.
            Button b = (Button)sender;
            operatorPressed = false;
            operation = b.Text;
            isNewEntry = true;
            buttonDecimal.Enabled = true;
            resultPressed = true;
            label1.Text = b.Text;
            value2 = double.Parse(textBox1.Text, CultureInfo.GetCultureInfo("nl-NL").NumberFormat);
            result = Operations.SpecialOperation(operation, value2);
            textBox1.Text = result.ToString(CultureInfo.GetCultureInfo("nl-NL").NumberFormat);
            value1 = result;
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            //creates form2 where there are more advanced operations are availible.
            Form f2 = new Form2();
            f2.Show();
        }
    }
}
