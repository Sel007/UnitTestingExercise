using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        //DONE
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers


        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public object Subtract(int minuend, int subtrhend)
        {
            var result = minuend - subtrhend;
            return result;
        }


        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            var result = num1 * num2;
            return result;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            var result = num1 / num2;
            return result;
        }



        // Create 2 methods that will utilize the [Fact] tests you wrote
        public int Add(int num1, int num2, int num3)
        {
            var result = num1 + num2 + num3;

            return result;
        }

    }
}
