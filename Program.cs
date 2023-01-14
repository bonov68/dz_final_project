// Написать программу, которая из имеющегося массива строк, формирует массив строк,длина
//  которых меньше либо равна 3 символа.

// string[] arr = { "pictures", "2", "river", "+&*", "cat"};
// string[] arr = { "1234", "567", "new year", "-1" };
string[] arr = { "Tomato", "Football", "Kitchen" };

string[] sortedArr = new string[arr.Length];

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        sortedArr[i] = arr[i] ;
        Console.Write($"{sortedArr[i]},");
    }
}
Console.Write("]"); 
Console.WriteLine();

sortedArr = sortedArr.Where(a => !string.IsNullOrWhiteSpace(a)).ToArray();

for (int i = 0; i < sortedArr.Length; i++)
{
  Console.Write($"{sortedArr[i]}, ");
  }

