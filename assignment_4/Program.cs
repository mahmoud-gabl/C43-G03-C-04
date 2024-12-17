namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ----1
            //int[,] nambers = new int[3, 2];
            //for (int i = 0; i < 3; i++)
            //{
            //    {
            //        Console.Write($"Enter coordinates of point {i + 1} (x y): ");
            //        string[] input = Console.ReadLine().Split(' ');
            //        nambers[i, 0] = int.Parse(input[0]);
            //        nambers[i, 1] = int.Parse(input[1]);
            //    }
            //    double area = 0.5 * Math.Abs(
            //    nambers[0, 0] * (nambers[1, 1] - nambers[2, 1]) +
            //    nambers[1, 0] * (nambers[2, 1] - nambers[0, 1]) +
            //    nambers[2, 0] * (nambers[0, 1] - nambers[1, 1])
            //    );
            //    if (area == 0)
            //    {
            //        Console.WriteLine("yes");

            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }
            #endregion
            #region ----2
            //Console.Write("Enter the time taken to complete the task: ");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken < 3)
            //{
            //    Console.WriteLine("Highly Efficient!");
            //}
            //else if (timeTaken >= 3 && timeTaken < 4)
            //{
            //    Console.WriteLine("Increase your speed.");
            //}
            //else if (timeTaken >= 4 && timeTaken < 5)
            //{
            //    Console.WriteLine("Training required to enhance speed.");
            //}
            //else if (timeTaken >= 5)
            //{
            //    Console.WriteLine("You are required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive number.");
            //}
            #endregion
            #region ----3
            //Console.WriteLine("please enter number of matrixes:");
            //int n=int.Parse(Console.ReadLine());
            //int[,] number = new int[n ,n];
            //for (int i = 0; i < n; i++)
            //{ 
            //    for (int j = 0; j < n; j++)
            //    {
            //        number[i,j] = i==j ? 1 : 0;
            //    }
            //}
            ////print 
            //for (int i = 0; i < n; i++)
            //{ 
            // for(int j = 0; j < n;j++)
            //        Console.WriteLine(number[i,j]);
            //    Console.WriteLine();
            //}

            #endregion
            #region ----20
            //int[] number = { 1, 2, 3, 4, 5};
            //int sum = 0;
            //foreach (int i in number)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("sum all number in array :"+sum);
            #endregion
            #region ----21
            //int[] num1 = { 1, 24, 35, 4 };
            //int[] num2 = { 6, 2, 8 };
            //Array.Sort(num1,num2);


            #endregion
            #region ----22
            //int[] numbers = { 1, 2, 3, 2, 1, 4, 5, 2 };
            //int[] frequency = new int[numbers.Max() + 1]; // مصفوفة لحفظ التكرارات


            //foreach (int num in numbers)
            //{
            //    frequency[num]++;
            //}


            //for (int i = 0; i < frequency.Length; i++)
            //{
            //    if (frequency[i] > 0)
            //    {
            //        Console.WriteLine($"{i} occurs {frequency[i]} times.");
            //    }
            #endregion
            #region ----23

            //int[] numbers = { 10, 5, 20, 8, 15 };

            //int max = numbers[0];
            //int min = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //Console.WriteLine("Maximum element: " + max);
            //Console.WriteLine("Minimum element: " + min);
            #endregion
            #region ----24
            //int[] nums = { 10, 5, 20, 8, 1 };
            //int largenum = nums[0];
            //int secondLargest = int.MinValue;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] > largenum)
            //    {
            //        secondLargest = largenum;
            //        largenum = nums[i];

            //    }
            //    else if (nums[i] < secondLargest && nums[i] != largenum)
            //    {
            //        secondLargest = nums[i];

            //    }
            //}
            //    Console.WriteLine($"second{secondLargest}");


            #endregion
            #region ----26
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);

            //string reversedSentence = string.Join(" ", words);
            //Console.WriteLine("Reversed sentence: " + reversedSentence);
            #endregion
            #region ----27
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];

            //// Input values for the first array
            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element at [{i}, {j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy elements from the first array to the second array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            //// Print the second array
            //Console.WriteLine("Second array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region ----28
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original array:");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine("\nReversed array:");
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            #endregion


        }
    }
}
