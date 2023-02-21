// See https://aka.ms/new-console-template for more information

using Assignment1;


// show data-value memory size
UnderstandingTypes.ShowValueTypesMemSize();

// century converter
CenturyConverter.ConvertCentury();


// test int overflow
int tmp = int.MaxValue;
WriteLine("testing overflow");
WriteLine($"tmp = {tmp}");
tmp += 1;
WriteLine($"tmp = {tmp}");

// infinite loop
// for ( ; true; );

// test code (cause infinite loop)
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     WriteLine(i);
// }


// Number guessing game
NumberGuessGame.GuessNumber();

// print pyramid
PyramidPrinter.PrintPyramid();


// Get Age
BirthdayCal.CalculateAge();

// greeting
Greeting.GreetingToYou();

// Count 24
CountingProgram.Count();