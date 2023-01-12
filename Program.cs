// Написать программу, которая из имеющегося массива строк, формирует массив строк,длина
//  которых меньше либо равна 3 символа.

// ["pictures", "2", "river", "+&*", "cat"];
// ["1234", "567", "new year", "-1" ];
// ["Tomato", "Football", "Kitchen"];

    // Console.WriteLine(arr[i].Length);
//
// string[] arr = { "pictures", "2", "river", "+&*", "cat"};
string [] arr = {"1234", "567", "new year", "-1" };
// string[] sortedArr = { };

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
      Console.Write($"{arr[i]},");
    }
}
  Console.Write("]");

// string str = "pictures";
// int lengh = str.Length;

// Console.WriteLine("The length of '{0}' is {1}", str, str.Length);
// Console.WriteLine("The length of '{0}' is {1}", "+&*", "+&*".Length);