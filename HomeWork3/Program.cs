// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, 
// значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.


bool СheckingTriangle(int x, int y, int z)
{
    if ((x + y > z) && (y + z > x) && (x + z > y))
    {
        Console.WriteLine("Это треугольник");
        Console.WriteLine();
        return true;
    }
    else
    {
        Console.WriteLine("Это не треугольник");
        Console.WriteLine();
        return false;
    }
}

void ParametersTriangle(int x1, int y1, int z1)
{
    double x = Convert.ToDouble(x1);
    double y = Convert.ToDouble(y1);
    double z = Convert.ToDouble(z1);

    double p2 = x + y + z;
    Console.WriteLine("Периметр треугольника: " + p2);
    Console.WriteLine();

    double p = (x + y + z) / 2;
    Console.WriteLine("Площадь треугольника: " + Math.Sqrt(p * (p - x) * (p - y) * (p - z)));
    Console.WriteLine();

    double cos1 = Math.Acos((x * x + z * z - y * y) / (2 * x * z)) * 180 / Math. PI;
    double cos2 = Math.Acos((x * x + y * y - z * z) / (2 * x * y)) * 180 / Math. PI;
    double cos3 = Math.Acos((y * y + z * z - x * x) / (2 * z * y)) * 180 / Math. PI;

    Console.WriteLine($"Углы треугольника A = {cos1.ToString("0.00")} градусов, Б = {cos1.ToString("0.00")} градусов, С = {cos1.ToString("0.00")} градусов.");
    Console.WriteLine();

    if ((x * x + y * y == z * z) || (x * x + z * z == y * y) || (z * z + y * y == x * x))
    {
        Console.Write("Треугольник является прямоугольным");
    }
    else
    {
        Console.Write("Треугольник неявляется прямоугольным");
    }
    Console.WriteLine();

    if (x == y || x == z || y == z)
    {
        Console.Write("Треугольник является равнобедренным");
    }
    else
    {
        Console.Write("Треугольник неявляется равнобедренным");
    }
    Console.WriteLine();

    if (x == y && y == z && x == z)
    {
        Console.Write("Треугольник является равносторонним");
    }
    else
    {
        Console.Write("Треугольник неявляется равносторонним");
    }
    Console.WriteLine();
}


Console.Clear();
Console.Write("Введите 3 три целых положительных числа в строку через пробел и нажмите ввод ");
string[] num = Console.ReadLine().Split(' ');
var count1 = Convert.ToInt32(num[0]);
var count2 = Convert.ToInt32(num[1]);
var count3 = Convert.ToInt32(num[2]);
bool t = СheckingTriangle(count1, count2, count3);
if (t == true)
    ParametersTriangle(count1, count2, count3);