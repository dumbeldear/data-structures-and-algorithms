
using DataStructuresAndAlgorithms.DataStructures.LinkedList;
using DataStructuresAndAlgorithms.DataStructures;
/*
// Initializing static array
var array = new StaticArray<string>(5);
Console.WriteLine("Array capacity is: " + array.Capacity);

// Set values in array
array.Set(0, "Toyota");
array.Set(1, "Honda");
array.Set(2, "Mercedes");
array.Set(3, "BMW");
array.Set(4, "Ford");
// Testing Index out of range exception
// array.Set(5, "Ford");

// Testing array length after setting
Console.WriteLine("Array length is: " + array.Length);

// Testing get methods
Console.WriteLine(array.Get(3));

// Testing Append
array.Append("Holden");
Console.WriteLine(array.Get(5));

// Append should have triggered a Resize
Console.WriteLine("Array capacity is: " + array.Capacity);

// Try removing - Mercedes should disappear
array.RemoveAt(2);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array.Get(i));
}

Console.WriteLine(array.ToString());
*/

var linkedList = 
    new DataStructuresAndAlgorithms.DataStructures.LinkedList.LinkedList<string>();
linkedList.AddFirst("1");
linkedList.AddFirst("2");
linkedList.AddFirst("3");
linkedList.AddFirst("4");
linkedList.AddFirst("5");
linkedList.AddLast("6");
linkedList.AddLast("7");

Console.WriteLine(linkedList.ToString());
Console.WriteLine(linkedList.Contains("4"));
Console.WriteLine(linkedList.Contains("8"));

//linkedList.RemoveFirst();
//Console.WriteLine(linkedList.ToString());

linkedList.Remove("6");
Console.WriteLine(linkedList.ToString());

linkedList.Clear();
Console.WriteLine(linkedList.ToString());