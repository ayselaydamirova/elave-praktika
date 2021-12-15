using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    static class OilStation
    {
        public static int Benzin92 { get; set; } = 1000;
        public static int BenzinPremium { get; set; } = 1000;
        public static int Dizel { get; set; } = 1000;

        
        public static int fillBenzin92(int litr)
        {
                
           if(litr < Benzin92)
            {
                Benzin92 -= litr;
                return litr;
            }

            return 0;

        }

        internal static int fillOil(string v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static int fillBenzinPremium(int litr)
        {
            if (litr < BenzinPremium)
            {
                BenzinPremium -= litr;
                return litr;
            }
            return 0;
        }
        public static int fillDizel(int litr)
        {
            if (litr < Dizel)
            {
                Dizel -= litr;
                return litr;
            }
            return 0;
        }
          
          public static int fillOil(string OilName, int oil,int MaxCapacity,int CurrentOilLitr)
        {
           if (MaxCapacity < CurrentOilLitr + oil)
            {
                Console.WriteLine($"maxcapacity {MaxCapacity} limiti kecirsiz");
                return 0;
            }

       
            if (OilName == "Benzin92")
            {
                return fillBenzin92(oil);
                   
            }
            else if (OilName == "BenzinPremium")
             {
                return fillBenzinPremium(oil);
            }

            else if (OilName== "Dizel")
            {
                return fillDizel(oil);
            }
            return 0;
        }    
          
            

         
          

      }
        
}
