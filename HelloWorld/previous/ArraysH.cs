using System;

namespace HelloWorld.previous
{
  class ArraysH
  {
    public static void Run()
    {
      // Declare and initialize an array
      // most verbose
      int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

      int[] numbers1 = { 1, 2, 3, 4, 5 };
      int[] numbers2 = [1, 2, 3, 4, 5];
      var numbers4 = new int[] { 1, 2, 3, 4, 5 };
      var fruits = new[] { "Apple", "Banana" };

      // Declare an array with a specific size
      int[] numbers3 = new int[2];
      numbers3[0] = 1;
      numbers3[1] = 2;

      Console.WriteLine("Array Length: " + numbers.Length);
      Console.WriteLine("First Element: " + numbers[0]);
      Console.WriteLine("Last Element: " + numbers[numbers.Length - 1]);

      // Iterate through the array
      Console.WriteLine("Array Elements:");
      foreach (int number in numbers)
      {
        Console.WriteLine(number);
      }

      // Modify an element
      numbers[0] = 10;
      Console.WriteLine("Modified First Element: " + numbers[0]);

      // normal loop
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine($"Element at index {i}: {numbers[i]}");
      }

      // Array methods
      Array.Sort(numbers);

      Array.Reverse(numbers);

      Array.Clear(numbers, 0, numbers.Length);

      Array.Resize(ref numbers, 10);

      Array.Copy(numbers1, numbers2, 5);
      Array.IndexOf(numbers1, 3);
      Array.LastIndexOf(numbers1, 3);
      Array.Find(numbers1, x => x > 3);
      Array.FindAll(numbers1, x => x > 3);
      Array.Exists(numbers1, x => x > 3);
      Array.ForEach(numbers1, x => Console.WriteLine(x));
      Array.TrueForAll(numbers1, x => x > 0);
      Array.BinarySearch(numbers1, 3);
      Array.ConstrainedCopy(numbers1, 0, numbers2, 0, 5);

      // Multidimensional arrays
      int[,] multiArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
      Console.WriteLine("Multidimensional Array Element: " + multiArray[1, 2]);

      // Jagged arrays
      int[][] jaggedArray = new int[2][];
      jaggedArray[0] = [1, 2, 3];
      jaggedArray[1] = [4, 5, 6, 7];
      Console.WriteLine("Jagged Array Element: " + jaggedArray[1][3]);

      // Array of objects
      object[] mixedArray = [1, "Hello", 3.14, true];
      Console.WriteLine("Mixed Array Element: " + mixedArray[1]);

      // Array instance methods
      Console.WriteLine("Array Instance Methods:");
      Console.WriteLine("Get Length of numbers: " + numbers.GetLength(0));
      Console.WriteLine("Get Type of numbers: " + numbers.GetType());
      Console.WriteLine("Get Hash Code of numbers: " + numbers.GetHashCode());
      Console.WriteLine("Get Type of multiArray: " + multiArray.GetType());

      jaggedArray.GroupBy(x => x.Length)
                  .Select(g => new { Length = g.Key, Count = g.Count() })
                  .ToList()
                  .ForEach(x => Console.WriteLine($"Length: {x.Length}, Count: {x.Count}"));
    }
  }
}