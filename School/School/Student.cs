/*
 *Student
 *
 *Copyright 2007 aptech Software Limited. All rights reserved.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    /// <summary>
    /// Student class stores and display the details ò students
    /// using different data types.
    /// </summary>
    class Student
    {
        /// <summary>
        /// the entry point for the applycation.
        /// </summary>
        /// <param name="args">A list of command line arguments</param>
        static void main(string[] args)
        {
            //Declaring and intialising variable to store student details
            int studenID = 1;
            string studentName = "David George";
            byte age = 18;
            char gender = 'M';
            float percent = 75.50F;
            bool pass = true;

            //Displaying the studentt details
            Console.WriteLine("Student ID : {0}", studenID);
            Console.WriteLine("Student Name {0}", studentName);
            Console.WriteLine("Age : ", +age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0:f2}", percent);
            Console.WriteLine("Passed : {0}", pass);


        }
    }
}
