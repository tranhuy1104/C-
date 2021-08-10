using System;
using System.Collections.Generic;
using System.Text;

//The namespace School contains the class XMLComments and the Main method
namespace School
{
    /// <summary>
    /// The program demonstrates the use of XML comments.
    /// 
    /// Class XMLComments contains comments in XML format.
    /// </summary>
    class XMLComments
    {
        /// <summary>
        /// <c>Main</c> method is the entry point for a C# application
        /// 
        /// <param name="args">A list of command line arguments can be provided
        /// using <c>args</c></param>
        /// <returns>Here the return type of Main method is void</returns>
        /// </summary>
        /// <remarks>
        /// Main method can be declared with or without parameters.
        /// </remarks>
        static void Main(string[] args)
        {
            /* The WriteLine method is used to print the specified value.
             * The WriteLine method belongs to the Console class in the
             *System namespace
             */
            Console.WriteLine("This program illustrates XML Comments");
        }
    }
}
