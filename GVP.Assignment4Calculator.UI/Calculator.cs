using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVP.Assignment4Calculator.UI
{
    public class Calculator
    {
        //fields
    
        private float currentValue = 0; //stores the current number
        private float result = 0; 
        private string operation = ""; //stores the current arithmetic operation

        //properties

  
        public float CurrentValue {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public float Result
        {
            get { return result; }
            set { result = value; }
        }

        public string Operation {
            get { return operation; }
            set { operation = value;} 
        }

 

        //methods



        public void Addition()
        {
            currentValue += result;
            operation = "+";
            result = currentValue;


        }

        public void Substraction()
        {
            currentValue -= result;
            operation = "-";
            result = currentValue;
        }

        public void Multiplication()
        {
            currentValue *= result;
            operation = "*";
            result = currentValue;
        }


        public void Division()
        {
            if (result == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            currentValue /= result;
            operation = "/";
            result = currentValue;
        }

        public void SquareRoot()
        {
            result = (float)Math.Sqrt((float)currentValue);
            
            
            operation = "sqrt";

        }

        public void Reciprocal()
        {
            result =  1 / currentValue;
            operation = "1/X";
        }

        public void ChangeSign()
        {
            result = -currentValue;
            operation = "+/-";
        }




    }
}
