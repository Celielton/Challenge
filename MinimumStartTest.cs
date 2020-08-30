using NUnit.Framework;
using System.Linq;

namespace BackendEngineer
{
    /**
     Start with an initial guess for x, an integer, and a given array of integers. 
     Calculate a running sum of x plus each array element, from left to right. 
     The running sum must never get below 1.  
     Given an array of integers, determine the minimum value of x. 

     For example, arr = [-2, 3, 1, -5].  If x = 4, the following results are obtained:
             
             Running     
        sum         arr[i]
        ---------   --------
        4           -2
        2            3
        5            1
        6           -5
        1
     The final value is 1, and the running sum has never dropped below 1.  
     The minimum starting value for x is 4.

    Complete the function MinimumStart below. The function must return the minimum integer value for x.

    MinimumStart has the following parameter(s):
        arr[arr[0],...arr[n-1]]:  an array of integers
    
    Constraints
        1 ≤ n ≤ 1000000
        −100 ≤ arr[i] ≤ 100
     */
    public class MinimumStartTest
    {
        /**
         * Running     
            sum         arr[i]
            ---------   --------
            4           -2
            2            3
            5            1
            6           -5
            1
            
            The minimum starting value for x is 4.
         */
        [Test]
        public void MinimumStart_Sample1()
        {
            var input = new[] { -2, 3, 1, -5 };
            var output = MinimumStart(input);
            Assert.AreEqual(4, output);
        }

        /**
         * sum       arr[i] 
            --------- -------- 
            8           -5
            3            4
            7           -2
            5            3
            8            1
            9           -1
            8           -6
            2           -1
            1            0
            1            5
            6
            The minimum starting value for x is 8.
         */
        [Test]
        public void MinimumStart_Sample2()
        {
            var input = new[] { -5, 4, -2, 3, 1, -1, -6, -1, 0, 5 };
            var output = MinimumStart(input);
            Assert.AreEqual(8, output);
        }

        /**
         * Running 
            sum       arr[i] 
            --------- -------- 
            6         -5
            1          4
            5         -2
            3          3
            6          1
            7           
            The minimum starting value for x is 6.
         */
        [Test]
        public void MinimumStart_Sample3()
        {
            var input = new[] { -5, 4, -2, 3, 1 };
            var output = MinimumStart(input);
            Assert.AreEqual(6, output);
        }

        /**
         * Running 
            sum         arr[i] 
            ---------   -------- 
            13          -5
             8           4
            12          -2
            10           3
            13           1
            14          -1
            13          -6
             7          -1
             6           0
             6          -5
             1
            The minimum starting value for x is 13.
         */
        [Test]
        public void MinimumStart_Sample4()
        {
            var input = new[] { -5, 4, -2, 3, 1, -1, -6, -1, 0, -5 };
            var output = MinimumStart(input);
            Assert.AreEqual(13, output);
        }

        /**
         * Running 
            sum         arr[i] 
            ---------   -------- 
             1           0
             1           3
             4 
            The minimum starting value for x is 1.
         */
        [Test]
        public void MinimumStart_Sample5()
        {
            var input = new[] { 0, 3 };
            var output = MinimumStart(input);
            Assert.AreEqual(1, output);
        }

        /**
         * Running 
            sum         arr[i] 
            ---------   -------- 
             -2           5
             3           -2
             1 
            The minimum starting value for x is -2.
         */
        [Test]
        public void MinimumStart_Sample6()
        {
            var input = new[] { 5, -2 };
            var output = MinimumStart(input);
            Assert.AreEqual(-2, output);
        }

        private static int MinimumStart(int[] input)
        {
            var guess = -100;
            var sum = guess;


            for (var i = 0; i < input.Length; i++)
            {
                if (sum + input[i] < 1)
                {
                    guess++;
                    sum = guess;
                    i = -1;
                }
                else
                {
                    sum += input[i];
                }
            }



            //do
            //{
            //    guess++;
            //    sum = guess;
            //    sum += input.Aggregate((i, j) => i + j);
            //    //for (var i = 0; i < input.Length; i++)
            //    //{
            //    //    sum += input[i];
            //    //}
            //} while (sum < 1);

            return guess;
        }
    }
}