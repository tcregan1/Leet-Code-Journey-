
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Xml.Schema;

int[] v = { 0, 0, 1, 0, 0 };
Console.WriteLine(CanPlaceFlowers(v, 1));



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
    if(flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1)
    {
        return true;
    }
    else if(flowerbed.Length == 1 && flowerbed[0] == 1 && n == 0)
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