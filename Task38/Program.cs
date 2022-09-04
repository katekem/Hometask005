// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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
int[] myArray = CreateRandomArray(10, 0, 100);
Console.WriteLine(String.Join(",", myArray));
// Код
int min = myArray[0];
int max = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < min)
    {
        min = myArray[i];
    }
    if (myArray[i] > max)
    {
        max = myArray[i];
    }
}
Console.WriteLine($"Минимальное значение массива = {min}");
Console.WriteLine($"Максимальное значение массива = {max}");
Console.WriteLine($"Разница между ними = {max - min}");