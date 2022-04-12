using System;
using Task1;

var text = Console.ReadLine();

var frequencyCounter = new FrequencyCounter();
var result = frequencyCounter.Count(text);
result = result.Substring(0, result.Length - 1);

Console.WriteLine(result);