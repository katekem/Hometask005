//Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
// Метод создания рандомного массива
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
// Задали массив и вывели его
int[] myArray = CreateRandomArray(5, 100, 999);
Console.WriteLine(String.Join(",", myArray));
// Код
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if(myArray[i]%2 == 0)
    {
        count ++;
    }
}
Console.WriteLine($"Количество четных элементов в массиве = {count}");