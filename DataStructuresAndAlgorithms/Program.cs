// See https://aka.ms/new-console-template for more information
// Initializing static array
var array = new StaticArray<string>(5);
Console.WriteLine("Array capacity is: " + array.Capacity);

// Set values in array
array.Set(0, "Toyota");
array.Set(1, "Honda");
array.Set(2, "Mercedes");
array.Set(3, "BMW");
// array.Set(4, "Ford");
// Testing Index out of range exception
// array.Set(5, "Ford");

// Testing array length after setting
Console.WriteLine("Array length is: " + array.Length);

// Testing get methods
Console.WriteLine(array.Get(3));

