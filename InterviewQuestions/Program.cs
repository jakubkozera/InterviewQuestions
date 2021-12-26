var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

var x = numbers.FirstOrDefault(x => x > 15);
var x = numbers.First(x => x > 15);

Console.WriteLine(x);