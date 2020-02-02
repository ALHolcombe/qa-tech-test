using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcsHomework.Helpers
{
    class DataTools
    {
        public int PivotIndex(int[] arr)
        {
            int i, j, n;
            n = arr.Length;
            int leftsum, rightsum;

            /* Check for indexes one by  
             one until an equilibrium 
            index is found */
            for (i = 0; i < n; ++i)
            {

                // initialize left sum 
                // for current index i 
                leftsum = 0;

                // initialize right sum 
                // for current index i 
                rightsum = 0;

                /* get left sum */
                for (j = 0; j < i; j++)
                    leftsum += arr[j];

                /* get right sum */
                for (j = i + 1; j < n; j++)
                    rightsum += arr[j];

                /* if leftsum and rightsum are 
                 same, then we are done */
                if (leftsum == rightsum)
                    return i;
            }

            /* return -1 if no equilibrium  
             index is found */
            return -1;


        }

        public void RowToArray(IWebElement row)
        {
          

        }


    }
}
