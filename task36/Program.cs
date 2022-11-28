// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] FillArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Длина массива может быть только больше 0.");
    return;
}

int[] array = FillArray(num);

int[] newArray = array;
int sumNumber = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if (i % 2 != 0)
    {
        sumNumber = sumNumber + newArray[i];
    }
}
Console.WriteLine('[' + string.Join(", ", array) + ']' + ($" -> {sumNumber}"));
