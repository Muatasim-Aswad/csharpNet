
namespace HelloWorld.previous
{
  public class StringExamples
  {
    public static void RunExamples()
    {

      // string concatenation and interpolation
      string sentence1 = "The quick brown fox jumps over the lazy dog.";
      string sentence2 = "A journey of a thousand miles begins with a single step.";
      string all = sentence1 + " " + sentence2;
      Console.WriteLine($"Combined sentences: {all}");

      // string 
      string wordToFind = "fox";
      int wordToFindLength = wordToFind.Length;
      int index = all.IndexOf(wordToFind);
      string fromBeginningToWord = all.Substring(0, index + wordToFindLength);
      Console.WriteLine($"From the beginning to the word '{wordToFind}': {fromBeginningToWord}");

      // string methods
      string example = "Hello, World!";
      Console.WriteLine($"Original: {example}");
      Console.WriteLine($"To Upper: {example.ToUpper()}");
      Console.WriteLine($"To Lower: {example.ToLower()}");
      Console.WriteLine($"Contains 'World': {example.Contains("World")}");
      Console.WriteLine($"Starts with 'Hello': {example.StartsWith("Hello")}");
      Console.WriteLine($"Ends with '!': {example.EndsWith("!")}");
      Console.WriteLine($"Index of 'World': {example.IndexOf("World")}");
      Console.WriteLine($"Replace 'World' with 'C#': {example.Replace("World", "C#")}");
      Console.WriteLine($"Trimmed: '{example.Trim()}'");
      // string formatting
      string formatted = string.Format("Formatted string: {0} - {1}", sentence1, sentence2);
      Console.WriteLine(formatted);
      // string interpolation
      string interpolated = $"Interpolated string: {sentence1} - {sentence2}";
      Console.WriteLine(interpolated);
      // string split
      string[] words = all.Split(' ');
      Console.WriteLine("Words in combined sentences:");
      foreach (var word in words)
      {
        Console.WriteLine(word);
      }
      // string join
      string joined = string.Join(", ", words);
      Console.WriteLine($"Joined words: {joined}");

      // string comparison
      string str1 = "apple";
      string str2 = "Apple";
      Console.WriteLine($"Are '{str1}' and '{str2}' equal (case-sensitive)? {str1 == str2}");
      Console.WriteLine(
        $"Are '{str1}' and '{str2}' equal (case-insensitive)? {string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase)}"
        );

      // string length
      Console.WriteLine($"Length of '{sentence1}': {sentence1.Length}");
      Console.WriteLine($"Length of '{sentence2}': {sentence2.Length}");

      // string to char array
      char[] charArray = sentence1.ToCharArray();
      Console.WriteLine("Character array from sentence1:");
      foreach (var c in charArray)
      {
        Console.Write(c + " ");
      }
      Console.WriteLine();

      // string to byte array
      byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(sentence1);
      Console.WriteLine("Byte array from sentence1:");
      foreach (var b in byteArray)
      {
        Console.Write(b + " ");
      }
      Console.WriteLine();

      // string from byte array
      string fromByteArray = System.Text.Encoding.UTF8.GetString(byteArray);
      Console.WriteLine($"String from byte array: {fromByteArray}");

      // string reversal
      char[] reversedCharArray = sentence1.ToCharArray();
      Array.Reverse(reversedCharArray);
      string reversedString = new(reversedCharArray);
      Console.WriteLine($"Reversed sentence1: {reversedString}");

      // string comparison with culture
      string cultureStr1 = "café";
      string cultureStr2 = "cafe";
      Console.WriteLine($"Are '{cultureStr1}' and '{cultureStr2}' equal (culture-sensitive)? {string.Equals(cultureStr1, cultureStr2, StringComparison.CurrentCulture)}");
      Console.WriteLine($"Are '{cultureStr1}' and '{cultureStr2}' equal (ordinal)? {string.Equals(cultureStr1, cultureStr2, StringComparison.Ordinal)}");

    }
  }
}