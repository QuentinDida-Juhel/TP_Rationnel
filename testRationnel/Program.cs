﻿using Rationnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRationnel
{
    class Program
    {
        static void Main(string[] args)
        {try
            {
                SRationnel r = new SRationnel(0, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                SRationnel r = new SRationnel(5, 10);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                SRationnel r2 = new SRationnel(-2, -8);
                Console.WriteLine(r2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        } 
    }
}
 