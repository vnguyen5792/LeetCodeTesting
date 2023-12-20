using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LeetCodeTesting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TwoSum
            //int[] nums = new int[] { 3, 2, 4 };
            //Solution solution = new Solution();

            //int[] ints = solution.TwoSum(nums, 6);

            //foreach(int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Palindrome Number
            //string test = string.Empty;
            //int x = 863;

            //string backwardsNum = string.Empty;
            //string holder = string.Empty;

            //holder = x.ToString();
            //char[] charArray = holder.ToCharArray();
            //Array.Reverse(charArray);
            //backwardsNum = new string(charArray);
            #endregion

            #region Roman Numeral Converter
            //string s = "MCMXCIV";

            //int sum = 0;
            //var chars = s.ToCharArray();
            //var romanValue = new Dictionary<char, int>{
            //{'I', 1},
            //{'V', 5},
            //{'X', 10},
            //{'L', 50},
            //{'C', 100},
            //{'D', 500},
            //{'M', 1000}
            //};


            //for (int i = 0; i < chars.Length; i++)
            //{
            //    int currentValue, nextValue;

            //    try
            //    {
            //        romanValue.TryGetValue(chars[i], out currentValue);
            //        romanValue.TryGetValue(chars[i + 1], out nextValue);

            //        if (currentValue < nextValue)
            //        {
            //            sum += nextValue - currentValue;
            //            i++;
            //        }
            //        else { sum += currentValue; }
            //    }
            //    catch
            //    {
            //        romanValue.TryGetValue(chars[i], out currentValue);
            //        sum += currentValue;
            //    }
            //}

            #endregion

            #region Pascals Triangle

            int numRows = 5;

            int[][] pascal = new int[numRows][];

            //for i = 0, i <= numRows, i++, create a new list

            //while we are at i index, loop through that array with another
            //for loop using j. if pascal.length is less than 3(i.e. we only
            //have 2 or less rows to do) then fill the values of pascal(including
            //the inside int array) with 1. else check the row behind the current
            //row and assign the b-index and b-index + 1 to c-index[j] until we reach
            //the end

            for (int i = 0; i < numRows; i++)
            {
                pascal[i] = new int[i + 1];

                //fill the first position with 1
                pascal[i][0] = 1;

                for (int j = 1; j < pascal[i].Length; j++)
                {
                    if (pascal.Length < 3) { Array.Fill(pascal[i], 1); }
                    else if (j == pascal[i].Length - 1) { pascal[i][j] = 1; }
                    else
                    {
                        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                    }
                }
            }

            #endregion

            #region Longest Starting Prefix

            ////check each string at the first index(and counting)
            //string[] strs = { "aa", "aa" };
            //Dictionary<char, int> matchingChars = new Dictionary<char, int>();
            //string matching = "";
            //int minLength = strs.Min(y => y.Length);
            //string shortest = strs.FirstOrDefault(x => x.Length == minLength);

            ////this goes through each letter of the shortest string
            ////this will return a value if none match the first time
            ////if(strs.Length == 1)
            ////{
            ////    return strs[0];
            ////}


            ////the problem we run into is when we get two characters like "aa", "aa"
            ////bc of how the logic works, it will add it to the current key
            //for (int i = 0; i < minLength; i++)
            //{
            //    foreach (string s in strs)
            //    {
            //        if (!matchingChars.ContainsKey(s[i])) { matchingChars.Add(s[i], 1); }
            //        else { matchingChars[s[i]]++; }
            //    }

            //    if (i == 0 && matchingChars[shortest[i]] == 1) { }

            //    if (matchingChars[shortest[i]] == strs.Length)
            //    {
            //        matching += matchingChars.ElementAt(0).Key;
            //    }
            //    else {  }
            //    matchingChars.Clear();
            //}

            #endregion

            #region Shuffle The Array

            //int[] nums = {2,5,1,3,4,7};
            //int n = 3;

            //int[] shuffledNums = new int[nums.Length];

            ////get the values for x and y
            //for (int i = 0; i < n; i++)
            //{
            //    shuffledNums[i * 2] = nums[i];
            //    shuffledNums[(i * 2) + 1] = nums[i + n];
            //}

            #endregion

            #region Fruit Into Baskets

            //int[] fruits = { 1, 0, 3, 4, 3 };

            //Dictionary<int, int> track = new Dictionary<int, int>();
            //int currentMax = 0;
            //int counting = 0;

            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    if (!track.ContainsKey(fruits[i]) && track.Count == 2)
            //    {
            //        currentMax = counting;
            //        track.Remove(track.Keys.First());
            //        counting = track[track.Keys.First()] + 1;
            //        track.Add(fruits[i], 1);
            //    }
            //    else if (!track.ContainsKey(fruits[i]))
            //    {
            //        track.Add(fruits[i], 1);
            //        counting++;
            //    }
            //    else { track[fruits[i]]++; counting++; }
            //}

            //if(counting > currentMax) { return counting; }
            //else { return currentMax; }

            #endregion

            #region Valid Parenthesis

            ////the problem is that we get assigned a new target but we don't
            ////know of the last target we were supposed to remember

            ////i tried using the stack as the target thing but i messed up - gym time
            //string s = "{[]}";

            //Stack<int> paren = new Stack<int>();
            //char target = new char();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    paren.Push(s[i]);

            //    switch (paren.Peek())
            //    {
            //        case '(':
            //            target = ')';
            //            break;

            //        case '[':
            //            target = ']';
            //            break;

            //        case '{':
            //            target = '}';
            //            break;

            //        case ')':
            //            if(target != s[i]) { } //return false;
            //            else
            //            {
            //                paren.Pop();
            //                paren.Pop();
            //            }
            //            break;

            //        case ']':
            //            if (target != s[i]) { } //return false;
            //            else
            //            {
            //                paren.Pop();
            //                paren.Pop();
            //            }
            //            break;

            //        case '}':
            //            if(target != s[i]) { } //return false;
            //            else
            //            {
            //                paren.Pop();
            //                paren.Pop();
            //            }
            //            break;
            //    }
            //}

            //trying to understand someone else's solution on leetcode
            //12-16-23

            //string s = "(]";
            //string st = "([{}])";
            //// Get ready initial state (enforce element type)
            //var k = new Stack<char>();
            //// Evaluate each character for potential mismatch 
            //foreach (char c in s)
            //{
            //    // Push closing round bracket onto the stack
            //    if (c == '(') { k.Push(')'); continue; }
            //    // Push closing curly bracket onto the stack
            //    if (c == '{') { k.Push('}'); continue; }
            //    // Push closing square bracket onto the stack
            //    if (c == '[') { k.Push(']'); continue; }
            //    // Look out for imbalanced strings or mismatches
            //    if (k.Count == 0 || c != k.Pop()) Console.WriteLine("false") ;
            //}

            //foreach (char c in st)
            //{
            //    // Push closing round bracket onto the stack
            //    if (c == '(') { k.Push(')'); continue; }
            //    // Push closing curly bracket onto the stack
            //    if (c == '{') { k.Push('}'); continue; }
            //    // Push closing square bracket onto the stack
            //    if (c == '[') { k.Push(']'); continue; }
            //    // Look out for imbalanced strings or mismatches
            //    if (k.Count == 0 || c != k.Pop()) Console.WriteLine("false");
            //}

            // Empty stack means string is valid and invalid otherwise
            //return k.Count == 0;


            #endregion

            #region Trapping Rain Water

            //int[] height = { 5, 4, 1, 2 };

            //int totalRain = 0, currentHighest = 0;

            //for (int i = 0; i < height.Length - 1; i++)
            //{
            //    if (height[i] >= currentHighest) { currentHighest = height[i]; }
            //    else
            //    {
            //        var array = height.Skip(i).Take(height.Count() - i);
            //        if (array.Any(x => x >= currentHighest))
            //        {
            //            totalRain += currentHighest - height[i];
            //        }
            //        else
            //        {
            //            int leftHeight = height[i - 1];
            //            int rightHeight = height[i+1];

            //            if (leftHeight > height[i] && rightHeight > height[i])
            //            {
            //                totalRain += leftHeight < rightHeight ? (leftHeight - height[i]) : (rightHeight - height[i]);
            //            }
            //        }
            //    }
            //}

            #endregion

            #region Add to Array-Form of Integer

            //int[] num = { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            //int k = 1;

            //Stack<int> newNums = new Stack<int>();
            //double sum = 0;

            //for(int i = 0; i < num.Length; i++)
            //{
            //    sum += num[num.Length - i - 1] * Math.Pow(10, i);
            //}

            //sum += k;



            //for (; sum > 1; sum /= 10)
            //    newNums.Push((int)sum % 10);





            #endregion

            #region Search Insert Position

            //int[] nums = { 1, 3, 5, 6 };
            //int target = 0;

            //if (nums.Contains(target)) { return Array.IndexOf(nums, target); }
            //else
            //{
            //    List<int> test = nums.Where(x => x < target).ToList();
            //    if (!test.Any()) { return 0; }
            //    else { return Array.IndexOf(nums, test.Last()) + 1; }
            //}

            #endregion

            #region Best Time to Buy and Sell Stock

            //int[] prices = {2, 4, 1};

            //int buy = prices[0], sell = 0;

            //for (int i = 1; i < prices.Length; i++)
            //{
            //    if (prices[i] < prices[i - 1] && prices[i] < buy )
            //    {
            //        buy = prices[i];
            //    }
            //    else if (prices[i] > sell) { sell = prices[i]; }
            //}

            #endregion
        }
    }
}