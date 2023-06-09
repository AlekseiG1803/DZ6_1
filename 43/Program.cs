// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите b1, k1, b2, k2 через пробел: ");
string elements = Console.ReadLine();
double[] baseArray = GetArrayFromString(elements);

double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = double.Parse(nums[i]);
    }
    return res;
}

double[] Result(double[] array){

    double[] result = new double[2];

    result[0] = (array[2] - array[0]) / (array[1] - array[3]);
    result[1] = (array[1] * result[0]) + array[0];

    return result;
}

Console.WriteLine($"[{String.Join(",", Result(baseArray))}]");