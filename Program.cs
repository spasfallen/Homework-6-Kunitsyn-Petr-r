// Task 1
// char[,] array = new char[,]
// {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'}
// };

// string result = string.Empty;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         result += array[i, j];
//     }
// }

// Console.WriteLine(result);

// Task 2

//string str = "aBcDief!";

//string lowerstr1 = str.ToLower();

//System.Console.WriteLine("aBcDief!".ToLower());

//Task 3
var str = "ababa";
str = str.Replace(" ", "").ToLower();
Console.WriteLine(str);
var t = new string(str.Reverse().ToArray());
Console.WriteLine(t == str ? "this is palindrom" : "this is not palindrom");
