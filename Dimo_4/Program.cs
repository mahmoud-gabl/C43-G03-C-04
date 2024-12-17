using System.Text;

namespace Dimo_4
{
    internal class Program
    {
        //public static void swap(ref int x,ref int y)
        //{ 
        // int temp=x; x=y; y=temp;
        //}
        //public static void project(string pattern, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("*");
        //    }
        //}
        //public static int pet(ref int[] Arr)
        //{
        //    int sum=0;

        //    if (Arr != null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];
        //        }
        //    }
        //    return sum;
        //}
        public static void summul(int x, int y , out int sum,out int mul )
        {
             sum = x+y;
             mul = x*y;
        }
        
            
        
        static void Main()
        {

            #region string & string builder
            //string name1;
            //name1 = new string("mahmoud");
            //string name2 = "heba";
            //name2 = name1;
            //name2 = "alli";
            //    Console.WriteLine(name1);
            //Console.WriteLine(name2);
            //-------------------------------
            //stringBuilder Db = new StringBuilder();


            #endregion
            #region one Dimantion array
            //int[] numbers;
            //numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            ////-----------------------------
            //int[] numbers2 = { 1 ,2, 3};
            //Console.WriteLine( "size"+numbers2.Length + "Dimantion"+numbers2.Rank);
            #endregion
            #region tow D array
            //int[,] marks = new int[2, 4];
            //Console.WriteLine(marks.GetLength(0));
            //Console.WriteLine(marks.GetLength(1));
            //for (int i = 1; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"number of student = {i}");
            //    for (int j = 1; j < marks.GetLength(1); j++) 
            //    {
            //        Console.WriteLine($"sup = {j}");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////------------------------------------
            //for (int i = 1; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"number of student = {i}");
            //    for (int j = 1; j < marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"sup = {j} = {marks[i, j]} " );

            //    }
            //}
            #endregion
            #region judged array
            //int[][] numbers = new int[3][]; //بيكون فيه اكتر من اراي بس هو اراي واحد  
            //numbers[0] = new int[] { 1 , 2,3};
            //numbers[1] = new int[] { 1, 6 };
            //numbers[2] = new int[] { 6 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(numbers[i][j]);
            //    }
            //}
            #endregion
            #region methodes array
            //---------class----------------
            //int[] nums = { 5, 3, 2, 8, 9, 1 };
            //int[] nums1 = { 5, 6, 7 };
            //int[] nums2 = new int[4];
            //Array.Sort(nums, nums1);
            //Array.Copy(nums1 , nums2, 2);
            //Array.Clear(nums);
            //int[] array3 = (int[]) Array.CreateInstance(typeof(int), 6);
            //int[,,] array4 = (int[,,])Array.CreateInstance(typeof(int), 2,3,4);

            //----------------object------------------
            //nums1.CopyTo(nums2, 0);
            //foreach (int i in nums2)
            //{
            //    Console.WriteLine(i);
            //}
            //nums2.SetValue(100, 0);
            //Console.WriteLine(nums2[0]);

            #endregion
            #region function
            #region passing ref by value
            //int x = 3;
            //int y = 4;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #region ref by type
            //int[] numbers = { 1, 2, 3};
            //int result=pet(ref numbers);
            //Console.WriteLine(result);

            #endregion
            #region passing by out
            //int a = 3, b = 4, resultsm ,  resultmul ;
            //summul(a,b,out resultsm ,out resultmul);
            //Console.WriteLine($"sum{resultsm}");
            //Console.WriteLine($"mul{resultmul}");


            #endregion
            #endregion

        }
    }
}
