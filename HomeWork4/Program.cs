// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

void SearchMinAndMaxElement(int[] array, out int MaxNumber, out int MaxIndex, out int MinNumber, out int MinIndex)
{
    MaxNumber = array[0];
    MinNumber = array[0];
    MaxIndex = 0;
    MinIndex = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxNumber)
        {
            MaxNumber = array[i];
            MaxIndex = i;
        }

        if (array[i] < MinNumber)
        {
            MinNumber = array[i];
            MinIndex = i;
        }

    }
}


Console.Write("Введите значения m и n в строку через пробел и нажмите ввод ");
string[] num = Console.ReadLine().Split(' ');
var m = Convert.ToDouble(num[0]);
var n = Convert.ToDouble(num[1]);
int N = Convert.ToInt32(m*n);
int MaxNumber;
int MaxIndex;
int MinNumber;
int MinIndex;
int[] array = new int[N];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SearchMinAndMaxElement(array, out MaxNumber, out MaxIndex, out MinNumber, out MinIndex);
Console.WriteLine($"Максимальный элемент = {MaxNumber} его индекс = {MaxIndex} Минимальный элемент = {MinNumber} его индекс = {MinIndex}");


