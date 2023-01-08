// Написать программу, которая из имеющегося массива строк, формирует массив строк,длина кторых меньше либо равна 3 символа.

// ["pictures", "2", "river", "+&*" ];
// ["1234", "567", "new year", "-1" ];
// ["Tomato", "Football", "Kitchen"];

//
string [] arr = {"pictures", "2", "river", "+&*"};

string [] sortedArr = {}; 
int count = 0; 

for ( int i = 0; i < arr.Length; i++)
{
 Console.WriteLine(arr[i].Length);
}

// string str = "pictures";
// int lengh = str.Length;

// Console.WriteLine("The length of '{0}' is {1}", str, str.Length);
// Console.WriteLine("The length of '{0}' is {1}", "+&*", "+&*".Length);