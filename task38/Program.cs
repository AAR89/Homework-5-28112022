// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
double[] FillArray(int num)
{
    double[] arr = new Double[num];
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = Math.Round(Convert.ToDouble(new Random().Next(-20,20)) + new Random().NextDouble(), 2);
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

double[] array = FillArray(num);

double maxNumber = array[0];
double minNumber = array[0];
 
for (int i = 0; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    else if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}

double decision = Math.Round(maxNumber - Math.Abs(minNumber), 2);

Console.WriteLine('[' + string.Join(", ", array) + ']' + ($" -> {decision}"));