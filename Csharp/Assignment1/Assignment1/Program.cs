// See https://aka.ms/new-console-template for more information

using System.Collections;
using Assignment1;


// show data-value memory size
UnderstandingTypes.ShowValueTypesMemSize();


// // century converter
// CenturyConverter.ConvertCentury();

// // // test int overflow
// // int tmp = int.MaxValue;
// // WriteLine("testing overflow");
// // WriteLine($"tmp = {tmp}");
// // tmp += 1;
// // WriteLine($"tmp = {tmp}");
//
// // // infinite loop
// // for ( ; true; );
//
// // test code (cause infinite loop)
// // int max = 500;
// // for (byte i = 0; i < max; i++)
// // {
// //     WriteLine(i);
// // }
//
//
// // Number guessing game
// NumberGuessGame.GuessNumber();
//
// // print pyramid
// PyramidPrinter.PrintPyramid();
//
//
// // Get Age
// BirthdayCal.CalculateAge();
//
// // greeting
// Greeting.GreetingToYou();
//
// // Count 24
// CountingProgram.Count();

// // Copy Array
// int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// int[] newArr = ArrayUtils.CopyArray(arr);
// for (int i = 0; i < newArr.Length; i++)
// {
//     Write($"{newArr[i]}, ");
// }

// // mytodo list
// TodoCls todoCls = new TodoCls();
// todoCls.ModifyList();

// // Find Prime numbers
// int[] primes = PrimeFinder.FindPrimesInRange(1, 100);
// foreach (var prime in primes)
// {
//     Write($"{prime}, ");
// }

// // Rotate sum
// int[] nums = new[] { 3, 2, 4, -1 };
// ArrayUtils.SumRotateArray(nums, 2);

// // Find Longest Sequence
// int[] nums = new[] { 0, 1, 1, 5, 2, 2, 6, 3, 3 };
// ArrayUtils.FindLongestSequence(nums);

// // Find most frequent
// int[] nums = new[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
// WriteLine($"the most frequent number: {ArrayUtils.FindMostFrequent(nums)}");

// // Reverse string
// string testVal = "Sample";
// WriteLine($"Reverse string {testVal} => {StringUtils.ReverseString(testVal)}");

// // Reverse Sentence (non fully implement)
// string test = "C# is not C++, and PHP is not Delphi!";
// WriteLine($"{test} reverse -> {StringUtils.ReverseWords(test)}");


// //Find Palindrom in senetences
// string test = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
// WriteLine($"find palindromes in {test}: {StringUtils.FindPalindrone(test)}");

// // Parse URL
// string test = "www.apple.com";
// string[] parsed = StringUtils.ParseUrl(test);
// WriteLine($"test url: {test} => protocol: {parsed[0]}, server: {parsed[1]}, resource: {parsed[2]}");