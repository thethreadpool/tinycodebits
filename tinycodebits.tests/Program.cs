using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//make the following changes to the test project properties
//add the name of the project as a debug command line argument e.g., oceandrive.maglisse.tests.csproj
//set the working dir to point to the test project folder

namespace tinycodebits.Tests
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //uncomment to run all tests in this assembly in debug mode
           //RunNUnitConsoleRunner(args);

            //uncommment to run selected tests in debug mode
            RunSelectedTests();
        }

        static void RunNUnitConsoleRunner(string[] args)
        {
            NUnit.ConsoleRunner.Runner.Main(args);
        }

        static void RunSelectedTests()
        {
            CardDeckTests cardTests = new CardDeckTests();
            cardTests.TestDeckShuffle();

            CirclesTests circleTest = new CirclesTests();
            circleTest.TestCirclesIntersects();
        }
    }
}
