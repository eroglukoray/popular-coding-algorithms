using System.Text;

internal class Program
{

    /* Q.1: How to reverse a string?
        Ans.: The user will input a string and the method should return the reverse of that string
        input: hello, output: olleh
        input: hello world, output: dlrow olleh
    */
    public static string ReverseString(string str)
    {
        //1. Char array create
        char[] charArray = new char[str.Length];
        //2. for loop 
        for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        {
            charArray[i] = str[j];
        }
        //3. assign to string 
        string reversedstring = new string(charArray);
        return reversedstring;
    }
    /*
    Q.2: How to find if the given string is a palindrome or not?
        Ans.: The user will input a string and we need to print “Palindrome” or “Not Palindrome” based on whether the input string is a palindrome or not.

        input: madam, output: Palindrome
        input: step on no pets, output: Palindrome
        input: book, output: Not Palindrome
        if we pass an integer as a string parameter then also this method will give the correct output

        input: 1221, output: Palindrome
    */
    public static bool CheckPalindrome(string str)
    {
        //1. add flag 
        bool flag = false;
        // 2. for loop
        for (int i = 0, j = str.Length - 1; //assign
            i < str.Length / 2; //range
            i++, j--) //increment,decrement
        {
            if (str[i] != str[j])// if char not equal any index break
            {
                flag = false;
                break;
            }
            else // if char is the equal to be continue
                flag = true;
        }
        // 3. return to result
        return flag;
    }
    /*
    Q.3: How to reverse the order of words in a given string?
        Ans.: The user will input a sentence and we need to reverse the sequence of words in the sentence.

        input: Welcome to Csharp corner, output: corner Csharp to Welcome
    */
    public static string ReverseWordOrder(string str)
    {
        string result = "";
        StringBuilder reverseString = new StringBuilder();
        int start = str.Length - 1;

        for (int i = 0, j = str.Length - 1 - i; j > 0;)
        {
            i = 0;
            do
            {
                if (j > 0)
                {
                    start--;
                    j--;
                }
                else
                    break;
                i++;

            } while (str[j] != ' ');

            for (int k = start; k <= start + i; k++)
            {
                reverseString.Append(str[k]);
            }
        }
        return reverseString.ToString();
    }

    /*
     Q.4: How to reverse each word in a given string?
        Ans.: The user will input a sentence and we need to reverse each word individually without changing its position in the sentence.

        input: Welcome to Csharp corner, output: emocleW ot prahsC renroc
     */
    internal static string ReverseWords(string str)
    {
        StringBuilder output = new StringBuilder();
        List<char> charlist = new List<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' || i == str.Length - 1)
            {
                if (i == str.Length - 1) //son kayıt ise ekle
                    charlist.Add(str[i]);

                for (int j = charlist.Count - 1; j >= 0; j--) //değilse charList length kadar
                    output.Append(charlist[j]);

                output.Append(' ');
                charlist = new List<char>();
            }
            else
                charlist.Add(str[i]);
        }
        return output.ToString();
    }
    /*
     Q.5: How to count the occurrence of each character in a string?
        Ans.: The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.

        input: hello world;
        output: 

        h – 1 | e – 1 | l – 3 | o – 2 | w – 1 | r – 1 | d – 1
     */
    internal static string CountCharacter(string str)
    {
        // define dictionary<char,int> and string builder
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        StringBuilder results = new StringBuilder();
        //
        foreach (var character in str)
        {
            //white space not count
            if (character != ' ')
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }
        }
        foreach (var character in characterCount)
        {
            results.AppendFormat("{0} - {1}" + " | ", character.Key, character.Value);
        }
        return results.ToString();
    }
    /*
     Q.6: How to remove duplicate characters from a string?
        Ans.: The user will input a string and the method should remove multiple occurrences of characters in the string

        input: csharpcorner, output: csharpone
     */
    internal static string RemoveDuplicate(string str)
    {
        string result = "";
        foreach (var item in str)
        {
            if (!result.Contains(item))
            {
                result += item;
            }
        }
        return result;
    }
    /*
     Q.7: How to find all possible substring of a given string?
        Ans.: This is a very frequent interview question. Here we need to form all the possible substrings from input string, varying from length 1 to the input string length. The output will include the input string also.

        input: abcd , output : a ab abc abcd b bc bcd c cd d
     */
    internal static string FindAllSubstring(string str)
    {

        //create String Builder
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < str.Length; ++i)
        {
            StringBuilder subString = new StringBuilder();
            for (int j = i; j < str.Length; ++j)
            {
                subString.Append(str[j]);
                result.Append(subString + " ");
            }
        }
        return result.ToString();
    }
    /*
     Q.8: How to perform Left circular rotation of an array?
        Ans.: The user will input an integer array and the method should shift each element of input array to its Left by one position in circular fashion. The logic is to iterate loop from Length-1 to 0 and swap each element with last element.

        input: 1 2 3 4 5, output: 2 3 4 5 1
     */
    public static string RotateLeft(int[] array)
    {
        //define tempValue first value  => array[0] = 1
        int temData = array[0];
        //last index to first index => newArray[0] = array[1] | newArray[1] = array[2] | newArray[2] = array[3] | newArray[3] = array[4] | newArray[4] = tempValue

        int[] newArray = new int[array.Length];
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                newArray[i] = temData;
            }
            else
            {
                newArray[i] = array[i + 1];
            }
        }
        foreach (var item in newArray)
        {
            result.Append(item.ToString());
            result.Append(' ');
        }

        return result.ToString();
    }
    /*
     Q.9: How to perform Right circular rotation of an array?
        Ans: The user will input an integer array and the method should shift each element of input array to its Right by one position in circular fashion. The logic is to iterate loop from 0 to Length-1 and swap each element with first element

        input: 1 2 3 4 5, output: 5 1 2 3 4
     */
    public static string RotateRight(int[] array)
    {
        //define tempValue first value  => array[length - 1] = 5
        int temData = array[array.Length - 1];
        //last index to first index => newArray[0] = tempData | newArray[1] = array[0] | newArray[2] = array[1] | newArray[3] = array[2] | newArray[4] = array[3]
        int[] newArray = new int[array.Length];
        StringBuilder result = new StringBuilder();

        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (i==0)
            {
                newArray[i] = temData;
            }
            else
            {
                newArray[i] = array[i - 1];
            }
        }
        foreach (var item in newArray)
        {
            result.Append(item);
            result.Append(" ");
        }
        return result.ToString();
    }
    /*
     Q.10: How to find if a positive integer is a prime number or not?
        Ans.: The user will input a positive integer and the method should output “Prime” or “Not Prime” based on whether the input integer is a prime number or not.

        The logic is to find a positive integer less than or equal to the square root of input integer. If there is a divisor of number that is less than the square root of number, then there will be a divisor of number that is greater than square root of number. Hence, we have to traverse till the square root of number.

        The time complexity of this function is O(√N) because we traverse from 1 to √N.

        input: 20, output: Not Prime
        input: 17, output: Prime
     */
    internal static bool IsPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var squareRoot = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= squareRoot; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
    /*
     Q.11: How to find the sum of digits of a positive integer?
        Ans.: The user will input a positive integer and the method should return the sum of all the digits in that integer.

        input: 168, output: 15
     */
    internal static void SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine(sum);
    }
    /*
     Q.12: How to find second largest integer in an array using only one loop?
        Ans.: The user will input an unsorted integer array and the method should find the second largest integer in the array.

        input: 3 2 1 5 4, output: 4
     */
    internal static int FindSecondLargeInArray(int[] arr)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;

        foreach (int element in arr)
        {
            if (element > max1)
            {
                max2 = max1;
                max1 = element;
            }
            else if (element >= max2 && element != max1)
            {
                max2 = element;
            }
        }
        return max2;
    }
    /*
     Q.13: How to find third largest integer in an array using only one loop?
        Ans.: The user will input an unsorted integer array and the method should find the third largest integer in the array.

        input: 3 2 1 5 4, output: 3
     */
    internal static void FindthirdLargeInArray(int[] arr)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int max3 = int.MinValue;

        foreach (int item in arr)
        {
            if (item > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = item;
            }
            else if (item > max2 && item != max1)
            {
                max3 = max2;
                max2 = item;
            }
            else if (item > max3 && item != max2 && item != max1)
            {
                max3 = item;
            }
        }
        Console.WriteLine(max3); ;
    }
    /*
     Q.14: How to convert a two-dimensional array to a one-dimensional array?
        Ans.: The user will input a 2-D array (matrix) and we need to convert it to a 1-D array. We will create a 1-D array column-wise.

        input: { { 1, 2, 3 }, { 4, 5, 6 } }, output: 1 4 2 5 3 6
     */
    internal static void MultiToSingle(int[,] array)
    {
        int index = 0;
        int width = array.GetLength(0);
        int height = array.GetLength(1);
        int[] single = new int[width * height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                single[index] = array[x, y];
                Console.Write(single[index] + " ");
                index++;
            }
        }
    }
    /*
     Q.15: How to convert a one-dimensional array to a two-dimensional array?
        Ans.: The user will input a 1-D array along with the number of rows and columns. The method should convert this 1-D array to a 2-D array(matrix) of a given row and column. We will create a matrix row-wise.

        input: {1, 2, 3, 4, 5, 6} ,2 ,3
        output:
        1 2 3
        4 5 6
     */
    private static void Main(string[] args)
    {
        do
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            if (!Console.KeyAvailable)
            {
                Console.WriteLine("Enter any words");
                string text = Console.ReadLine();
                Console.WriteLine("1. Reverse String: " + ReverseString(text));
                Console.WriteLine("2. Check Palindrome: " + CheckPalindrome(text));
                Console.WriteLine("3. Reverse Word Order: " + ReverseWordOrder(text));
                Console.WriteLine("4. Reverse Word: " + ReverseWords(text));
                Console.WriteLine("5. Count Char.: " + CountCharacter(text));
                Console.WriteLine("6. Remove Duplicate: " + RemoveDuplicate(text));
                Console.WriteLine("7. Find All Substring: " + FindAllSubstring(text));
                Console.WriteLine("8. Rotate Left: " + RotateLeft(array));
                Console.WriteLine("9. Rotate Right: " + RotateRight(array));
                Console.WriteLine("Press ESC to stop");
            }
        }
        while
        (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}