namespace StringReverse;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to reverse: ");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);
        
        Console.WriteLine(reversed);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}