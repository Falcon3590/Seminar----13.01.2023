// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа в строку через пробел и нажмите ввод ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Array.ConvertAll - Преобразует массив одного типа в массив другого типа.
                                                                     // int.Parse - конвертирует набор строк в набор чисел
                                                                     // .Split() используется для разбиения строки с разделителями на подстроки. 
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Чисел больше 0 = {count}");


// Можно и без встроенных функций но тогда пользователь вводит количество цифр, а потом сами цифры.  

// Console.WriteLine("Введите количество чисел: ");
// int N = int.Parse(Console.ReadLine());
// int tmp = 0;
// int result = 0;
// Console.WriteLine("Введите N чисел через Enter");
// for (int i = 0; i < N; i++)
// {
//     tmp = Convert.ToInt32(Console.ReadLine());
//     if (tmp > 0)
//     {result++;}
// }
// Console.Clear();
// Console.WriteLine($"Пользователь ввел чисел больше 0  = {result}");
// Console.ReadKey();

