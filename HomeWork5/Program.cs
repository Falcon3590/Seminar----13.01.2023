// Задача 6sem VERY HARD необязательная 
// Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. 
// Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
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

void SequenceSearch(int[] vargu)
{
    int pos = 0, bestpos = 0, bestlen = 0;
    int len = 1;
    for (int i = 0; i < vargu.Length - 1; i++)
    {
        if (vargu[i] == vargu[i + 1])
        {
            len++;
            if (len > bestlen)
            {
                bestlen = len;
                bestpos = pos;
            }
        }
        else
        {
            len = 1;
            pos = i + 1;
        }
    }
    for (int k = bestpos; k <= bestpos + bestlen; k++)
    {
        Console.Write("{0} ", vargu[k]);
    }
    Console.ReadLine();
}




Console.Clear();
Console.Write("Задайте длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
SequenceSearch(array);





