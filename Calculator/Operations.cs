using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        public double NormalOperation(string operation, double value1, double value2)
        {
            double result;
            // This switch statement checks what operation to execute based on the operation
            // provided from the main
            switch (operation)
            {
                case "+":
                    result = Add(value1, value2);
                    break;
                case "-":
                    result = Substract(value1, value2);
                    break;
                case "*":
                    result = Multiply(value1, value2);
                    break;
                case "/":
                    result = Divide(value1, value2);
                    break;
                case "%":
                    result = Remainder(value1, value2);
                    break;
                case "^":
                    result = Power(value1, value2);
                    break;
                case "y rt(x)":
                    result = PowerRoot(value1, value2);
                    break;
                case "b log x":
                    result = BaseLog(value1, value2);
                    break;
                
                default:
                    result = 0;
                    break;
            }
            // result is rounded by 9 decimal places and is then returned back
           // result = Math.Round(result, 9);
            return result;
        }

        public double SpecialOperation(string operation, double value)
        {
            double result;
            // This switch statement checks what special operation to execute based on the operation
            // provided from the main
            switch (operation)
            {
                case "sqrt":
                    result = SquareRoot(value);
                    break;
                case "^2":
                    result = ToSecondPower(value);
                    break;
                case "ln":
                    result = NaturalLog(value);
                    break;
                case "e^":
                    result = EPower(value);
                    break;
                case "log":
                    result = Log10(value);
                    break;
                case "sin":
                    result = Sine(value);
                    break;
                case "asin":
                    result = ArcSine(value);
                    break;
                case "cos":
                    result = Cosine(value);
                    break;
                case "acos":
                    result = ArcCosine(value);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        //For all calculations: the calculations are in a try-catch block. When an exception
        //is caught, the method will return 0. Mainly to prevent an OverflowException,
        //or a DivideByZeroException

        private double Add(double value1, double value2)
        {
            //Adds 2 values together
            try
            {
                return value1 + value2;
            }
            catch
            {
                return 0;
            }
        }

        private double Substract(double value1, double value2)
        {
            //Substracts 2 values from each other
            try
            {
                return value1 - value2;
            }
            catch
            {
                return 0;
            }
        }

        private double Divide(double value1, double value2)
        {
            //Divides 2 values with each other
            try
            {
                return value1 / value2;
            }
            catch
            {
                return 0;
            }
        }

        private double Multiply(double value1, double value2)
        {
            // Multiplies 2 values with each other
            try
            {
                return value1 * value2;
            }
            catch
            {
                return 0;
            }
        }

        private double Remainder(double value1, double value2)
        {
            //returns the remainder of value1 / value2
            try
            {
                return value1 % value2;
            }
            catch
            {
                return 0;
            }
        }

        private double Power(double value1, double value2)
        {
            // returns value1^value2
            try
            {
                return Math.Pow(value1, value2);
            }
            catch
            {
                return 0;
            }
        }

        private double PowerRoot(double value1, double value2)
        {
            //returns the value2 powerroot of value1
            try
            {
                return Math.Pow(value1, (1 / value2));
            }
            catch
            {
                return 0;
            }
        }

        private double BaseLog(double value1, double value2)
        {
            try
            {
                return Math.Log(value2, value1);
            }
            catch
            {
                return 0;
            }
        }

        private double SquareRoot(double value)
        {
            //returns the square root of a value
            try
            {
                return Math.Sqrt(value);
            }
            catch
            {
                return 0;
            }
        }

        private double ToSecondPower(double value)
        {
            //returns the 2nd power of a value
            try
            {
                return Math.Pow(value, 2);
            }
            catch
            {
                return 0;
            }
        }

        private double NaturalLog(double value)
        {
            //returns the natural logarithm of a value
            try
            {
                return Math.Log(value);
            }
            catch
            {
                return 0;
            }
        }

        private double EPower(double value)
        {
            //returns e^value
            try
            {
                return Math.Exp(value);
            }
            catch
            {
                return 0;
            }
        }

        private double Log10(double value)
        {
            // returns 10_log of value
            try
            {
                return Math.Log10(value);
            }
            catch
            {
                return 0;
            }
        }

        private double Sine(double value)
        {
            // returns the sine of value
            try
            {
                return Math.Sin(value);
            }
            catch
            {
                return 0;
            }
        }

        private double ArcSine(double value)
        {
            //returns the arc sine of value
            try
            {
                return Math.Asin(value);
            }
            catch
            {
                return 0;
            }
        }

        private double Cosine(double value)
        {
            //returns the cosine of value
            try
            {
                return Math.Cos(value);
            }
            catch
            {
                return 0;
            }
        }

        private double ArcCosine(double value)
        {
            //returns the arc cosine of value
            try
            {
                return Math.Acos(value);
            }
            catch
            {
                return 0;
            }
        }

    }
}
