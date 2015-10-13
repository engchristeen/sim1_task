using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim1_task
{
   public static class main
    {  //Number of Customers
        public static double[] NumberOfCustomers;

        //Inter Arrival Time
        public static double[] ProbabilityArrival;
        public static double[] CummulativeProbability;
        public static int[] RandomArrival_BigTable;
        public static int[] RandomArrival;
        public static int[] InterArrival; 

        public static int[] NewInterArrival; 
        public static int [] NewArrival; 

        //Service Time
        public static double[] ProbabilityService;
        public static double[] CummulativeService;
        public static int[] RandomService;
        public static int[] InterArrivalService;//new service time
        public static int[] RandomService_BigTable;
        public static int[] Arrival;

        //Generate Random 
        public static void Generate_Random()
        {
            Random r = new Random();
            for (int i = 0; i < NumberOfCustomers.Length-2; i++)
            {
               // RandomArrival[i] = r.Next(1,Convert.ToInt32(NumberOfCustomers));
                RandomArrival[i] = r.Next(1,100);
            }
        }
        
        public static void Generate_Random_Service()
        {
            Random r_service = new Random();
            for (int i = 0; i < NumberOfCustomers.Length-2; i++)
            {
               // RandomService[i] = r_service.Next(1, Convert.ToInt32(NumberOfCustomers));
                RandomService[i] = r_service.Next(1,100);
            }
        }

        

        //Calculate Arrival :
        public static void Calculate_Arrival()
        {
            for (int i = 0; i < NumberOfCustomers.Length; i++)
            {
                if (i == 0)
                {
                    NewArrival[i] = 0;
                }
                else
                {
                    NewArrival[i] = NewArrival[i - 1] + InterArrival[i-1];
                }
            }

        }
    }
}



    

