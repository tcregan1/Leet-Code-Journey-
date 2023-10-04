
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Xml.Schema;
using System.Linq;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.SymbolStore;
using LC;

int[] v = new int[] { 1, 2, 3, 1, 1, 3 };
ListNode listNode = new ListNode();
Console.WriteLine(DeleteDuplicates(listNode));

static int LengthOfLastWord(string s)
{
    s = s.Trim();
    string[] arr = s.Split(' ');
    int lastIndex = arr.Length - 1;
    int length = arr[lastIndex].Length;
    return length;

}
static double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] result = nums1.Concat(nums2).ToArray();
    int middIndex = result.Length / 2;
    if (result.Length == 1)
    {
        return result[0];
    }
    Array.Sort(result);
    if (result.Length % 2 == 0)
    {
        middIndex = middIndex - 1;
        Console.WriteLine(result[middIndex].ToString());
        Console.WriteLine(result[middIndex + 1].ToString());
        return Convert.ToDouble(result[middIndex] + result[middIndex + 1]) / 2;

    }
    if (result.Length % 2 == 1)
    {
        Console.WriteLine(result[middIndex].ToString());
        Console.WriteLine(result[middIndex + 1].ToString());
        return Convert.ToDouble(result[middIndex]);
    }
    return -1;
}
static int SearchInsert(int[] nums, int target)
{

    List<int> result = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        result.Add(nums[i]);
    }
    for (int i = 0; i < result.Count; i++)
    {
        if (result[i] == target)
        {
            return i;
        }
    }
    result.Add(target);
    result.Sort();
    for (int i = 0; i < result.Count; i++)
    {
        if (result[i] == target)
        {
            return i;
        }
    }

    return -1;

}
static int MaxArea(int[] height)
{
    int left = 0;
    int right = height.Length - 1;
    int max = 0;
    int current_max = 0;
    while (left < right)
    {
        current_max = Math.Min(height[left], height[right]) * (right - left);
        if (current_max > max)
        {
            max = current_max;
        }


        if (height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
        }

    }
    return max;


}
static int Reverse(int x)
{

    //int x = -12345; // Replace with your negative integer value
    int sign = x < 0 ? -1 : 1; // Determine the sign of x

    x = Math.Abs(x); // Make x positive to extract its digits
    List<int> digitList = new List<int>();

    // Extract and add each digit to the list
    while (x > 0)
    {
        int digit = x % 10; // Get the last digit
        digitList.Add(digit);
        x /= 10; // Remove the last digit
    }

    // Reverse the list (optional)
    //digitList.Reverse();

    // Convert the list of digits back into an integer with the original sign
    int reversedX = 0;
    foreach (int digit in digitList)
    {
        reversedX = reversedX * 10 + digit;
    }

    reversedX *= sign; // Apply the original sign

    Console.WriteLine("Original x: " + x);
    Console.WriteLine("Reversed x: " + reversedX);

    return reversedX;


}
static int ConvertListToInt(List<int> intList)
{
    // Convert the list of integers to a string by concatenating them
    string intString = string.Join("", intList);

    // Parse the string into an integer
    if (int.TryParse(intString, out int result))
    {
        return result;
    }
    else
    {
        // Handle parsing error (e.g., if the list contains non-numeric characters)
        Console.WriteLine("Conversion failed. Invalid input in the list.");
        return 0; // You can return a default value or handle the error differently.
    }
}
static IList<string> LetterCombinations(string digits)
{
    List<string> result = new List<string>();
    Dictionary<char, string> dic = new Dictionary<char, string>()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };
    string chars, chars2;
    foreach (char c in digits)
    {
        chars = dic[c];
        string ahead = dic[c];
        result.Add(chars);
    }
    string firstChars = result[0]; // This will be the chars value for the first digit
    string secondChars = result[1];


    int length = result.Count; // Get the length of the result list
    List<string> fuck = new List<string>();

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {

            fuck.Add(result[i] + result[j]);
        }
    }

    Console.WriteLine("  = " + fuck[0]);


    for (int i = 0; i < result.Count; i++)
    {
        Console.WriteLine(result[i]);
    }

    return result;
}
static void Merge(int[] nums1, int m, int[] nums2, int n)
{
    for (int i = 0; i < nums2.Length; i++)
    {
        nums1[i + nums1.Length - 1] = nums2[i];
    }

    Array.Sort(nums1);

}
static int MaxChunksToSorted(int[] arr)
{
    List<List<int>> list = new();
    for (int i = 0; i < arr.Length; i++)
    {
        list.Add(new List<int>()
        {
            arr[i]
        });
    }

    for (int j = 0; j < arr.Count(); j++)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i].Max() > list[i + 1].Min())
            {
                list[i].AddRange(list[i + 1]);
                list.RemoveAt(i + 1);
            }
        }
    }


    return list.Count;
}
static int MajorityElement(int[] nums)
{
    int maj = nums.Length / 2;
    var dictionary = new Dictionary<int, int>();

    foreach (int n in nums)
    {
        if (!dictionary.ContainsKey(n))
            dictionary[n] = 0;
        dictionary[n]++;
    }

    foreach (var pair in dictionary)
    {

        if (pair.Value > maj)
        {
            Console.WriteLine(pair.Key);
            return pair.Key;

        }

    }
    return -1;

}
static int AddDigits(int num)
{
    int x = num;
    while (x >= 10)
    {
        string bbg = x.ToString();
        int a = 0;
        for (int i = 0; i < bbg.Length; i++)
        {

            a = a + (int)Char.GetNumericValue(bbg[i]);
        }
        x = a;
    }

    return x;

}
static int sumto10(int num)
{
    int x = 0;
    for (int i = 0; i <= num; i++)
    {
        x = x + i;
    }
    return x;
}
static void MoveZeroes(int[] nums)
{
    int temp;

    for (int p = 0; p <= nums.Length - 2; p++)
    {
        for (int i = 0; i <= nums.Length - 2; i++)
        {
            if (nums[i] == 0)
            {
                temp = nums[i + 1];
                nums[i + 1] = nums[i];
                nums[i] = temp;
            }
        }
    }
}
static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
{
    int currentMax = 0;
    List<bool> result = new List<bool>();
    bool valid = true;

    for (int i = 0; i < candies.Length; i++)
    {
        if (candies[i] > currentMax)
        {
            currentMax = candies[i];
        }

    }
    for (int j = 0; j < candies.Length; j++)
    {
        if (candies[j] + extraCandies >= currentMax)
        {
            result.Add(true);
        }
        else
        {
            result.Add(false);
        }
    }
    return result;
}
static bool CanPlaceFlowers(int[] flowerbed, int n)
{
    if (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1)
    {
        return true;
    }
    else if (flowerbed.Length == 1 && flowerbed[0] == 1 && n == 0)
    {
        return true;
    }



    int length = flowerbed.Length;
    for (int i = 0; i < flowerbed.Length; i++)
    {
        if (n == 0)
        {
            return true;
        }
        else
        {
            if (i == 0)
            {
                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
            else if (i == length - 1)
            {
                if (flowerbed[i - 1] == 0 && flowerbed[i] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }

            }
            else
            {

                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }

            }
        }
    }
    if (n == 0)
    {
        return true;
    }

    return false;


}
static char FindTheDifference(string s, string t)
{
    List<char> listT = t.ToList();
    List<char> listS = s.ToList();
    for (int i = 0; i < listS.Count; i++)
    {
        for (int j = 0; j < listS.Count; j++)
        {
            if (listT.Contains(s[i]))
            {
                listT.Remove(s[i]);
            }
        }


    }
    char[] c = listT.ToArray();
    return c[0];

}
static string RemoveDuplicateLetters(string s)
{
    //s = s.ToLower();
    //Dictionary<int, char> dictionary = new Dictionary<int, char>();
    //for (char c = 'a'; c <= 'z'; c++)
    //{
    //    int key = c - 'A' + 1;
    //    dictionary.Add(key, c);
    //}
    //foreach (var kvp in dictionary)
    //{
    //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
    //}

    //foreach (char n in s)
    //{
    //    if (!dictionary.ContainsKey(n))
    //    dictionary[n]++;
    //}
    s = new string(s.ToCharArray().Distinct().ToArray());
    char[] cs = s.ToCharArray();
    char temp;

    //for (int i = 0; i < cs.Length - 1; i++)
    //{
    //    for (int j = i + 1; j < cs.Length; j++)
    //    {
    //        if (cs[i] > cs[j])
    //        {
    //            temp = cs[i];
    //            cs[i] = cs[j];
    //            cs[j] = temp;
    //        }
    //    }

    //}
    Array.Sort(cs);
    string[] strs = s.Split(' ').OrderBy(x => x).ToArray();
    string d = new string(cs);
    return d;

}
static string RS(string s)
{

    Random random = new Random();
    List<string> list = new List<string>();

    // Specify the path to the Notepad file you want to read.
    string filePath = "C:/Users/tomcr/OneDrive/Documents/AllSocietySporting Club.txt";

    // Create a list to store the lines of text.
    List<string> textLines = new List<string>();

    try
    {
        // Read the text from the file and add each line to the list.
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                textLines.Add(line);
            }
        }

        // Now, the text from the Notepad file is stored in the 'textLines' list.
        // You can access and manipulate the text as needed.

        // Example: Print each line to the console.
        foreach (string textLine in textLines)
        {
            //Console.WriteLine(textLine);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("An error occurred: " + e.Message);
    }
    // Create an instance of the Random class.
    Random random1 = new Random();

    // Get a random index within the range of the list.
    int randomIndex = random.Next(0, textLines.Count);

    // Access the string at the random index.
    string randomString = textLines[randomIndex];

    // Print the random string.
    Console.WriteLine("Random String: " + randomString);
    return "Hello";
}
static void myBudget()
{
    List<(string, decimal, decimal)> expenses = new()
    {
        ("Food", 5, 6),
        ("Bus", 2, 7),
        ("Drinking", 1, 40),
        ("Work", 1, -62)
    };

    DateTime target = new(2023, 12, 25);
    DateTime now = DateTime.Now;
    double hours = 7;
    double hourlyRate = 9.15;
    double weeklyWage = hours * hourlyRate;

    double dailyBudget = weeklyWage / 7;
    double totalSpent = 0;
    TimeSpan duration = target - now;
    double totalDays = duration.TotalDays;
    double busFee = 14.0;
    int busTaken = 0;
    int count = 0;
    double drinkCharge = 0;
    while (target >= DateTime.Now)
    {
        // do something with target.Month and target.Year
        totalSpent += dailyBudget;
        target = target.AddDays(-1);
        count++;

        if (count % 7 == 0)
        {
            busTaken++;
            drinkCharge += 40;
        }
        if (count % 7 == 2)
        {
            totalSpent = totalSpent + (-2 * dailyBudget);
        }
    }

    decimal total = 0;
    for (int i = 0; i < Math.Ceiling(duration.Days / 7d); i++)
    {
        foreach ((string name, decimal dayPW, decimal cost) in expenses)
        {
            total += dayPW * cost;
        }
    }

    totalSpent = Math.Round(totalSpent + busFee * busTaken + drinkCharge, 2);

    string totalSpendYearly = totalSpent.ToString("C");
    string totalSpendWeeky = (totalSpent / 7).ToString("C");

    Console.WriteLine("You spent " + totalSpendYearly + " in " + Convert.ToInt32(totalDays) + " days.");
    Console.WriteLine("That is a weekly spend of " + totalSpendWeeky);
    Console.WriteLine("You generate £" + weeklyWage + " weekly");
}
static int MaxNonDecreasingLength(int[] nums1, int[] nums2)
{
    int maxLength = 0;
    int[] nums3 = new int[nums1.Length];
    int backmaxLength = 0;

    int n = nums1.Length;


    for (int i = 0; i < nums1.Length; i++)
    {
        if (i == 0)
        {
            if (nums1[i] < nums2[i])
            {
                nums3[i] = nums1[i];
                maxLength++;
            }
            else
            {
                nums3[i] = nums2[i];
                maxLength++;
            }
        }
        else
        {
            if (nums1[i] < nums2[i] && nums1[i] >= nums3[i - 1])
            {
                nums3[i] = nums1[i];
                maxLength++;
            }
            else if (nums2[i] < nums1[i] && nums2[i] >= nums3[i - 1])
            {
                maxLength++;
                nums3[i] = nums2[i];
            }
            else if (nums1[i] >= nums3[i - 1])
            {
                maxLength++;
                nums3[i] = nums1[i];
            }
            else if (nums2[i] >= nums3[i - 1])
            {
                maxLength++;
                nums3[i] = nums2[i];
            }
            else
            {
                return maxLength;
            }
        }

    }

    for (int i = nums1.Length; i >= 0; i--)
    {
        if (i == nums1.Length - 1)
        {
            if (nums1[i] < nums2[i])
            {
                nums3[i] = nums1[i];
                backmaxLength++;
            }
            else
            {
                nums3[i] = nums2[i];
                backmaxLength++;
            }
        }
        else
        {
            if (nums1[i] < nums2[i] && nums1[i] >= nums3[i - 1])
            {
                nums3[i] = nums1[i];
                backmaxLength++;
            }
            else if (nums2[i] < nums1[i] && nums2[i] >= nums3[i - 1])
            {
                backmaxLength++;
                nums3[i] = nums2[i];
            }
            else if (nums1[i] >= nums3[i - 1])
            {
                backmaxLength++;
                nums3[i] = nums1[i];
            }
            else if (nums2[i] >= nums3[i - 1])
            {
                backmaxLength++;
                nums3[i] = nums2[i];
            }
            else
            {
                return backmaxLength;
            }
        }

    }

    return Math.Max(maxLength, backmaxLength);
}
static void bananna(string s)
{
    int sl = s.Length - 2;
    string space = "";
    for (int i = 0; i < sl; i++)
    {
        space += " ";
    }

    for (int i = 0; i < s.Length; i++)
    {
        Console.Write(s[i]);
    }
    Console.WriteLine("");
    string a = new string(s.Reverse().ToArray());
    for (int i = 1; i < s.Length - 1; i++)
    {
        Console.WriteLine(s[i] + space + a[i]);
    }
    char[] arr = s.ToCharArray();
    s.Reverse();
    char[] rev = new char[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        rev[rev.Length - 1 - i] = arr[i];
    }
    string reverse = new string(rev);
    Console.WriteLine(rev);
}
static bool IsMonotonic(int[] nums)
{
    bool valid = true;
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {

        if (nums[i] <= nums[i + 1])
        {
            valid = true;
            count1++;
        }
        else
        {
            valid = false;

        }


    }
    if (count1 == nums.Length - 1) { return true; }

    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] >= nums[i + 1])
        {
            count2++;
        }


    }
    if (count2 == nums.Length - 1) { return true; }
    return false;


}
static void SortColors(int[] nums)
{
    int temp = 0;
    for (int i = 0; i < nums.Length - 2; i++)
    {
        for (int j = 0; j < nums.Length - 2; j++)
        {
            if (nums[i] > nums[i + 1])
            {
                nums[i] = temp;
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;

            }
        }

    }
}

static string ReverseWords(string s)
{
    string[] words = s.Split(' ');
    string reversedWord = "";
    for (int i = 0; i < words.Length; i++)
    {
        Console.WriteLine(words[i]);
        char[] arr = words[i].ToCharArray();
        Array.Reverse(arr);
        reversedWord += new string(arr);
        reversedWord += " ";
    }
    reversedWord = reversedWord.TrimEnd();
    return reversedWord;
}

static bool WinnerOfGame(string colors)
{
    List<char> list = new List<char>();
    bool aliceTurn = true;
    for (int i = 0; i < colors.Length; i++)
    {
        list.Add(colors[i]);
    }
    for (int i = 0; i < list.Count + 2; i++)
    {
        if (aliceTurn == true)
        {
            if (list[i] == 'A' && list[i + 1] == 'A' && list[i - 1] == 'A')
            {
                list.RemoveAt(i);
                aliceTurn = false;
            }

        }
        if (aliceTurn == false)
        {
            if (list[i] == 'B' && list[i + 1] == 'B' && list[i - 1] == 'B')
            {
                list.RemoveAt(i);
                aliceTurn = true;
            }
        }

    }
    return false;
}

static int RemoveElement(int[] nums, int val)
{
    int temp = 0;
    List<int> list = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        list.Add(nums[i]);
    }
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] == val)
        {

            nums[i] = 1000;
        }
    }
    for (int i = 0; i <= list.Count; i++)
    {
        if (list[i] == val)
        {
            list.RemoveAt(i);
        }
    }
    Array.Sort(nums);

    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine(nums[i]);
    }

    return list.Count;
}

static int NumIdenticalPairs(int[] nums)
{
    int goodPairs = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                goodPairs++;
            }
        }
    }
    return goodPairs;
}

static bool IsIsomorphic(string s, string t)
{
    Dictionary<char, char> dic = new Dictionary<char, char>();
    for (int i = 0; i < s.Length; i++)
    {
        if (!dic.ContainsKey(s[i]) && dic.ContainsValue(t[i]))
        {
            return false;
        }
        if (dic.ContainsKey(s[i]))
        {
            if (dic[s[i]] != t[i])
            {
                return false;
            }
        }
        if (!dic.ContainsKey(s[i]))
        {
            dic.Add(s[i], t[i]);
        }
    }
    foreach (var kvp in dic)
    {
        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
    }

    for (int i = 0; i < s.Length; i++)
    {
        if (!dic.ContainsValue(t[i]))
        {
            return false;
        }
    }
    return true;
}
static string ConvertToTitle(int columnNumber)
{
    string excel = "";
    int c = 0;
    int remainder = 0;
    while (columnNumber != 0)
    {
        columnNumber--;
        remainder = columnNumber % 26;
        c = Convert.ToInt32(remainder + 65);
        var result = char.ConvertFromUtf32(c);
        excel += result;
        columnNumber = columnNumber / 26;
        Console.WriteLine(excel);
    }
    return excel;
}
static List<List<int>> Generate(int numRows)
{
    List<List<int>> listOfLists = new List<List<int>>();

    for (int i = 0; i < numRows; i++)
    {
        int count = listOfLists.Count;
        List<int> list = new List<int>();
        if (i == 0)
        {
            list.Add(1);
            listOfLists.Add(list);
            //count++;
        }
        if (i == 1)
        {
            list.Add(1);
            list.Add(1);
            listOfLists.Add(list);

        }

        if (count >= 2)
        {
            list.Add(1);
            for (int j = 0; j < count - 1; j++)
            {
                list.Add(0);
            }
            list.Add(1);
            listOfLists.Add(list);
            //count++;
        }
    }
    for (int i = 2; i < listOfLists.Count; i++)
    {
        for (int j = 0; j < i - 1; j++)
        {
            int result = listOfLists[i - 1][j] + listOfLists[i - 1][j + 1];
            Console.WriteLine("Result = " + result.ToString());
            listOfLists[i][j + 1] = result;
        }
    }
    int x = 0;
    foreach (var list in listOfLists)
    {
        Console.Write("List on = " + x + "      ");
        Console.WriteLine(String.Join(", ", list));
        x++;
    }
    return listOfLists;
}
static IList<int> GetRow(int rowIndex)
{
    List<List<int>> listOfLists = new List<List<int>>();

    for (int i = 0; i < rowIndex + 1; i++)
    {
        int count = listOfLists.Count;
        List<int> list = new List<int>();
        if (i == 0)
        {
            list.Add(1);
            listOfLists.Add(list);
            //count++;
        }
        if (i == 1)
        {
            list.Add(1);
            list.Add(1);
            listOfLists.Add(list);

        }

        if (count >= 2)
        {
            list.Add(1);
            for (int j = 0; j < count - 1; j++)
            {
                list.Add(0);
            }
            list.Add(1);
            listOfLists.Add(list);
            //count++;
        }
    }
    for (int i = 2; i < listOfLists.Count; i++)
    {
        for (int j = 0; j < i - 1; j++)
        {
            int result = listOfLists[i - 1][j] + listOfLists[i - 1][j + 1];
            Console.WriteLine("Result = " + result.ToString());
            listOfLists[i][j + 1] = result;
        }
    }
    int x = 0;
    foreach (var list in listOfLists)
    {
        Console.Write("List on = " + x + "      ");
        Console.WriteLine(String.Join(", ", list));
        x++;
    }
    return listOfLists[listOfLists.Count - 1].ToArray();
}
static ListNode DeleteDuplicates(ListNode head)
{

    List<int> result = new List<int>();
    ListNode current = head;

    while (current != null)
    {
        result.Add(current.val);
        current = current.next;
    }
   
    List<int> uniqueLst = result.Distinct().ToList();
 
    ListNode dummyHead = new ListNode(); // Create a dummy head node
    ListNode c = dummyHead;

    foreach (int value in uniqueLst)
    {
        c.next = new ListNode(value);
        c = c.next;
    }

    return dummyHead;


}
static bool HasPathSum(TreeNode root, int targetSum)
{
    bool isValid = false;
    FindPathSum(root, targetSum, root.val);
    return isValid;

    bool FindPathSum(TreeNode root, int targetSum, int val)
    {
        if (root.left == null && root.right == null)
        {
            if (val == targetSum)
            {
                isValid = true;
            }
        }
        if (root.left != null)
        {
            FindPathSum(root.left, targetSum, val + root.left.val);
        }
        if (root.right != null)
        {
            FindPathSum(root.right, targetSum, val + root.right.val);
        }
        return false;
    }
}

