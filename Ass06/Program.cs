namespace Ass06
{
    internal class Program
    {
        #region 1 - Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        public static void ChangeItemOnArrayByValue(int[] arr,int index,int numberToBeAdded)
        {

            if (arr != null) 
            { 
                arr[index] = numberToBeAdded;
            }

        }  
        public static void ChangeItemOnArrayByRef(ref int[] arr,int index,int numberToBeAdded)
        {

            if (arr != null) 
            { 
                arr[index] = numberToBeAdded;
            }

        }

        #endregion

        #region 2 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        public static void GetSummationAndSubtractingOfTwoNumbers(int num1,int num2,out int sum,out int subtract)
        {

            sum = num1 + num2;
            subtract = num1 - num2;

        }

        #endregion



        #region 3 - Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        public static void GetMinMaxArray(ref int max,ref int min, params int[] arr) 
        {

            if (arr != null)
            {

                max = arr.Max();
                min = arr.Min();


            }
        
        
        }


        #endregion




        static void Main(string[] args)
        {
            #region 1 - Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            // when passing Reference type parameter by value you actually creating a new reference type on function stack memory that refer to the same place of the original Reference type so any changes will effect on the original values that placed on heap    
            // Passing by reference you actually playing with the real object without creating new one that refer to the same place on heap 

            //int[] arr = { 1, 2, 3 };

            //Console.WriteLine(arr[0]);

            //ChangeItemOnArrayByValue(arr,0,10);
            //Console.WriteLine(arr[0]);

            //ChangeItemOnArrayByRef( ref arr, 0, 20);
            //Console.WriteLine(arr[0]);


            #endregion



            #region 2 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //GetSummationAndSubtractingOfTwoNumbers(2, 2, out int sum, out int subtract);
            //Console.WriteLine(sum);
            //Console.WriteLine(subtract);



            #endregion


            #region 3 - Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters


            int max=0, min=0;

            Console.WriteLine(max);
            Console.WriteLine(min);

            GetMinMaxArray(ref max, ref min, 50, 20, 60);


            Console.WriteLine(max);
            Console.WriteLine(min);



            #endregion
        }
    }
}
