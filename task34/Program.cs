// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] FillArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Размер массива может быть только больше 0.");
    return;
}

int[] array = FillArray(num);

int[] newArray = array;
int sumNumber = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] % 2 == 0 && num > 0)
    {
        sumNumber++;
    }
}
Console.WriteLine(string.Join(", ", array) + ($" -> {sumNumber}"));
