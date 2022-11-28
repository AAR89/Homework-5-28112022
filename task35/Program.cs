// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

Console.Clear();
int[] FillArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 1000);
    }
    return arr;
}
Console.Write("Введите длину массива: "); // ввод с длины с клавиатуры
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Длина массива может быть только больше 0.");
    return;
}
// int num = 123; фиксированный ввод с программы.
int[] array = FillArray(num);

int[] newArray = array;
int sumNumber = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] >= 10 && newArray[i] <= 99)
    {
        sumNumber++;
    }
}
Console.WriteLine('[' + string.Join(", ", array) +']' + ($" -> {sumNumber}"));



