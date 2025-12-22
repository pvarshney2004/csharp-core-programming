using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_03
{
    internal class OTPNumber
    {
        /*
Write a program to generate a six-digit OTP number using Math.Random() method.
Validate the numbers are unique by generating the OTP number 10 times and ensuring all
the 10 OTPs are not the same
Hint =>
a. Write a method to Generate a 6-digit OTP number using Math.Random()
b. Create an array to save the OTP numbers generated 10 times
c. Write a method to ensure that the OTP numbers generated are unique. If unique
return true else return false
         */

        public int GenerateOTP()
        {
            Random r = new Random();
            // for 6-digit OTP
            return r.Next(100000, 1000000); 
        }

        public bool ValidateOTPs(int[] otps)
        {
            for(int i=0; i<otps.Length; i++)
            {
                for(int j=i+1; j<otps.Length; j++)
                {
                    if (otps[i]==otps[j])
                    {
                        return false;
                    }
                }
            }
            // if tru returned, then all otps are unique
            return true;
        }

        

    }
}
