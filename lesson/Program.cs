// Задача 39: перевернуть одномерный массив.

// void FillArray(int [] array)
// {
//     for (int i=0;i<array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int [] mas)
// {
//     for (int i=0;i<mas.Length; i++)
//         Console.Write($"{mas[i]} ");
//     Console.WriteLine();
// }

// void Reverse(int [] array)  
// {
//     // int temp;
//     for (int i = 0; i<array.Length/2;i++)
//     {
//         // temp = array[i];
//         // array[i] = array[array.L ength-1-i];
//         // array[array.Length-1-i] = temp;
//         (array[i] , array[array.Length-1-i]) = (array[array.Length-1-i], array[i] );

//     }
// }


// Console.WriteLine("Введите размерность массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];
// FillArray(array);
// PrintArray(array);
// Reverse(array);
// PrintArray(array);


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());

// void dectodouble(int n)
// {
//     string array = string.Empty;
//     while (n > 0)
//     {
//         // if (n % 2 == 0) array ="0" + array;
//         // else array ="1" + array;
//         array = $"{n%2}" + array;
//         n = n / 2;
//     } 
//     Console.WriteLine(array);
// }

// dectodouble(number);


//задача 40: напишите программу которая принимает на входж 3 числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины 
// (теорема о неравенстве треугольника : каждая сторона треугольника меньше суммы двух других сторон)



// Console.WriteLine( "Число один ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Число два ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Число три ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a+b > c && b+c > a && a+c > b  ) 
// {
//     Console.WriteLine(" может существовать");
// }
// else Console.WriteLine("Не может существовать ");


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 ->  0 1 1 2 3 5 8

Console.WriteLine("Введите число фибоначчи");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
}
void PrintArray(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]} ");
    Console.WriteLine();
}