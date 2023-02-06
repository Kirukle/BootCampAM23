using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public static class Storing //static means it only holds code... not for an object!
    {
        //making a method...
        public static void DemoVariables()
        {
            int employeeID = 42; //whole number, no decimals
            uint income = 78; //unsigned.... only positive!
            long bigNumber = 34762462464626;
            float pi = 3.14159f; //can also use double or decimal;
            string employeeName = "Ty"; //store up to 2GB
            bool isRich = false; //true or false
            char firstIntial = 'T';

            employeeID++;

            Console.WriteLine ("Your name is {0} and your first intial is {1} and your income is {2}", employeeName, firstIntial, income);
        }
    }
}
