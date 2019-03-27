using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayCalc.Services
{
    //Class to do the array manipulation
    public class ArrayOperator
    {
        //Function to reverse the array
        public void Reverse(int[] arrayElements)
        {
            if(arrayElements!=null && arrayElements.Count()>0)
            {
                int arrayLength = arrayElements.Length;
                //looping until half the length of the array
                for (int i = 0; i < arrayLength/ 2; i++)
                {
                    //swapping the array elements to reverse the array
                    int temp = arrayElements[i];
                    arrayElements[i] = arrayElements[arrayLength - i - 1];
                    arrayElements[arrayElements.Count() - i - 1] = temp;                    
                }
            }
        }

        // Function to remove the elements at the position 
        public int[] RemoveElementAt(int position, int[] arrayElements)
        {            
            for (int a = position-1; a < arrayElements.Length - 1; a++)
            {
                //moving the element by 1 after the position
                arrayElements[a] = arrayElements[a + 1];
            }
            //resizing the array
            Array.Resize(ref arrayElements, arrayElements.Length - 1);
      
            return arrayElements;
            
        }
    }
}
