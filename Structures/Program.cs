
using Structures;

int[] array = new int[] { 1, 13, 45, 2, 18, 8 };

Sorter sorter = new Sorter(array);

//var result = sorter.BubleSort(false);

var result = sorter.SelectionSort();

Console.ReadLine();

